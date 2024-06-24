using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;



namespace CapaPresentacion
{
    public partial class FrmTipoInspeccion : Form
    {
        public FrmTipoInspeccion()
        {
            InitializeComponent();
        }
        private void LimpiarVariables()
        {
           
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtId.Text = "";
            txtEstado.Text = "";
            dgvDatos.ClearSelection();
        }

        public void ListarTipoInspeccion()
        {
            dgvDatos.DataSource = LogTipoInspeccion.Instancia.ListarTipoInspeccion();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                EntTipoInspeccion c = new EntTipoInspeccion();

                c.IdTipoInspeccion = int.Parse(txtId.Text.Trim());
                c.Estado = txtEstado.Text.ToString();
                c.TipoInspeccion = txtNombre.Text.Trim();
                c.Descripcion = txtDescripcion.Text.Trim();
                LogTipoInspeccion.Instancia.InsertarTipoInspeccion(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            ListarTipoInspeccion();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnDeshabilitar.Enabled = true;
         
            LimpiarVariables();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                EntTipoInspeccion c = new EntTipoInspeccion();
                c.TipoInspeccion = txtNombre.Text.Trim();
                c.Descripcion = txtDescripcion.Text.Trim();
                c.IdTipoInspeccion = int.Parse(nn.Text.Trim());
                c.Estado = txtEstado.Text.ToString();
                LogTipoInspeccion.Instancia.EditarTipoInspeccion(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            ListarTipoInspeccion();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                EntTipoInspeccion c = new EntTipoInspeccion();

                c.IdTipoInspeccion = int.Parse(txtId.Text.Trim());
                txtEstado.Text = "Inhabilitado";
                c.Estado = txtEstado.Text;
                LogTipoInspeccion.Instancia.InhabilitaTipoInspeccion(c);

                LogTipoInspeccion.Instancia.InhabilitaTipoInspeccion(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();

            ListarTipoInspeccion();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            ListarTipoInspeccion();
        }
    }
    
}
