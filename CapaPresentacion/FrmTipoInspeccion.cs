﻿using CapaEntidad;
using CapaLogica;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmTipoInspeccion : Form
    {
        ToolStripMenuItem _menu;
        public FrmTipoInspeccion(ToolStripMenuItem menu)
        {
            _menu = menu;
            _menu.Enabled = false;
            InitializeComponent();
            SetAccion(FormAccion.ninguno);
        }

        private async void FrmTipoInspeccion_Load(object sender, EventArgs e)
        {
            try
            {
                DgvTipoInspeccion.Rows.Clear();
                this.Cursor = Cursors.WaitCursor;

                var lista = await LogTipoInspeccion.Instancia.TipoInspeccionListarTodos();

                foreach (var item in lista)
                {
                    DgvTipoInspeccion_Agregar(item);
                }

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(this, ex.Message, "Se produjo un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmTipoInspeccion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((this.Accion == FormAccion.nuevo || this.Accion == FormAccion.editar) && 
                MessageBox.Show(this, "¿Está seguro de cerrar esta ventana? los datos que no han sido guardados se perderán", "Un momento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #region Métodos

        private void DgvTipoInspeccion_Agregar(TipoInspeccion TipoInspeccion)
        {
            var indice = 
                DgvTipoInspeccion.Rows.Add(
                    TipoInspeccion.Nombre, 
                    TipoInspeccion.Precio.ToString("S/ #0.00"), 
                    TipoInspeccion.Activo ? "SI" : ""
                );
            DgvTipoInspeccion.Rows[indice].Tag = TipoInspeccion;
        }

        private void DgvTipoInspeccion_Actualizar(TipoInspeccion TipoInspeccion)
        {

            DgvTipoInspeccion.CurrentRow.Tag = TipoInspeccion;
            DgvTipoInspeccion.CurrentRow.Cells[0].Value = TipoInspeccion.Nombre;
            DgvTipoInspeccion.CurrentRow.Cells[1].Value = TipoInspeccion.Precio.ToString("S/ #0.00");
            DgvTipoInspeccion.CurrentRow.Cells[2].Value = TipoInspeccion.Activo ? "SI" : "";
        }

        private FormAccion Accion;
        private TipoInspeccion CurrentTipoInspeccion;

        public void Botones_Enabled(bool nuevo, bool editar, bool deshabilitar)
        {
            BnNuevo.Enabled = nuevo;
            BnEditar.Enabled = editar;
            BnDeshabilitar.Enabled = deshabilitar;
        }

        public void Botones_Visible(bool guardar, bool cancelar)
        {
            BnGuardar.Visible = guardar;
            BnCancelar.Visible = cancelar;
        }

        public void GBDatos_Limpiar()
        {   
            TbNombre.Clear();
            TbPrecio.Clear();
        }
        private void GbDatos_MostrarDatos(TipoInspeccion TipoInspeccion)
        {
            this.CurrentTipoInspeccion = TipoInspeccion;
            
            TbNombre.Text = TipoInspeccion.Nombre;
            TbPrecio.Text = TipoInspeccion.Precio.ToString();
        }

        public void SetAccion(FormAccion accion)
        {
            GBDatos_Limpiar();
            this.Accion = accion;
            this.CurrentTipoInspeccion = null;
            switch(this.Accion)
            {
                case FormAccion.ninguno:
                    LbOpcion.Text = "";
                    Botones_Enabled(true, true, true);
                    Botones_Visible(false, false);
                    GbDatos.Enabled = false;
                    GbLista.Enabled = true;
                    break;
                case FormAccion.nuevo:
                    LbOpcion.Text = "OPCIÓN : NUEVO";
                    Botones_Enabled(false, false, false);
                    Botones_Visible(true, true);
                    GbDatos.Enabled = true;
                    GbLista.Enabled = false;
                    break;
                case FormAccion.editar:
                    LbOpcion.Text = "OPCIÓN : EDITAR";
                    Botones_Enabled(false, false, false);
                    Botones_Visible(true, true);
                    GbDatos.Enabled = true;
                    GbLista.Enabled = false;
                    break;
            }
        }

        #endregion Métodos

        private void BnNuevo_Click(object sender, EventArgs e)
        {
            SetAccion(FormAccion.nuevo);
        }

        private void BnEditar_Click(object sender, EventArgs e)
        {
            var TipoInspeccion = (TipoInspeccion)DgvTipoInspeccion.CurrentRow?.Tag;
            if (TipoInspeccion == null)
            {
                MessageBox.Show(this, "Olvidó seleccionar un tipo de inspección", "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            SetAccion(FormAccion.editar);
            GbDatos_MostrarDatos(TipoInspeccion);
        }

        private async void BnDeshabilitar_Click(object sender, EventArgs e)
        {
            var TipoInspeccion = (TipoInspeccion)DgvTipoInspeccion.CurrentRow?.Tag;
            if (TipoInspeccion == null)
            {
                MessageBox.Show(this, "Olvidó seleccionar un tipo de inspección", "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string datos = "\n";
            datos += "\n\r - Nombre: " + TipoInspeccion.Nombre;

            if (MessageBox.Show(this, "¿Está seguro de deshabilitar al tipo de inspección?" + datos, "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                BnDeshabilitar.Enabled = false;
                this.Cursor = Cursors.WaitCursor;
                await LogTipoInspeccion.Instancia.TipoInspeccionDeshabilitar(TipoInspeccion.IdTipoInspeccion);
                TipoInspeccion.Activo = false;
                DgvTipoInspeccion_Actualizar(TipoInspeccion);


                this.Cursor = Cursors.Default;
                MessageBox.Show(this, "El tipo de inspección fue deshabilitado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BnDeshabilitar.Enabled = true;

                SetAccion(FormAccion.ninguno);
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(this, ex.Message, "Se produjo un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BnDeshabilitar.Enabled = true;
            }
        }

        private async void BnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var datosFaltantes = "";
               
                if (TbNombre.Text.Trim() == "") datosFaltantes += "\n\r - Nombre";
                if (TbPrecio.Text.Trim() == "") datosFaltantes += "\n\r - Precio";

                if (!string.IsNullOrEmpty(datosFaltantes))
                {
                    MessageBox.Show(this, "Olvidó ingresar los siguientes datos: " + datosFaltantes, "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                if (this.Accion == FormAccion.nuevo) this.CurrentTipoInspeccion = new TipoInspeccion();
                this.CurrentTipoInspeccion.Nombre = TbNombre.Text.Trim();
                this.CurrentTipoInspeccion.Precio = Convert.ToDecimal(TbPrecio.Text.Trim());

                if (MessageBox.Show(this, "¿Está seguro guardar los datos?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }


                BnGuardar.Enabled = false;
                this.Cursor = Cursors.WaitCursor;

                if (this.Accion == FormAccion.nuevo)
                {
                    this.CurrentTipoInspeccion.IdTipoInspeccion = await LogTipoInspeccion.Instancia.TipoInspeccionInsertar(this.CurrentTipoInspeccion);
                    DgvTipoInspeccion_Agregar(this.CurrentTipoInspeccion);
                }
                else
                {
                    await LogTipoInspeccion.Instancia.TipoInspeccionActualizar(this.CurrentTipoInspeccion);
                    DgvTipoInspeccion_Actualizar(this.CurrentTipoInspeccion);
                }

                
                this.Cursor = Cursors.Default;
                MessageBox.Show(this, "Los datos fueron guardados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BnGuardar.Enabled = true;

                SetAccion(FormAccion.ninguno);
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(this, ex.Message, "Se produjo un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BnGuardar.Enabled = true;
            }
        }

        private void BnCancelar_Click(object sender, EventArgs e)
        {
            SetAccion(FormAccion.ninguno);
        }

        private void BnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTipoInspeccion_FormClosed(object sender, FormClosedEventArgs e)
        {
            this._menu.Enabled = true;
        }
    }
}
