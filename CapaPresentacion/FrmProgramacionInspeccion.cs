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

            CbTipoDocumentoIdentidad.Items.Add("DNI");
            CbTipoDocumentoIdentidad.Items.Add("Carnet de Extranjería");
            CbTipoDocumentoIdentidad.Items.Add("RUC");

            CbTipoInspeccion.Items.Add("INSPECCIÓN CABINA");
            CbTipoInspeccion.Items.Add("INSPECCIÓN TRACTO");
            CbTipoInspeccion.Items.Add("INSPECCIÓN CABINA Y TRACTO");

            CbTaller.Items.Add("TALLER MANUCCI TUPAC AMARU");
            CbTaller.Items.Add("TALLER TOYOTA SERVICIOS");

            CbHora.Items.Add("08:00 am");
            CbHora.Items.Add("09:00 am");
            CbHora.Items.Add("10:00 am");
            CbHora.Items.Add("11:00 am");
            CbHora.Items.Add("12:00 pm");
            CbHora.Items.Add("01:00 pm");
            CbHora.Items.Add("02:00 pm");
            CbHora.Items.Add("03:00 pm");

            CbInspector.Items.Add("Eduardo Rodríguez Escobar");
            CbInspector.Items.Add("Daniel Ibañez Zaldivar");
            CbInspector.Items.Add("Sheyla Diaz Lavado");
            CbInspector.Items.Add("Cesia Riquelme Carrasco");

            CbFormaPago.Items.Add("TRANSFERENCIA");
            CbFormaPago.Items.Add("EFECTIVO");
            CbFormaPago.Items.Add("TARJETA");

            CbTipoComprobante.Items.Add("BOLETA");
            CbTipoComprobante.Items.Add("FACTURA");

            SetAccion(FormAccion.ninguno);
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
            CbTipoDocumentoIdentidad.SelectedIndex = -1;
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
    }
}
