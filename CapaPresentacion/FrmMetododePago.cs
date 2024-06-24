using CapaLogica;
using CapaEntidad;
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
    public partial class FrmMetododePago : Form
    {
        string Rbtn_CD;
        public FrmMetododePago()
        {
            InitializeComponent();
            btn_AgregarMP.Enabled = false;
            btn_ModificarMP.Enabled = false;
            btn_DeshabilitarMP.Enabled = false;
            btn_NuevoMP.Enabled = false;
            ListarInspector();
            Dgv_MetodoPago.ClearSelection();
            GroupBox_MP.Enabled=false;
        }
        public void ListarInspector()
        {
            Dgv_MetodoPago.DataSource = LogMetodoPago.Instancia.ListarMetodoPago();
        }
        private void Limpiar()
        {
            txt_IdMPago.Text = "";
            txt_NombreMP.Text = "";
            txt_Descripcion.Text = "";
            cmb_TipoP.Text = "";
            cmb_TipoP.SelectedIndex = -1;
            Rbtn_Credito.Checked = false;
            Rbtn_Debito.Checked = false;
            cmb_TipoTarjeta.Text = "";
            cmb_TipoTarjeta.SelectedIndex = -1;
            cmb_TMoneda.Text = "";
            cmb_TMoneda.SelectedIndex = -1;
            txt_TComision.Text = "";
            cmb_EstadoM.Text = "";
            Dgv_MetodoPago.ClearSelection();
        }
        private void BTN_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmMetododePago_Load(object sender, EventArgs e)
        {

        }
        private void btn_Editar_Click(object sender, EventArgs e)
        {

            txt_IdMPago.Enabled = false;
            btn_NuevoMP.Enabled = true;
            btn_ModificarMP.Enabled = true;
            btn_DeshabilitarMP.Enabled = true;
            GroupBox_MP.Enabled = true;
        }

        private void btn_NuevoMP_Click(object sender, EventArgs e)
        {
            GroupBox_MP.Enabled = true;
            btn_AgregarMP.Enabled = true;
            btn_ModificarMP.Enabled = false;
            txt_IdMPago.Enabled = false;
            btn_DeshabilitarMP.Enabled = false;
            Limpiar();
        }
        private void btn_AgregarMP_Click(object sender, EventArgs e)
        {
            
            if (Rbtn_Debito.Checked == true)
            {
                Rbtn_CD = Rbtn_Debito.Text;
            }
            else
            {
                Rbtn_CD = Rbtn_Credito.Text;
            }
            try
            {
                EntMetodoPago c = new EntMetodoPago();

                c.NombreMetodoP = txt_NombreMP.Text.Trim();
                c.Descripcion = txt_Descripcion.Text.Trim();
                c.TipoPago = cmb_TipoP.Text.Trim();
                c.Credito_Debito= Rbtn_CD.Trim();
                c.TipoTarjeta = cmb_TipoTarjeta.Text.Trim();
                c.TipoMoneda = cmb_TMoneda.Text.Trim();
                c.TasaComision = Convert.ToInt32(txt_TComision.Text.Trim());
                c.Estado = cmb_EstadoM.Text.Trim();
               
                LogMetodoPago.Instancia.InsertarMetodoPago(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            
            GroupBox_MP.Enabled = false;
            ListarInspector();
            Limpiar();
        }

       

        private void btn_ModificarMP_Click(object sender, EventArgs e)
        {
            if (Rbtn_Debito.Checked == true)
            {
                Rbtn_CD = Rbtn_Debito.Text;
            }
            else
            {
                Rbtn_CD = Rbtn_Credito.Text;
            }
            try
            {
                EntMetodoPago c = new EntMetodoPago();
                c.IdMetodoPago = int.Parse(txt_IdMPago.Text.Trim());
                c.NombreMetodoP = txt_NombreMP.Text.Trim();
                c.Descripcion = txt_Descripcion.Text.Trim();
                c.TipoPago = cmb_TipoP.Text.Trim();
                c.Credito_Debito = Rbtn_CD.Trim();
                c.TipoTarjeta = cmb_TipoTarjeta.Text.Trim();
                c.TipoMoneda = cmb_TMoneda.Text.Trim();
                c.TasaComision = Convert.ToInt32(txt_TComision.Text.Trim());
                c.Estado = cmb_EstadoM.Text.Trim();

                LogMetodoPago.Instancia.EditarMetodoPago(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            Limpiar();
            GroupBox_MP.Enabled = false;
            ListarInspector();
        }

        private void Dgv_MetodoPago_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = Dgv_MetodoPago.Rows[e.RowIndex];
            txt_IdMPago.Text = filaActual.Cells[0].Value.ToString();
            txt_NombreMP.Text = filaActual.Cells[1].Value.ToString();
            txt_Descripcion.Text = filaActual.Cells[2].Value.ToString();
            cmb_TipoP.Text = filaActual.Cells[3].Value.ToString();
            if (filaActual.Cells[4].Value.ToString()=="Credito") {Rbtn_Credito.Checked = true;}
            else {Rbtn_Debito.Checked = true;}
            cmb_TipoTarjeta.Text = filaActual.Cells[5].Value.ToString();
            cmb_TMoneda.Text = filaActual.Cells[6].Value.ToString();
            txt_TComision.Text = filaActual.Cells[7].Value.ToString();
            cmb_EstadoM.Text = filaActual.Cells[8].Value.ToString();
           
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            
            ListarInspector();
            Limpiar();
        }

        private void btn_DeshabilitarMP_Click(object sender, EventArgs e)
        {
            try
            {
                EntMetodoPago c = new EntMetodoPago();

                c.IdMetodoPago= int.Parse(txt_IdMPago.Text.Trim());
                cmb_EstadoM.Text = "Deshabilitado";
                c.Estado = cmb_EstadoM.Text;
                LogMetodoPago.Instancia.DeshabilitarMetodoPago(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            Limpiar();
            GroupBox_MP.Enabled = false;
            ListarInspector();
        }
    }
}
