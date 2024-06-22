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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private Usuario _currentUsuario;

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            this.Visible = false;

            var frmLogin = new FrmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
                this._currentUsuario = frmLogin.GetUsuarioActual;
                frmLogin.Dispose();
            }
            else
            {
                frmLogin.Dispose();
                this.Close();
            }
        }

        private void mnuTipoDocumentoIdentidad_Click(object sender, EventArgs e)
        {
            var form = new FrmTipoDocumentoIdentidad((ToolStripMenuItem)sender);
            form.MdiParent = this;
            form.Show();
        }

        private void mnuCliente_Click(object sender, EventArgs e)
        {
            var form = new FrmCliente((ToolStripMenuItem)sender);
            form.MdiParent = this;
            form.Show();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuProgramarInspeccion_Click(object sender, EventArgs e)
        {
            var form = new FrmProgramacionInspeccion();
            form.MdiParent = this;
            form.Show();
        }

        private void mnuConsultaHorarioDisponible_Click(object sender, EventArgs e)
        {
            var form = new FrmConsultaHorarioDisponiblePorTaller();
            form.MdiParent = this;
            form.Show();
        }

        private void mnuConsultaProgramacionInspeccion_Click(object sender, EventArgs e)
        {
            var form = new FrmConsultaInspeccionProgramaPorTaller();
            form.MdiParent = this;
            form.Show();
        }

        private void mnuConsultaInspeccion_Click(object sender, EventArgs e)
        {
            var form = new FrmConsultaInspeccionRealizadaPorTaller();
            form.MdiParent = this;
            form.Show();
        }
    }
}
