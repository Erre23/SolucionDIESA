using CapaEntidad;
using CapaLogica;
using CapaPresentacion.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmProgramacionInspeccion : Form
    {

        public FrmProgramacionInspeccion()
        {
            InitializeComponent();

            //CbTipoDocumentoIdentidad.Items.Add("DNI");
            //CbTipoDocumentoIdentidad.Items.Add("Carnet de Extranjería");
            //CbTipoDocumentoIdentidad.Items.Add("RUC");

            //CbTipoInspeccion.Items.Add("INSPECCIÓN CABINA");
            //CbTipoInspeccion.Items.Add("INSPECCIÓN TRACTO");
            //CbTipoInspeccion.Items.Add("INSPECCIÓN CABINA Y TRACTO");

            //CbTaller.Items.Add("TALLER MANUCCI TUPAC AMARU");
            //CbTaller.Items.Add("TALLER TOYOTA SERVICIOS");

            //CbHora.Items.Add("08:00 am");
            //CbHora.Items.Add("09:00 am");
            //CbHora.Items.Add("10:00 am");
            //CbHora.Items.Add("11:00 am");
            //CbHora.Items.Add("12:00 pm");
            //CbHora.Items.Add("01:00 pm");
            //CbHora.Items.Add("02:00 pm");
            //CbHora.Items.Add("03:00 pm");

            //CbInspector.Items.Add("Eduardo Rodríguez Escobar");
            //CbInspector.Items.Add("Daniel Ibañez Zaldivar");
            //CbInspector.Items.Add("Sheyla Diaz Lavado");
            //CbInspector.Items.Add("Cesia Riquelme Carrasco");

            //CbFormaPago.Items.Add("TRANSFERENCIA");
            //CbFormaPago.Items.Add("EFECTIVO");
            //CbFormaPago.Items.Add("TARJETA");

            //CbTipoComprobante.Items.Add("BOLETA");
            //CbTipoComprobante.Items.Add("FACTURA");

            SetAccion(FormAccion.ninguno);
        }

        private async void FrmProgramacionInspeccion_Load(object sender, EventArgs e)
        {
            try
            {
                CmbTipoDocumentoIdentidad.Items.Clear();
                CmbTipoDocumentoIdentidad.DisplayMember = "Nombre";
                var tiposDocumentoIdentidad = await LogTipoDocumentoIdentidad.Instancia.TipoDocumentoIdentidadListarActivos();
                foreach (var item in tiposDocumentoIdentidad)
                {
                    CmbTipoDocumentoIdentidad.Items.Add(item);
                }

                if (CmbTipoDocumentoIdentidad.Items.Count > 0) CmbTipoDocumentoIdentidad.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Se produjo un error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void DgvTareas_Agregar(string tarea, decimal precio)
        {
            DgvTarea.Rows.Add(tarea, precio.ToString("S/ #0.00"));
        }

        private FormAccion Accion;

        public void Botones_Enabled(bool nuevo, bool anular, bool buscar, bool guardar, bool cancelar)
        {
            BnNuevo.Enabled = nuevo;
            BnAnular.Enabled = anular;
            BnBuscar.Enabled = buscar;
            BnGuardar.Enabled = guardar;
            BnCancelar.Enabled = cancelar;
        }

        public void GroupBox_Limpiar()
        {
            CmbTipoDocumentoIdentidad.SelectedIndex = -1;
            TbNumeroDocumentoIdentidad.Clear();
            TbCliente.Clear();
            CbTipoInspeccion.SelectedIndex = -1;
            TbVehiculo.Clear();
            CbTaller.SelectedIndex = -1;
            DtpFecha.Value = DateTime.Now.Date;
            CbHora.SelectedIndex = -1;
            CbInspector.SelectedIndex = -1;
            CbFormaPago.SelectedIndex = -1;
            CbTipoComprobante.SelectedIndex = -1;
        }

        public void SetAccion(FormAccion accion)
        {
            GroupBox_Limpiar();
            this.Accion = accion;
            switch(this.Accion)
            {
                case FormAccion.ninguno:
                    Botones_Enabled(true, false, true, false, false);
                    GbCliente.Enabled = false;
                    GbProgramacion.Enabled = false;
                    GbLista.Enabled = false;
                    GbPago.Enabled = false;
                    break;
                case FormAccion.nuevo:
                    Botones_Enabled(false, false, false, true, true);
                    GbCliente.Enabled = true;
                    GbProgramacion.Enabled = true;
                    GbLista.Enabled = true;
                    GbPago.Enabled = true;
                    break;
            }
        }

        private void BnNuevo_Click(object sender, EventArgs e)
        {
            SetAccion(FormAccion.nuevo);
        }

        private void BnAnular_Click(object sender, EventArgs e)
        {

        }

        private void BnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void BnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void BnCancelar_Click(object sender, EventArgs e)
        {
            SetAccion(FormAccion.ninguno);
        }

        private void BnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbTipoInspeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tipoInspeccion = CbTipoInspeccion.Text;
            DgvTarea.Rows.Clear();
            var total = 0.00d;
            if (tipoInspeccion == "INSPECCIÓN CABINA")
            {
                DgvTarea.Rows.Add("REVISIÓN DE MOTOR", "S/ 150.00");
                DgvTarea.Rows.Add("REVISIÓN DE RADIADOR", "S/ 50.00");
                DgvTarea.Rows.Add("REVISIÓN DE ARBOL DE LEVAS", "S/ 100.00");
                DgvTarea.Rows.Add("REVISIÓN DE SISTEMA ELÉCTRICO", "S/ 75.00");
                total = 375.00;
            }
            else if (tipoInspeccion == "INSPECCIÓN TRACTO")
            {
                DgvTarea.Rows.Add("REVISIÓN DE TRANSMISIÓN", "S/ 100.00");
                DgvTarea.Rows.Add("REVISIÓN DE CHASIS", "S/ 75.00");
                DgvTarea.Rows.Add("REVISIÓN DE EJES", "S/ 150.00");
                total = 225.00;
            }
            else if (tipoInspeccion == "INSPECCIÓN CABINA Y TRACTO")
            {
                DgvTarea.Rows.Add("REVISIÓN DE MOTOR", "S/ 150.00");
                DgvTarea.Rows.Add("REVISIÓN DE RADIADOR", "S/ 50.00");
                DgvTarea.Rows.Add("REVISIÓN DE ARBOL DE LEVAS", "S/ 100.00");
                DgvTarea.Rows.Add("REVISIÓN DE SISTEMA ELÉCTRICO", "S/ 75.00");
                DgvTarea.Rows.Add("REVISIÓN DE TRANSMISIÓN", "S/ 100.00");
                DgvTarea.Rows.Add("REVISIÓN DE CHASIS", "S/ 75.00");
                DgvTarea.Rows.Add("REVISIÓN DE EJES", "S/ 150.00");
                total = 600.00;
            }
            TbTotal.Text = total.ToString("S/ #0.00");
        }

        private void CmbTipoDocumentoIdentidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tipoDocumentoIdentidad = (TipoDocumentoIdentidad)CmbTipoDocumentoIdentidad.SelectedItem;
            if (tipoDocumentoIdentidad == null)
            {
                TbNumeroDocumentoIdentidad.MaxLength = 0;
                TbNumeroDocumentoIdentidad.TipoCaracteres = CustomTextBox.TipoInput.Todo;
            }
            else
            {
                TbNumeroDocumentoIdentidad.MaxLength = tipoDocumentoIdentidad.LongitudMaxima;
                TbNumeroDocumentoIdentidad.TipoCaracteres = tipoDocumentoIdentidad.Alfanumerico ? CustomTextBox.TipoInput.NumerosYLetras : CustomTextBox.TipoInput.SoloNumeros;
            }
            TbNumeroDocumentoIdentidad.Clear();
        }

        private async void BnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                var datosFaltantes = "";
                var tipoDocumentoIdentidad = (TipoDocumentoIdentidad)CmbTipoDocumentoIdentidad.SelectedItem;

                if (TbNumeroDocumentoIdentidad.Text.Trim() == "") datosFaltantes += "\n\r - Nº de documento de identidad";

                if (!string.IsNullOrEmpty(datosFaltantes))
                {
                    MessageBox.Show(this, "Olvidó ingresar los siguientes datos: " + datosFaltantes, "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var numeroDocumentoIdentidad = TbNumeroDocumentoIdentidad.Text.Trim();
                if (tipoDocumentoIdentidad.LongitudMinima > numeroDocumentoIdentidad.Length)
                {
                    string mensaje = $"El tipo de documento de identidad \"{tipoDocumentoIdentidad.Nombre}\" debe tener como mínimo {tipoDocumentoIdentidad.LongitudMinima} dígitos";
                    MessageBox.Show(this, mensaje, "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                BnBuscarCliente.Enabled = false;
                this.Cursor = Cursors.WaitCursor;

                var cliente = await LogCliente.Instancia.ClienteBuscarPorDocumentoIdentidad(tipoDocumentoIdentidad.IdTipoDocumentoIdentidad, numeroDocumentoIdentidad);

                this.Cursor = Cursors.Default;
                BnBuscarCliente.Enabled = true;

                if (cliente == null)
                {
                    string msg = $"No se encontró el cliente con \"{tipoDocumentoIdentidad.Nombre}: {numeroDocumentoIdentidad}\" ¿Desea agregarlo?";
                    if (MessageBox.Show(this, msg, "Un momento por favor", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        cliente = ClienteAgregar(tipoDocumentoIdentidad.IdTipoDocumentoIdentidad, numeroDocumentoIdentidad);
                    }
                    else
                    {
                        TbNumeroDocumentoIdentidad.Focus();
                        return;
                    }
                }

                if (cliente != null)
                {
                    TbCliente.Tag = cliente;
                    TbCliente.Text = cliente.RazonSocialOrApellidosYNombres;
                }
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(this, ex.Message, "Se produjo un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BnBuscarCliente.Enabled = true;
            }
        }

        private Cliente ClienteAgregar(short idTipoDocumentoIdentidad, string numeroDocumentoIdentidad)
        {
            var cliente = (Cliente)null;
            var frm = new FrmClienteModal(idTipoDocumentoIdentidad, numeroDocumentoIdentidad);
            frm.WindowState = FormWindowState.Normal;
            frm.StartPosition = FormStartPosition.CenterScreen;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                cliente = frm.GetCurrentCliente;
            }
            frm.Dispose();

            return cliente;
        }

        private void TbNumeroDocumentoIdentidad_TextChanged(object sender, EventArgs e)
        {
            TbCliente.Tag = null;
            TbCliente.Clear();
        }
    }
}
