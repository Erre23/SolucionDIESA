using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Controls;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace CapaPresentacion
{
    public partial class FrmInspector : Form
    {
        ToolStripMenuItem _menu;
        public FrmInspector(ToolStripMenuItem menu)
        {
            _menu = menu;
            _menu.Enabled = false;
            InitializeComponent();
            BnFiltrar.Location = BnCancelar.Location;
            SetAccion(FormAccion.ninguno);
        }

        private async void FrmInspector_Load(object sender, EventArgs e)
        {
            try
            {
                CmbTipoDocumentoIdentidad.Items.Clear();
                CmbTipoDocumentoIdentidad.DisplayMember = "Nombre";
                var tiposDocumentoIdentidad = await LogTipoDocumentoIdentidad.Instancia.TipoDocumentoIdentidadListarActivos();
                tiposDocumentoIdentidad.RemoveAll(x => x.PersonaJuridica);
                foreach (var item in tiposDocumentoIdentidad)
                {
                    CmbTipoDocumentoIdentidad.Items.Add(item);
                }

                if (CmbTipoDocumentoIdentidad.Items.Count > 0) CmbTipoDocumentoIdentidad.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Se produjo un error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void FrmInspector_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((this.Accion == FormAccion.nuevo || this.Accion == FormAccion.editar) && 
                MessageBox.Show(this, "¿Está seguro de cerrar esta ventana? los datos que no han sido guardados se perderán", "Un momento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #region Métodos

        private void DgvInspector_Agregar(Inspector Inspector)
        {
            var indice = 
                DgvInspector.Rows.Add(
                    Inspector.TipoDocumentoIdentidad.Nombre, 
                    Inspector.NumeroDocumentoIdentidad, 
                    Inspector.ApellidosYNombres,
                    Inspector.Celular, 
                    Inspector.Email, 
                    Inspector.Activo ? "SI" : ""
                );
            DgvInspector.Rows[indice].Tag = Inspector;
        }

        private void DgvInspector_Actualizar(Inspector Inspector)
        {

            DgvInspector.CurrentRow.Tag = Inspector;
            DgvInspector.CurrentRow.Cells[0].Value = Inspector.TipoDocumentoIdentidad.Nombre;
            DgvInspector.CurrentRow.Cells[1].Value = Inspector.NumeroDocumentoIdentidad;
            DgvInspector.CurrentRow.Cells[2].Value = Inspector.ApellidosYNombres;
            DgvInspector.CurrentRow.Cells[3].Value = Inspector.Celular;
            DgvInspector.CurrentRow.Cells[4].Value = Inspector.Email;
            DgvInspector.CurrentRow.Cells[5].Value = Inspector.Activo ? "SI" : "";
        }

        private FormAccion Accion;
        private Inspector CurrentInspector;

        public void Botones_Enabled(bool nuevo, bool editar, bool deshabilitar, bool buscar)
        {
            BnNuevo.Enabled = nuevo;
            BnEditar.Enabled = editar;
            BnDeshabilitar.Enabled = deshabilitar;
            BnBuscar.Enabled = buscar;
        }

        public void Botones_Visible(bool guardar, bool cancelar, bool filtrar)
        {
            BnGuardar.Visible = guardar;
            BnCancelar.Visible = cancelar;
            BnFiltrar.Visible = filtrar;
        }

        public void GBDatos_Limpiar()
        {
            CmbTipoDocumentoIdentidad.SelectedIndex = -1;
            TbDocumentoIdentidadNumero.Clear();
            TbNombres.Clear();
            TbApellido1.Clear();
            TbApellido2.Clear();
            TbCelular.Clear();
            TbEmail.Clear();
        }
        private void GbDatos_MostrarDatos(Inspector Inspector)
        {
            this.CurrentInspector = Inspector;
            for (int indice = 0; indice < CmbTipoDocumentoIdentidad.Items.Count; indice++)
            {
                if((CmbTipoDocumentoIdentidad.Items[indice] as TipoDocumentoIdentidad).IdTipoDocumentoIdentidad == Inspector.IdTipoDocumentoIdentidad)
                {
                    CmbTipoDocumentoIdentidad.SelectedIndex = indice;
                    break;
                }
            }
            TbDocumentoIdentidadNumero.Text = Inspector.NumeroDocumentoIdentidad;
            TbNombres.Text = Inspector.Nombres;
            TbApellido1.Text = Inspector.Apellido1;
            TbApellido2.Text = Inspector.Apellido2;
            TbCelular.Text = Inspector.Celular;
            TbEmail.Text = Inspector.Email;
        }

        public void SetAccion(FormAccion accion)
        {
            GBDatos_Limpiar();
            this.Accion = accion;
            this.CurrentInspector = null;
            switch(this.Accion)
            {
                case FormAccion.ninguno:
                    LbOpcion.Text = "";
                    Botones_Enabled(true, true, true, true);
                    Botones_Visible(false, false, false);
                    GbDatos.Enabled = false;
                    GbLista.Enabled = true;
                    break;
                case FormAccion.nuevo:
                    LbOpcion.Text = "OPCIÓN : NUEVO";
                    CmbTipoDocumentoIdentidad.SelectedIndex = 0;
                    Botones_Enabled(false, false, false, false);
                    Botones_Visible(true, true, false);
                    GbDatos.Enabled = true;
                    GbLista.Enabled = false;
                    break;
                case FormAccion.editar:
                    LbOpcion.Text = "OPCIÓN : EDITAR";
                    Botones_Enabled(false, false, false, false);
                    Botones_Visible(true, true, false);
                    GbDatos.Enabled = true;
                    GbLista.Enabled = false;
                    break;
                case FormAccion.buscar:
                    LbOpcion.Text = "OPCIÓN : BUSCAR";
                    Botones_Enabled(true, true, true, false);
                    Botones_Visible(false, false, true);
                    GbDatos.Enabled = true;
                    GbLista.Enabled = true;
                    break;
            }
        }

        #endregion Métodos

        private void CmbTipoDocumentoIdentidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tipoDocumentoIdentidad = (TipoDocumentoIdentidad)CmbTipoDocumentoIdentidad.SelectedItem;
            if (tipoDocumentoIdentidad == null)
            {
                TbDocumentoIdentidadNumero.MaxLength = 0;
                TbDocumentoIdentidadNumero.TipoCaracteres = CustomTextBox.TipoInput.Todo;
            }
            else
            {
                TbDocumentoIdentidadNumero.MaxLength = tipoDocumentoIdentidad.LongitudMaxima;
                TbDocumentoIdentidadNumero.TipoCaracteres = tipoDocumentoIdentidad.Alfanumerico ? CustomTextBox.TipoInput.NumerosYLetras : CustomTextBox.TipoInput.SoloNumeros;
            }
            TbDocumentoIdentidadNumero.Clear();
        }

        private void BnNuevo_Click(object sender, EventArgs e)
        {
            SetAccion(FormAccion.nuevo);
        }

        private void BnEditar_Click(object sender, EventArgs e)
        {
            var Inspector = (Inspector)DgvInspector.CurrentRow?.Tag;
            if (Inspector == null)
            {
                MessageBox.Show(this, "Olvidó seleccionar un Inspector", "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            SetAccion(FormAccion.editar);
            GbDatos_MostrarDatos(Inspector);
        }

        private async void BnDeshabilitar_Click(object sender, EventArgs e)
        {
            var Inspector = (Inspector)DgvInspector.CurrentRow?.Tag;
            if (Inspector == null)
            {
                MessageBox.Show(this, "Olvidó seleccionar un Inspector", "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string datosInspector = "\n";
            datosInspector += "\n\r - Tipo de Doc.:" + Inspector.TipoDocumentoIdentidad.Nombre;
            datosInspector += "\n\r - Nº de Documento: " + Inspector.NumeroDocumentoIdentidad;
            datosInspector += "\n\r - Nombres: " + Inspector.Nombres;
            datosInspector += "\n\r - Apellido1: " + Inspector.Apellido1;
            datosInspector += "\n\r - Apellido2: " + Inspector.Apellido2;

            if (MessageBox.Show(this, "¿Está seguro de deshabilitar al Inspector?" + datosInspector, "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                BnDeshabilitar.Enabled = false;
                this.Cursor = Cursors.WaitCursor;
                await LogInspector.Instancia.InspectorDeshabilitar(Inspector.IdInspector);
                Inspector.Activo = false;
                DgvInspector_Actualizar(Inspector);


                this.Cursor = Cursors.Default;
                MessageBox.Show(this, "El Inspector fue deshabilitado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BnBuscar_Click(object sender, EventArgs e)
        {
            SetAccion(FormAccion.buscar);
        }

        private async void BnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var datosFaltantes = "";
                var tipoDocumentoIdentidad = (TipoDocumentoIdentidad)CmbTipoDocumentoIdentidad.SelectedItem;

                if (TbDocumentoIdentidadNumero.Text.Trim() == "") datosFaltantes += "\n\r - Nº de documento de identidad";
                if (TbNombres.Text.Trim() == "") datosFaltantes += "\n\r - Nombres";
                if (TbApellido1.Text.Trim() == "") datosFaltantes += "\n\r - Apellido1";

                if (!string.IsNullOrEmpty(datosFaltantes))
                {
                    MessageBox.Show(this, "Olvidó ingresar los siguientes datos: " + datosFaltantes, "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var documentoIdentidadNumero = TbDocumentoIdentidadNumero.Text.Trim();
                if (tipoDocumentoIdentidad.LongitudMinima > documentoIdentidadNumero.Length)
                {
                    string mensaje = $"El tipo de documento de identidad \"{tipoDocumentoIdentidad.Nombre}\" debe tener como mínimo {tipoDocumentoIdentidad.LongitudMinima} dígitos";
                    MessageBox.Show(this, mensaje, "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (this.Accion == FormAccion.nuevo) this.CurrentInspector = new Inspector();
                this.CurrentInspector.TipoDocumentoIdentidad = tipoDocumentoIdentidad;
                this.CurrentInspector.IdTipoDocumentoIdentidad = tipoDocumentoIdentidad.IdTipoDocumentoIdentidad;
                this.CurrentInspector.NumeroDocumentoIdentidad = TbDocumentoIdentidadNumero.Text.Trim();
                this.CurrentInspector.Nombres = TbNombres.Text.Trim();
                this.CurrentInspector.Apellido1 = TbApellido1.Text.Trim();
                this.CurrentInspector.Apellido2 = TbApellido2.Text.Trim();
                this.CurrentInspector.Celular = TbCelular.Text.Trim();
                this.CurrentInspector.Email = TbEmail.Text.Trim();

                if (MessageBox.Show(this, "¿Está seguro guardar los datos?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }


                BnGuardar.Enabled = false;
                this.Cursor = Cursors.WaitCursor;

                if (this.Accion == FormAccion.nuevo)
                {
                    this.CurrentInspector.IdInspector = await LogInspector.Instancia.InspectorInsertar(this.CurrentInspector);
                    DgvInspector_Agregar(this.CurrentInspector);
                }
                else
                {
                    await LogInspector.Instancia.InspectorActualizar(this.CurrentInspector);
                    DgvInspector_Actualizar(this.CurrentInspector);
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

        private async void BnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                DgvInspector.Rows.Clear();
                BnFiltrar.Enabled = false;
                this.Cursor = Cursors.WaitCursor;

                var tipoDocumentoIdentidad = (TipoDocumentoIdentidad)CmbTipoDocumentoIdentidad.SelectedItem;
                var listaInspectors = await LogInspector.Instancia.InspectorBusquedaGeneral(
                    tipoDocumentoIdentidad?.IdTipoDocumentoIdentidad,
                    TbDocumentoIdentidadNumero.Text.Trim(),
                    TbNombres.Text.Trim(),
                    TbApellido1.Text.Trim(),
                    TbApellido2.Text.Trim()
                );

                foreach (var Inspector in listaInspectors)
                {
                    DgvInspector_Agregar(Inspector);
                }

                BnFiltrar.Enabled = true;
                this.Cursor = Cursors.Default;

                if (listaInspectors.Count() == 0)
                {
                    MessageBox.Show(this, "No se encontraron resultados con los datos de búsqueda ingresado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(this, ex.Message, "Se produjo un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BnFiltrar.Enabled = true;
            }
        }

        private void BnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInspector_FormClosed(object sender, FormClosedEventArgs e)
        {
            this._menu.Enabled = true;
        }
    }
}
