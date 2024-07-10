using CapaEntidad;
using CapaEntidad.Custom;
using CapaLogica;
using CapaPresentacion.Controls;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmProgramacionInspeccion : Form
    {
        ToolStripMenuItem _menu;
        private ProgramacionInspeccion CurrentProgramacionInspeccion;
        public FrmProgramacionInspeccion(ToolStripMenuItem menu)
        {
            _menu = menu;
            _menu.Enabled = false;
            InitializeComponent();
            SetAccion(FormAccion.ninguno);
        }

        private async void FrmProgramacionInspeccion_Load(object sender, EventArgs e)
        {
            try
            {
                CbTaller.DisplayMember = "Nombre";
                CbHora.FormatString = "hh:mm tt";
                CbInspector.DisplayMember = "ApellidosYNombres";

                CmbTipoDocumentoIdentidad.Items.Clear();
                CmbTipoDocumentoIdentidad.DisplayMember = "Nombre";
                var tiposDocumentoIdentidad = await LogTipoDocumentoIdentidad.Instancia.TipoDocumentoIdentidadListarActivos();
                foreach (var item in tiposDocumentoIdentidad)
                {
                    CmbTipoDocumentoIdentidad.Items.Add(item);
                }

                if (CmbTipoDocumentoIdentidad.Items.Count > 0) CmbTipoDocumentoIdentidad.SelectedIndex = 0;

                CbTipoInspeccion.Items.Clear();
                CbTipoInspeccion.DisplayMember = "Nombre";
                var tiposInspeccion = await LogTipoInspeccion.Instancia.TipoInspeccionListarActivos();
                foreach (var item in tiposInspeccion)
                {
                    CbTipoInspeccion.Items.Add(item);
                }
                CbTipoInspeccion.SelectedIndex = -1;

                CbMetodoPago.Items.Clear();
                CbMetodoPago.DisplayMember = "Nombre";
                var metodosPago = await LogMetodoPago.Instancia.MetodoPagoListarActivos();
                foreach (var item in metodosPago)
                {
                    CbMetodoPago.Items.Add(item);
                }
                CbMetodoPago.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Se produjo un error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                this.Close();
            }
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
            TbNumeroProgramacion.Clear();
            TbRegistroFechaHora.Clear();
            TbAnulado.Clear();
            CmbTipoDocumentoIdentidad.SelectedIndex = -1;
            TbNumeroDocumentoIdentidad.Clear();
            TbCliente.Clear();
            CbTipoInspeccion.SelectedIndex = -1;
            TbVehiculo.Clear();
            CbTaller.SelectedIndex = -1;
            DtpFecha.Value = DateTime.Now.Date;
            CbHora.SelectedIndex = -1;
            CbInspector.SelectedIndex = -1;
            CbMetodoPago.SelectedIndex = -1;
        }

        public void SetAccion(FormAccion accion)
        {
            this.Accion = accion;
            switch(this.Accion)
            {
                case FormAccion.ninguno:
                    Botones_Enabled(true, false, true, false, false);
                    GbCliente.Enabled = false;
                    GbProgramacion.Enabled = false;
                    GbPago.Enabled = false;
                    break;
                case FormAccion.nuevo:
                    GroupBox_Limpiar();
                    Botones_Enabled(false, false, false, true, true);
                    GbCliente.Enabled = true;
                    GbProgramacion.Enabled = true;
                    GbPago.Enabled = true;
                    break;
            }
        }

        private void BnNuevo_Click(object sender, EventArgs e)
        {
            SetAccion(FormAccion.nuevo);
        }

        private async void BnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.CurrentProgramacionInspeccion == null)
                {
                    MessageBox.Show(this, "Olvidó ingresar seleccionar una programación ", "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.CurrentProgramacionInspeccion.Anulado)
                {
                    MessageBox.Show(this, "La programación ya ha sido anulada en otro momento", "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show(this, "¿Está seguro de anular la programación de inspección?", "Un momento por favor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                await LogProgramacionInspeccion.Instancia.ProgramacionInspeccionAnular(this.CurrentProgramacionInspeccion.IdProgramacionInspeccion);
                this.CurrentProgramacionInspeccion.Anulado = true;
                TbAnulado.Text = this.CurrentProgramacionInspeccion.Anulado ? "SI" : "";

                MessageBox.Show(this, "La programación se anuló correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Botones_Enabled(true, false, true, false, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Se produjo un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                var frm = new FrmProgramacionInspeccionBuscarPorNumero();
                frm.WindowState = FormWindowState.Normal;
                frm.StartPosition = FormStartPosition.CenterScreen;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    this.CurrentProgramacionInspeccion = frm.GetProgramacionInspeccionSeleccionado;
                }
                frm.Dispose();

                TbNumeroProgramacion.Text = this.CurrentProgramacionInspeccion.IdProgramacionInspeccion.ToString();
                TbRegistroFechaHora.Text = this.CurrentProgramacionInspeccion.FechaHoraRegistro.ToString("dd/MM/yyyy hh:mm:ss tt");
                TbAnulado.Text = this.CurrentProgramacionInspeccion.Anulado ? "SI" : "";
                for (int indice = 0; indice < CmbTipoDocumentoIdentidad.Items.Count; indice++)
                {
                    if ((CmbTipoDocumentoIdentidad.Items[indice] as TipoDocumentoIdentidad).IdTipoDocumentoIdentidad == this.CurrentProgramacionInspeccion.Cliente.IdTipoDocumentoIdentidad)
                    {
                        CmbTipoDocumentoIdentidad.SelectedIndex = indice;
                        break;
                    }
                }
                TbNumeroDocumentoIdentidad.Text = this.CurrentProgramacionInspeccion.Cliente.NumeroDocumentoIdentidad;
                TbCliente.Text = this.CurrentProgramacionInspeccion.Cliente.RazonSocialOrApellidosYNombres;
                for (int indice = 0; indice < CbTipoInspeccion.Items.Count; indice++)
                {
                    if ((CbTipoInspeccion.Items[indice] as TipoInspeccion).IdTipoInspeccion == this.CurrentProgramacionInspeccion.IdTipoInspeccion)
                    {
                        CbTipoInspeccion.SelectedIndex = indice;
                        break;
                    }
                }
                TbVehiculo.Text = this.CurrentProgramacionInspeccion.Vehiculo;
                //CbTipoInspeccion.Items.Clear();
                //CbTipoInspeccion.Items.Add(this.CurrentProgramacionInspeccion.TipoInspeccion);
                //CbTipoInspeccion.SelectedIndex = 0;

                CbTaller.Items.Clear();
                CbTaller.Items.Add(this.CurrentProgramacionInspeccion.Taller);
                CbTaller.SelectedIndex = 0;

                DtpFecha.Value = this.CurrentProgramacionInspeccion.InspeccionFecha.Date;
                DtpFecha.MinDate = this.CurrentProgramacionInspeccion.InspeccionFecha.Date;
                DtpFecha.MaxDate = this.CurrentProgramacionInspeccion.InspeccionFecha.Date;

                CbHora.Items.Clear();
                CbHora.Items.Add(this.CurrentProgramacionInspeccion.InspeccionHora);
                CbHora.SelectedIndex = 0;

                CbInspector.Items.Clear();
                CbInspector.Items.Add(this.CurrentProgramacionInspeccion.Inspector);
                CbInspector.SelectedIndex = 0;

                for (int indice = 0; indice < CbMetodoPago.Items.Count; indice++)
                {
                    if ((CbMetodoPago.Items[indice] as MetodoPago).IdMetodoPago == this.CurrentProgramacionInspeccion.IdMetodoPago)
                    {
                        CbMetodoPago.SelectedIndex = indice;
                        break;
                    }
                }

                TbTotal.Text = this.CurrentProgramacionInspeccion.Total.ToString("S/ #0.00");

                Botones_Enabled(true, !this.CurrentProgramacionInspeccion.Anulado, true, false, false);

            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Se produjo un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var datosFaltantes = "";

                var cliente = (Cliente)TbCliente.Tag;
                if (cliente == null) datosFaltantes += "\n\r - Cliente";

                var tipoInspeccion = (TipoInspeccion)CbTipoInspeccion.SelectedItem;
                if (tipoInspeccion == null) datosFaltantes += "\n\r - Tipo de Inspección";

                if (string.IsNullOrEmpty(TbVehiculo.Text.Trim())) datosFaltantes += "\n\r - Vehículo";

                var taller = (Taller)CbTaller.SelectedItem;
                if (taller == null) datosFaltantes += "\n\r - Taller";

                var inspector = (Inspector)CbInspector.SelectedItem;
                if (inspector == null) datosFaltantes += "\n\r - Inspector";

                var metodoPago = (MetodoPago)CbMetodoPago.SelectedItem;
                if (metodoPago == null) datosFaltantes += "\n\r - Método de Pago";

                if (!string.IsNullOrEmpty(datosFaltantes))
                {
                    MessageBox.Show(this, "Olvidó ingresar los siguientes datos: " + datosFaltantes, "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                this.CurrentProgramacionInspeccion = new ProgramacionInspeccion();
                this.CurrentProgramacionInspeccion.FechaHoraRegistro = DateTime.Now;
                this.CurrentProgramacionInspeccion.IdCliente = cliente.IdCliente;
                this.CurrentProgramacionInspeccion.Cliente = cliente;
                this.CurrentProgramacionInspeccion.IdTipoInspeccion = tipoInspeccion.IdTipoInspeccion;
                this.CurrentProgramacionInspeccion.TipoInspeccion = tipoInspeccion;
                this.CurrentProgramacionInspeccion.Vehiculo = TbVehiculo.Text.Trim().ToUpper();
                this.CurrentProgramacionInspeccion.IdTaller = taller.IdTaller;
                this.CurrentProgramacionInspeccion.Taller = taller;
                this.CurrentProgramacionInspeccion.InspeccionFecha = DtpFecha.Value.Date;
                this.CurrentProgramacionInspeccion.InspeccionHora = (DateTime)CbHora.SelectedItem;
                this.CurrentProgramacionInspeccion.IdInspector = inspector.IdInspector;
                this.CurrentProgramacionInspeccion.Inspector = inspector;
                this.CurrentProgramacionInspeccion.IdMetodoPago = metodoPago.IdMetodoPago;
                this.CurrentProgramacionInspeccion.MetodoPago = metodoPago;
                this.CurrentProgramacionInspeccion.Total = tipoInspeccion.Precio;

                if (MessageBox.Show(this, "¿Está seguro guardar los datos?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }


                BnGuardar.Enabled = false;
                this.Cursor = Cursors.WaitCursor;
               
                this.CurrentProgramacionInspeccion.IdProgramacionInspeccion = await LogProgramacionInspeccion.Instancia.ProgramacionInspeccionInsertar(this.CurrentProgramacionInspeccion);
                TbNumeroProgramacion.Text = this.CurrentProgramacionInspeccion.IdProgramacionInspeccion.ToString();
                TbRegistroFechaHora.Text = this.CurrentProgramacionInspeccion.FechaHoraRegistro.ToString("dd/MM/yyyy hh:mm:ss tt");

                this.Cursor = Cursors.Default;
                var msg = $"Los datos fueron guardados\n\rSe generó la programación Nº {this.CurrentProgramacionInspeccion.IdProgramacionInspeccion}";
                MessageBox.Show(this, msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BnGuardar.Enabled = true;

                SetAccion(FormAccion.ninguno);
                Botones_Enabled(true, true, true, false, false);
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(this, ex.Message, "Se produjo un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BnGuardar.Enabled = true;
            }
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
            var tipoInspeccion = (TipoInspeccion)CbTipoInspeccion.SelectedItem;
            if (tipoInspeccion != null) TbTotal.Text = tipoInspeccion.Precio.ToString("S/ #0.00");
            else TbTotal.Clear();
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

        private async void BnBuscarDisponibilidad_Click(object sender, EventArgs e)
        {
            var tallerHorarioDisponible = (TallerHorarioDisponible)null;
            var frm = new FrmProgramacionInspeccionBuscarDisponibilidad();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                tallerHorarioDisponible = frm.GetTallerHorarioDisponibleSeleccionado;
            }
            frm.Dispose();

            if (tallerHorarioDisponible != null)
            {
                CbTaller.Items.Clear();
                CbHora.Items.Clear();
                CbInspector.Items.Clear();
                
                CbTaller.Tag = tallerHorarioDisponible;
                CbTaller.Items.Add(tallerHorarioDisponible.Taller);
                CbTaller.SelectedIndex = 0;

                DtpFecha.Value = tallerHorarioDisponible.Fecha.Date;
                DtpFecha.MinDate = tallerHorarioDisponible.Fecha.Date;
                DtpFecha.MaxDate = tallerHorarioDisponible.Fecha.Date;

                CbHora.Items.Add(tallerHorarioDisponible.Hora);
                CbHora.SelectedIndex = 0;

                var inspectores = await LogInspector.Instancia.InspectorBuscarDisponiblesPorFechaHora(tallerHorarioDisponible.Fecha, tallerHorarioDisponible.Hora);
                foreach (var inspector in inspectores)
                {
                    CbInspector.Items.Add(inspector);
                }
            }
        }

        private void FrmProgramacionInspeccion_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void FrmProgramacionInspeccion_FormClosed(object sender, FormClosedEventArgs e)
        {
            this._menu.Enabled = true;
        }
    }
}
