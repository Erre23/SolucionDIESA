using CapaEntidad;
using CapaEntidad.Custom;
using CapaLogica;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmProgramacionInspeccionBuscarDisponibilidad : Form
    {
        private TallerHorarioDisponible _TallerHorarioDisponible;
        public TallerHorarioDisponible GetTallerHorarioDisponibleSeleccionado { get { return _TallerHorarioDisponible; } }

        public FrmProgramacionInspeccionBuscarDisponibilidad()
        {
            InitializeComponent();
        }

        private async void FrmProgramacionInspeccionBuscarDisponibilidad_Load(object sender, EventArgs e)
        {
            try
            {
                DtpFecha.MinDate = DateTime.Now.Date;
                var talleres = await LogTaller.Instancia.TallerListarActivos();
                CbTaller.Items.Clear();
                CbTaller.DisplayMember = "Nombre";
                CbTaller.Items.Add(new Taller { IdTaller = 0, Nombre = "TODOS" });
                foreach (var taller in talleres)
                {
                    CbTaller.Items.Add(taller);
                }
                CbTaller.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Error: {ex.Message}", "Se ha producido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvHorario_Agregar(TallerHorarioDisponible tallerHorarioDisponible)
        {
            var index = DgvHorario.Rows.Add(
                tallerHorarioDisponible.Taller.Nombre, 
                tallerHorarioDisponible.Fecha.ToString("dddd dd/MM/yyyy"),
                tallerHorarioDisponible.Hora.ToString("hh:mm tt")
            );
            DgvHorario.Rows[index].Tag = tallerHorarioDisponible;
        }

        private async void BnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                BnBuscar.Enabled = false;
                this.Cursor = Cursors.WaitCursor;
                DgvHorario.Rows.Clear();
                var taller = (Taller)CbTaller.SelectedItem;
                foreach (var tallerHorarioDisponible in await LogTaller.Instancia.TallerBuscarDisponiblesPorFecha(taller.IdTaller, DtpFecha.Value.Date))
                {
                    DgvHorario_Agregar(tallerHorarioDisponible);
                } 
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, $"Error: {ex.Message}", "Se ha producido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                BnBuscar.Enabled = true;
                this.Cursor = Cursors.Default;
            }
        }

        private void BnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvHorario.Rows.Count == 0 || DgvHorario.CurrentRow == null || DgvHorario.CurrentRow.Tag == null)
                {
                    MessageBox.Show(this, "Olvidó seleccionar un horario disponible", "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                _TallerHorarioDisponible = DgvHorario.CurrentRow.Tag as TallerHorarioDisponible;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Error: {ex.Message}", "Se ha producido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
