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

namespace CapaPresentacion
{
    public partial class Frm_Inspector: Form
    {

        public Frm_Inspector()
        {
            InitializeComponent();

            btn_Agregar.Enabled = false;
            btn_Modificar.Enabled = false;
            btn_Deshabilitar.Enabled = false;
            btn_Nuevo.Enabled = false;
            groupBoxDatos.Enabled = false;
            ListarInspector();
            

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FORM2_Load(object sender, EventArgs e)
        {
            DgvInspector.ClearSelection();
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = true;
            ListarInspector();
                
        }
        public void ListarInspector()
        {
            DgvInspector.DataSource = LogInspector.Instancia.ListarInspector();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = true;
            btn_Agregar.Enabled = true;
            btn_Modificar.Enabled = false;
            txt_NumEmpleado.Enabled = false;
            btn_Deshabilitar.Enabled = false;
            LimpiarVariables();

        }
        private void LimpiarVariables()
        {
            cmb_Estado.SelectedIndex =-1;
            cmb_TipoDocumento.SelectedIndex = -1;
            cmb_Estado.Text = "";
            cmb_TipoDocumento.Text = "";
            txt_Buscar.Text = "";
            cmb_TipoDocumento.Text = "";
            txt_NumeroDoc.Text = "";
            txt_NumEmpleado.Text = "";
            txt_NombreInsp.Text = "";
            txt_RazonS.Text = "";
            txt_Apellido1.Text = "";
            txt_Apellido2.Text = "";
            txt_Email.Text = "";
            txt_NumCel.Text = "";
            DgvInspector.ClearSelection();


        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                EntInspector c = new EntInspector();

                c.Estado = cmb_Estado.Text.ToString();
                c.TipoDocumento = cmb_TipoDocumento.Text.Trim();
                c.NumeroDocumentoIdentidad = int.Parse(txt_NumeroDoc.Text.Trim());
                c.Nombres = txt_NombreInsp.Text.Trim();
                c.Apellido1 = txt_Apellido1.Text.Trim();
                c.Apellido2 = txt_Apellido2.Text.Trim();
                c.RazonSocial = txt_RazonS.Text.Trim();
                c.Celular = int.Parse(txt_NumCel.Text.Trim());
                c.Email = txt_Email.Text.Trim();
                LogInspector.Instancia.InsertarInspector(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxDatos.Enabled = false;
            ListarInspector();

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
           try
           {
                EntInspector c = new EntInspector();
                c.NumeroEmpleado = int.Parse(txt_NumEmpleado.Text.Trim());
                c.Estado = cmb_Estado.Text.ToString();
                c.TipoDocumento = cmb_TipoDocumento.Text.Trim();
                c.NumeroDocumentoIdentidad = int.Parse(txt_NumeroDoc.Text.Trim());
                c.Nombres = txt_NombreInsp.Text.Trim();
                c.Apellido1 = txt_Apellido1.Text.Trim();
                c.Apellido2 = txt_Apellido2.Text.Trim();
                c.RazonSocial = txt_RazonS.Text.Trim();
                c.Celular = int.Parse(txt_NumCel.Text.Trim());
                c.Email = txt_Email.Text.Trim();
                LogInspector.Instancia.EditarInspector(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxDatos.Enabled = false;
            ListarInspector();

        }

        private void DgvInspector_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = DgvInspector.Rows[e.RowIndex];
            txt_NumEmpleado.Text = filaActual.Cells[0].Value.ToString();
            cmb_Estado.Text = filaActual.Cells[1].Value.ToString();
            cmb_TipoDocumento.Text = filaActual.Cells[2].Value.ToString();
            txt_NumeroDoc.Text = filaActual.Cells[3].Value.ToString();
            txt_NombreInsp.Text = filaActual.Cells[4].Value.ToString();
            txt_Apellido1.Text = filaActual.Cells[5].Value.ToString();
            txt_Apellido2.Text = filaActual.Cells[6].Value.ToString(); 
            txt_NumCel.Text = filaActual.Cells[7].Value.ToString();
            txt_Email.Text = filaActual.Cells[8].Value.ToString();
            txt_RazonS.Text = filaActual.Cells[9].Value.ToString();
        }

        private void btn_Deshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                EntInspector c = new EntInspector();

                c.NumeroEmpleado = int.Parse(txt_NumEmpleado.Text.Trim());
                cmb_Estado.Text= "Inhabilitado";
                c.Estado= cmb_Estado.Text;
                LogInspector.Instancia.InhabilitaInspector(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxDatos.Enabled = false;
            ListarInspector();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                groupBoxDatos.Enabled = true;
                EntInspector c = new EntInspector();

                c.NumeroEmpleado = int.Parse(txt_Buscar.Text.Trim());
                if (LogInspector.Instancia.BuscaInspector(c).Count == 0)
                {
                    MessageBox.Show("No se encontro el Inspector");

                }
                else
                {
                    DgvInspector.DataSource = LogInspector.Instancia.BuscaInspector(c);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            ListarInspector();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = true;

            txt_NumEmpleado.Enabled = false;
            btn_Nuevo.Enabled = true;
            btn_Modificar.Enabled = true;
            btn_Deshabilitar.Enabled = true;

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
    

