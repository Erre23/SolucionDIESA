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

            //this.Visible = false;

            //var frmLogin = new FrmLogin();
            //if (frmLogin.ShowDialog() == DialogResult.OK)
            //{
            //    this.Visible = true;
            //    var usuarioActual = frmLogin.GetUsuarioActual;
            //}
            //else this.Close();
            //frmLogin.Dispose();
        }

        private void mnuCliente_Click(object sender, EventArgs e)
        {
            var form = new FrmCliente();
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
