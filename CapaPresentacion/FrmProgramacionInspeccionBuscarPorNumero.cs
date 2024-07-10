using CapaEntidad;
using CapaLogica;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmProgramacionInspeccionBuscarPorNumero : Form
    {
        public FrmProgramacionInspeccionBuscarPorNumero()
        {
            InitializeComponent();
        }

        #region Métodos
        private ProgramacionInspeccion _ProgramacionInspeccion;
        public ProgramacionInspeccion GetProgramacionInspeccionSeleccionado { get { return _ProgramacionInspeccion; } }

        #endregion Métodos

        private async void BnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var datosFaltantes = "";
               
                if (TbNumeroProgramacion.Text.Trim() == "")
                {
                    MessageBox.Show(this, "Olvidó ingresar un dato de búsqueda" + datosFaltantes, "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                BnBuscar.Enabled = false;
                this.Cursor = Cursors.WaitCursor;

                var idProgramacionInspeccion = Convert.ToInt32(TbNumeroProgramacion.Text.Trim());
                this._ProgramacionInspeccion = await LogProgramacionInspeccion.Instancia.ProgramacionInspeccionBuscarPorIdProgramacionInspeccion(idProgramacionInspeccion);


                this.Cursor = Cursors.Default;
                BnBuscar.Enabled = true;

                if (this._ProgramacionInspeccion == null)
                {
                    MessageBox.Show(this, "No se encontró la programación con el número ingresado", "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(this, ex.Message, "Se produjo un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BnBuscar.Enabled = true;
            }
        }

        private void BnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
