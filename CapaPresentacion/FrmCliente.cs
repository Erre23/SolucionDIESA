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
    public partial class FrmCliente : Form
    {

        public FrmCliente()
        {
            InitializeComponent();
            CbTipoDocumentoIdentidad.Items.Add("DNI");
            CbTipoDocumentoIdentidad.Items.Add("Carnet de Extranjería");
            CbTipoDocumentoIdentidad.Items.Add("RUC");
            
            BnFiltrar.Location = BnCancelar.Location;
            SetAccion(FormAccion.ninguno);
            DgvCliente_Agregar("DNI", "78787878", "JORGE FOSATTI", "999999999", "jorgefosatti@gmail.com");
            DgvCliente_Agregar("RUC", "20525567240", "SERVICIOS GENERALES", "888888888", "administración@diesa.com.pe");
        }

        private void DgvCliente_Agregar(string tipoDoc, string numDoc, string nombreCompleto, string telefono, string email)
        {
            DgvCliente.Rows.Add(tipoDoc, numDoc, nombreCompleto, telefono, email);
        }

        private FormAccion Accion;

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
            CbTipoDocumentoIdentidad.SelectedIndex = -1;
            TbNumeroDocumentoIdentidad.Clear();
            TbNombres.Clear();
            TbApellido1.Clear();
            TbApellido2.Clear();
            TbRazonSocial.Clear();
            TbTelefono.Clear();
            TbEmail.Clear();
        }

        public void SetAccion(FormAccion accion)
        {
            GBDatos_Limpiar();
            this.Accion = accion;
            switch(this.Accion)
            {
                case FormAccion.ninguno:
                    LbOpcion.Text = "";
                    Botones_Enabled(true, true, true, true);
                    Botones_Visible(false, false, false);
                    GbDatos.Enabled = false;
                    break;
                case FormAccion.nuevo:
                    LbOpcion.Text = "OPCIÓN : NUEVO";
                    Botones_Enabled(false, false, false, false);
                    Botones_Visible(true, true, false);
                    GbDatos.Enabled = true;
                    break;
                case FormAccion.editar:
                    LbOpcion.Text = "OPCIÓN : EDITAR";
                    Botones_Enabled(false, false, false, false);
                    Botones_Visible(true, true, false);
                    GbDatos.Enabled = true;
                    break;
                case FormAccion.buscar:
                    LbOpcion.Text = "OPCIÓN : BUSCAR";
                    Botones_Enabled(true, true, true, false);
                    Botones_Visible(false, false, true);
                    GbDatos.Enabled = true;
                    break;
            }
        }

        private void BnNuevo_Click(object sender, EventArgs e)
        {
            SetAccion(FormAccion.nuevo);
        }

        private void BnEditar_Click(object sender, EventArgs e)
        {
            SetAccion(FormAccion.editar);
        }

        private void BnDeshabilitar_Click(object sender, EventArgs e)
        {

        }

        private void BnBuscar_Click(object sender, EventArgs e)
        {
            SetAccion(FormAccion.buscar);
        }

        private void BnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void BnCancelar_Click(object sender, EventArgs e)
        {
            SetAccion(FormAccion.ninguno);
        }

        private void BnFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void BnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
