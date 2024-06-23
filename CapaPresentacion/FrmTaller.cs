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
using CapaPresentacion.Controls;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace CapaPresentacion
{
    public partial class FrmTaller : Form
    {
        ToolStripMenuItem _menu;
        public FrmTaller(ToolStripMenuItem menu)
        {
            _menu = menu;
            _menu.Enabled = false;
            InitializeComponent();
            BnFiltrar.Location = BnCancelar.Location;
            SetAccion(FormAccion.ninguno);
        }

        private async void FrmTaller_Load(object sender, EventArgs e)
        {
            try
            {
                var departamentos = await LogDepartamento.Instancia.DepartamentoBuscarTodos();
                var departamentoDefault = new Departamento { Nombre = "Todos" };
                LLenarComboBox<Departamento>(departamentoDefault, departamentos, CmbDepartamento);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Se produjo un error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void FrmTaller_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((this.Accion == FormAccion.nuevo || this.Accion == FormAccion.editar) && 
                MessageBox.Show(this, "¿Está seguro de cerrar esta ventana? los datos que no han sido guardados se perderán", "Un momento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #region Métodos

        private void DgvTaller_Agregar(Taller Taller)
        {
            var indice = 
                DgvTaller.Rows.Add(
                    Taller.Nombre, 
                    Taller.Direccion,
                    Taller.Distrito.Provincia.Departamento.Nombre,
                    Taller.Distrito.Provincia.Nombre,
                    Taller.Distrito.Nombre,
                    Taller.HoraInicio.ToString("hh tt"),
                    Taller.HoraFin.ToString("hh tt"),
                    Taller.Lunes,
                    Taller.Martes,
                    Taller.Miercoles,
                    Taller.Jueves,
                    Taller.Viernes,
                    Taller.Sabado,
                    Taller.Domingo,
                    Taller.Activo ? "SI" : ""
                );
            DgvTaller.Rows[indice].Tag = Taller;
        }

        private void DgvTaller_Actualizar(Taller Taller)
        {

            DgvTaller.CurrentRow.Tag = Taller;
            DgvTaller.CurrentRow.Cells[0].Value = Taller.Nombre;
            DgvTaller.CurrentRow.Cells[1].Value = Taller.Direccion;
            DgvTaller.CurrentRow.Cells[2].Value = Taller.Distrito.Provincia.Departamento.Nombre;
            DgvTaller.CurrentRow.Cells[3].Value = Taller.Distrito.Provincia.Nombre;
            DgvTaller.CurrentRow.Cells[4].Value = Taller.Distrito.Nombre;
            DgvTaller.CurrentRow.Cells[5].Value = Taller.HoraInicio.ToString("hh tt");
            DgvTaller.CurrentRow.Cells[6].Value = Taller.HoraFin.ToString("hh tt");
            DgvTaller.CurrentRow.Cells[7].Value = Taller.Lunes;
            DgvTaller.CurrentRow.Cells[8].Value = Taller.Martes;
            DgvTaller.CurrentRow.Cells[9].Value = Taller.Miercoles;
            DgvTaller.CurrentRow.Cells[10].Value = Taller.Jueves;
            DgvTaller.CurrentRow.Cells[11].Value = Taller.Viernes;
            DgvTaller.CurrentRow.Cells[12].Value = Taller.Sabado;
            DgvTaller.CurrentRow.Cells[13].Value = Taller.Domingo;
            DgvTaller.CurrentRow.Cells[14].Value = Taller.Activo ? "SI" : "";
        }

        private FormAccion Accion;
        private Taller CurrentTaller;

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
            TbNombre.Clear();
            TbDireccion.Clear();
            CmbDepartamento.SelectedIndex = -1;
            CmbProvincia.SelectedIndex = -1;
            CmbDistrito.SelectedIndex = -1;
            DtpHoraInicio.ResetText();
            DtpHoraFin.ResetText();
            ChkLunes.Checked = false;
            ChkMartes.Checked = false;
            ChkMiercoles.Checked = false;
            ChkJueves.Checked = false;
            ChkViernes.Checked = false;
            ChkSabado.Checked = false;
            ChkDomingo.Checked = false;
        }
        private void GbDatos_MostrarDatos(Taller taller)
        {
            this.CurrentTaller = taller;
            
            TbNombre.Text = taller.Nombre;
            TbDireccion.Text = taller.Direccion;
            for (int indice = 0; indice < CmbDepartamento.Items.Count; indice++)
            {
                if ((CmbDepartamento.Items[indice] as Departamento).IdDepartamento == taller.Distrito.Provincia.IdDepartamento)
                {
                    CmbDepartamento.SelectedIndex = indice;
                    break;
                }
            }
            for (int indice = 0; indice < CmbProvincia.Items.Count; indice++)
            {
                if ((CmbProvincia.Items[indice] as Provincia).IdProvincia == taller.Distrito.IdProvincia)
                {
                    CmbProvincia.SelectedIndex = indice;
                    break;
                }
            }
            for (int indice = 0; indice < CmbDistrito.Items.Count; indice++)
            {
                if ((CmbDistrito.Items[indice] as Distrito).IdDistrito == taller.IdDistrito)
                {
                    CmbDistrito.SelectedIndex = indice;
                    break;
                }
            }
            DtpHoraInicio.Value = taller.HoraInicio;
            DtpHoraFin.Value = taller.HoraFin;
            ChkLunes.Checked = taller.Lunes;
            ChkMartes.Checked = taller.Martes;
            ChkMiercoles.Checked = taller.Miercoles;
            ChkJueves.Checked = taller.Jueves;
            ChkViernes.Checked = taller.Viernes;
            ChkSabado.Checked = taller.Sabado;
            ChkDomingo.Checked = taller.Domingo;
        }

        public void SetAccion(FormAccion accion)
        {
            GBDatos_Limpiar();
            this.Accion = accion;
            this.CurrentTaller = null;
            switch(this.Accion)
            {
                case FormAccion.ninguno:
                    LbOpcion.Text = "";
                    Botones_Enabled(true, true, true, true);
                    Botones_Visible(false, false, false);
                    GbDatos.Enabled = false;
                    GbLista.Enabled = true;
                    break;
                case FormAccion.nuevo:
                    LbOpcion.Text = "OPCIÓN : NUEVO";
                    CmbDepartamento.SelectedIndex = 0;
                    Botones_Enabled(false, false, false, false);
                    Botones_Visible(true, true, false);
                    GbDatos.Enabled = true;
                    ControlesNoBusqueda_Enabled(true);
                    GbLista.Enabled = false;
                    break;
                case FormAccion.editar:
                    LbOpcion.Text = "OPCIÓN : EDITAR";
                    Botones_Enabled(false, false, false, false);
                    Botones_Visible(true, true, false);
                    GbDatos.Enabled = true;
                    ControlesNoBusqueda_Enabled(true);
                    GbLista.Enabled = false;
                    break;
                case FormAccion.buscar:
                    LbOpcion.Text = "OPCIÓN : BUSCAR";
                    Botones_Enabled(true, true, true, false);
                    Botones_Visible(false, false, true);
                    GbDatos.Enabled = true;
                    ControlesNoBusqueda_Enabled(false);
                    GbLista.Enabled = true;
                    break;
            }
        }

        private void ControlesNoBusqueda_Enabled(bool enabled)
        {
            TbDireccion.Enabled = enabled;
            DtpHoraInicio.Enabled = enabled;
            DtpHoraFin.Enabled = enabled;
            ChkLunes.Enabled = enabled;
            ChkMartes.Enabled = enabled;
            ChkMiercoles.Enabled = enabled;
            ChkJueves.Enabled = enabled;
            ChkViernes.Enabled = enabled;
            ChkSabado.Enabled = enabled;
            ChkDomingo.Enabled = enabled;
        }

        private void LLenarComboBox<T>(T defaultValue, List<T> lista, ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.DisplayMember = "Nombre";
            comboBox.Items.Add(defaultValue);
            if (lista == null) lista = new List<T>();
            foreach (var item in lista )
            {
                comboBox.Items.Add(item);
            }
        }

        #endregion Métodos

        private void CmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            var departamento = (Departamento)CmbDepartamento.SelectedItem;
            var provinciaDefault = new Provincia { Nombre = "Todos" };
            LLenarComboBox<Provincia>(provinciaDefault, departamento?.Provincias, CmbProvincia);
        }

        private void CmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            var provincia = (Provincia)CmbProvincia.SelectedItem;
            var distritoDefault = new Distrito { Nombre = "Todos" };
            LLenarComboBox<Distrito>(distritoDefault, provincia?.Distritos, CmbDistrito);
        }

        private void BnNuevo_Click(object sender, EventArgs e)
        {
            SetAccion(FormAccion.nuevo);
        }

        private void BnEditar_Click(object sender, EventArgs e)
        {
            var Taller = (Taller)DgvTaller.CurrentRow?.Tag;
            if (Taller == null)
            {
                MessageBox.Show(this, "Olvidó seleccionar un Taller", "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            SetAccion(FormAccion.editar);
            GbDatos_MostrarDatos(Taller);
        }

        private async void BnDeshabilitar_Click(object sender, EventArgs e)
        {
            var Taller = (Taller)DgvTaller.CurrentRow?.Tag;
            if (Taller == null)
            {
                MessageBox.Show(this, "Olvidó seleccionar un Taller", "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string datosTaller = "\n";
            datosTaller += "\n\r - Nombre: " + Taller.Nombre;

            if (MessageBox.Show(this, "¿Está seguro de deshabilitar al Taller?" + datosTaller, "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                BnDeshabilitar.Enabled = false;
                this.Cursor = Cursors.WaitCursor;
                await LogTaller.Instancia.TallerDeshabilitar(Taller.IdTaller);
                Taller.Activo = false;
                DgvTaller_Actualizar(Taller);


                this.Cursor = Cursors.Default;
                MessageBox.Show(this, "El Taller fue deshabilitado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BnDeshabilitar.Enabled = true;

                SetAccion(FormAccion.ninguno);
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(this, ex.Message, "Se produjo un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BnDeshabilitar.Enabled = true;
            }
        }

        private void BnBuscar_Click(object sender, EventArgs e)
        {
            SetAccion(FormAccion.buscar);
        }

        private async void BnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var datosFaltantes = "";

                if (TbNombre.Text.Trim() == "") datosFaltantes += "\n\r - Nombre";
                if (TbDireccion.Text.Trim() == "") datosFaltantes += "\n\r - Dirección";

                var departamento = (Departamento)CmbDepartamento.SelectedItem;
                if (departamento == null || departamento.IdDepartamento == 0) datosFaltantes += "\n\r - Departamento";

                var provincia = (Provincia)CmbProvincia.SelectedItem;
                if (provincia == null || provincia.IdDepartamento == 0) datosFaltantes += "\n\r - Provincia";

                var distrito = (Distrito)CmbDistrito.SelectedItem;
                if (distrito == null || distrito.IdDistrito == 0) datosFaltantes += "\n\r - Distrito";

                if (!string.IsNullOrEmpty(datosFaltantes))
                {
                    MessageBox.Show(this, "Olvidó ingresar los siguientes datos: " + datosFaltantes, "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (DtpHoraInicio.Value.Hour >= DtpHoraFin.Value.Hour)
                {
                    MessageBox.Show(this, "La hora fin debe ser menor que la hora inicio", "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                if (this.Accion == FormAccion.nuevo) this.CurrentTaller = new Taller();
                this.CurrentTaller.Nombre = TbNombre.Text.Trim();
                this.CurrentTaller.Direccion = TbDireccion.Text.Trim();
                this.CurrentTaller.IdDistrito = distrito.IdDistrito;
                this.CurrentTaller.Distrito = distrito;
                this.CurrentTaller.HoraInicio = DtpHoraInicio.Value;
                this.CurrentTaller.HoraFin = DtpHoraFin.Value;
                this.CurrentTaller.Lunes = ChkLunes.Checked;
                this.CurrentTaller.Martes = ChkMartes.Checked;
                this.CurrentTaller.Miercoles = ChkMiercoles.Checked;
                this.CurrentTaller.Jueves = ChkJueves.Checked;
                this.CurrentTaller.Viernes = ChkViernes.Checked;
                this.CurrentTaller.Sabado = ChkSabado.Checked;
                this.CurrentTaller.Domingo = ChkDomingo.Checked;

                if (MessageBox.Show(this, "¿Está seguro guardar los datos?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }


                BnGuardar.Enabled = false;
                this.Cursor = Cursors.WaitCursor;

                if (this.Accion == FormAccion.nuevo)
                {
                    this.CurrentTaller.IdTaller = await LogTaller.Instancia.TallerInsertar(this.CurrentTaller);
                    DgvTaller_Agregar(this.CurrentTaller);
                }
                else
                {
                    await LogTaller.Instancia.TallerActualizar(this.CurrentTaller);
                    DgvTaller_Actualizar(this.CurrentTaller);
                }

                
                this.Cursor = Cursors.Default;
                MessageBox.Show(this, "Los datos fueron guardados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BnGuardar.Enabled = true;

                SetAccion(FormAccion.ninguno);
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

        private async void BnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                DgvTaller.Rows.Clear();
                BnFiltrar.Enabled = false;
                this.Cursor = Cursors.WaitCursor;

                var departamento = (Departamento)CmbDepartamento.SelectedItem;
                var provincia = (Provincia)CmbProvincia.SelectedItem;
                var distrito = (Distrito)CmbDistrito.SelectedItem;
                var listaTallers = await LogTaller.Instancia.TallerBusquedaGeneral(
                    TbNombre.Text.Trim(),
                    departamento?.IdDepartamento,
                    provincia?.IdProvincia,
                    distrito?.IdDistrito
                );

                foreach (var Taller in listaTallers)
                {
                    DgvTaller_Agregar(Taller);
                }

                BnFiltrar.Enabled = true;
                this.Cursor = Cursors.Default;

                if (listaTallers.Count() == 0)
                {
                    MessageBox.Show(this, "No se encontraron resultados con los datos de búsqueda ingresado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(this, ex.Message, "Se produjo un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BnFiltrar.Enabled = true;
            }
        }

        private void BnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTaller_FormClosed(object sender, FormClosedEventArgs e)
        {
            this._menu.Enabled = true;
        }
    }
}
