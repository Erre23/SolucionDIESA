using CapaEntidad;
using CapaLogica;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmMetodoPago : Form
    {
        ToolStripMenuItem _menu;
        public FrmMetodoPago(ToolStripMenuItem menu)
        {
            _menu = menu;
            _menu.Enabled = false;
            InitializeComponent();
            SetAccion(FormAccion.ninguno);
        }

        private async void FrmMetodoPago_Load(object sender, EventArgs e)
        {
            try
            {
                DgvMetodoPago.Rows.Clear();
                this.Cursor = Cursors.WaitCursor;

                var lista = await LogMetodoPago.Instancia.MetodoPagoListarTodos();

                foreach (var item in lista)
                {
                    DgvMetodoPago_Agregar(item);
                }

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(this, ex.Message, "Se produjo un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMetodoPago_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((this.Accion == FormAccion.nuevo || this.Accion == FormAccion.editar) && 
                MessageBox.Show(this, "¿Está seguro de cerrar esta ventana? los datos que no han sido guardados se perderán", "Un momento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #region Métodos

        private void DgvMetodoPago_Agregar(MetodoPago MetodoPago)
        {
            var indice = 
                DgvMetodoPago.Rows.Add(
                    MetodoPago.Nombre, 
                    MetodoPago.Activo ? "SI" : ""
                );
            DgvMetodoPago.Rows[indice].Tag = MetodoPago;
        }

        private void DgvMetodoPago_Actualizar(MetodoPago MetodoPago)
        {

            DgvMetodoPago.CurrentRow.Tag = MetodoPago;
            DgvMetodoPago.CurrentRow.Cells[0].Value = MetodoPago.Nombre;
            DgvMetodoPago.CurrentRow.Cells[1].Value = MetodoPago.Activo ? "SI" : "";
        }

        private FormAccion Accion;
        private MetodoPago CurrentMetodoPago;

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
        }
        private void GbDatos_MostrarDatos(MetodoPago MetodoPago)
        {
            this.CurrentMetodoPago = MetodoPago;
            
            TbNombre.Text = MetodoPago.Nombre;
        }

        public void SetAccion(FormAccion accion)
        {
            GBDatos_Limpiar();
            this.Accion = accion;
            this.CurrentMetodoPago = null;
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
            var MetodoPago = (MetodoPago)DgvMetodoPago.CurrentRow?.Tag;
            if (MetodoPago == null)
            {
                MessageBox.Show(this, "Olvidó seleccionar un tipo de inspección", "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            SetAccion(FormAccion.editar);
            GbDatos_MostrarDatos(MetodoPago);
        }

        private async void BnDeshabilitar_Click(object sender, EventArgs e)
        {
            var MetodoPago = (MetodoPago)DgvMetodoPago.CurrentRow?.Tag;
            if (MetodoPago == null)
            {
                MessageBox.Show(this, "Olvidó seleccionar un tipo de inspección", "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string datos = "\n";
            datos += "\n\r - Nombre: " + MetodoPago.Nombre;

            if (MessageBox.Show(this, "¿Está seguro de deshabilitar al tipo de inspección?" + datos, "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                BnDeshabilitar.Enabled = false;
                this.Cursor = Cursors.WaitCursor;
                await LogMetodoPago.Instancia.MetodoPagoDeshabilitar(MetodoPago.IdMetodoPago);
                MetodoPago.Activo = false;
                DgvMetodoPago_Actualizar(MetodoPago);


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

                if (!string.IsNullOrEmpty(datosFaltantes))
                {
                    MessageBox.Show(this, "Olvidó ingresar los siguientes datos: " + datosFaltantes, "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                if (this.Accion == FormAccion.nuevo) this.CurrentMetodoPago = new MetodoPago();
                this.CurrentMetodoPago.Nombre = TbNombre.Text.Trim();

                if (MessageBox.Show(this, "¿Está seguro guardar los datos?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }


                BnGuardar.Enabled = false;
                this.Cursor = Cursors.WaitCursor;

                if (this.Accion == FormAccion.nuevo)
                {
                    this.CurrentMetodoPago.IdMetodoPago = await LogMetodoPago.Instancia.MetodoPagoInsertar(this.CurrentMetodoPago);
                    DgvMetodoPago_Agregar(this.CurrentMetodoPago);
                }
                else
                {
                    await LogMetodoPago.Instancia.MetodoPagoActualizar(this.CurrentMetodoPago);
                    DgvMetodoPago_Actualizar(this.CurrentMetodoPago);
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

        private void FrmMetodoPago_FormClosed(object sender, FormClosedEventArgs e)
        {
            this._menu.Enabled = true;
        }
    }
}
