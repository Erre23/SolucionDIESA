﻿using CapaEntidad;
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
    public partial class FrmCliente : Form
    {
        ToolStripMenuItem _menu;
        public FrmCliente(ToolStripMenuItem menu)
        {
            _menu = menu;
            _menu.Enabled = false;
            InitializeComponent();
            BnFiltrar.Location = BnCancelar.Location;
            SetAccion(FormAccion.ninguno);
        }

        private async void FrmCliente_Load(object sender, EventArgs e)
        {
            try
            {
                CmbTipoDocumentoIdentidad.Items.Clear();
                CmbTipoDocumentoIdentidad.DisplayMember = "Nombre";
                var tiposDocumentoIdentidad = await LogTipoDocumentoIdentidad.Instancia.TipoDocumentoIdentidaListarActivos();
                foreach (var item in tiposDocumentoIdentidad)
                {
                    CmbTipoDocumentoIdentidad.Items.Add(item);
                }

                if (CmbTipoDocumentoIdentidad.Items.Count > 0) CmbTipoDocumentoIdentidad.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Se produjo un error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void FrmCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((this.Accion == FormAccion.nuevo || this.Accion == FormAccion.editar) && 
                MessageBox.Show(this, "¿Está seguro de cerrar esta ventana? los datos que no han sido guardados se perderán", "Un momento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #region Métodos

        private void DgvCliente_Agregar(Cliente cliente)
        {
            var indice = 
                DgvCliente.Rows.Add(
                    cliente.TipoDocumentoIdentidad.Nombre, 
                    cliente.NumeroDocumentoIdentidad, 
                    cliente.RazonSocialOrApellidosYNombres,
                    cliente.Celular, 
                    cliente.Email, 
                    cliente.Activo ? "SI" : ""
                );
            DgvCliente.Rows[indice].Tag = cliente;
        }

        private void DgvCliente_Actualizar(Cliente cliente)
        {

            DgvCliente.CurrentRow.Tag = cliente;
            DgvCliente.CurrentRow.Cells[0].Value = cliente.TipoDocumentoIdentidad.Nombre;
            DgvCliente.CurrentRow.Cells[1].Value = cliente.NumeroDocumentoIdentidad;
            DgvCliente.CurrentRow.Cells[2].Value = cliente.RazonSocialOrApellidosYNombres;
            DgvCliente.CurrentRow.Cells[3].Value = cliente.Celular;
            DgvCliente.CurrentRow.Cells[4].Value = cliente.Email;
            DgvCliente.CurrentRow.Cells[5].Value = cliente.Activo ? "SI" : "";
        }

        private FormAccion Accion;
        private Cliente CurrentCliente;

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
            CmbTipoDocumentoIdentidad.SelectedIndex = -1;
            TbDocumentoIdentidadNumero.Clear();
            TbNombres.Clear();
            TbApellido1.Clear();
            TbApellido2.Clear();
            TbRazonSocial.Clear();
            TbCelular.Clear();
            TbEmail.Clear();
        }
        private void GbDatos_MostrarDatos(Cliente cliente)
        {
            this.CurrentCliente = cliente;
            for (int indice = 0; indice < CmbTipoDocumentoIdentidad.Items.Count; indice++)
            {
                if((CmbTipoDocumentoIdentidad.Items[indice] as TipoDocumentoIdentidad).IdTipoDocumentoIdentidad == cliente.IdTipoDocumentoIdentidad)
                {
                    CmbTipoDocumentoIdentidad.SelectedIndex = indice;
                    break;
                }
            }
            TbDocumentoIdentidadNumero.Text = cliente.NumeroDocumentoIdentidad;
            if (cliente.TipoDocumentoIdentidad.PersonaJuridica)
            {
                TbRazonSocial.Text = cliente.RazonSocial;
            }
            else
            {
                TbNombres.Text = cliente.Nombres;
                TbApellido1.Text = cliente.Apellido1;
                TbApellido2.Text = cliente.Apellido2;
            }
            TbCelular.Text = cliente.Celular;
            TbEmail.Text = cliente.Email;
        }

        public void SetAccion(FormAccion accion)
        {
            GBDatos_Limpiar();
            this.Accion = accion;
            this.CurrentCliente = null;
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
                    CmbTipoDocumentoIdentidad.SelectedIndex = 0;
                    Botones_Enabled(false, false, false, false);
                    Botones_Visible(true, true, false);
                    GbDatos.Enabled = true;
                    GbLista.Enabled = false;
                    break;
                case FormAccion.editar:
                    LbOpcion.Text = "OPCIÓN : EDITAR";
                    Botones_Enabled(false, false, false, false);
                    Botones_Visible(true, true, false);
                    GbDatos.Enabled = true;
                    GbLista.Enabled = false;
                    break;
                case FormAccion.buscar:
                    LbOpcion.Text = "OPCIÓN : BUSCAR";
                    Botones_Enabled(true, true, true, false);
                    Botones_Visible(false, false, true);
                    GbDatos.Enabled = true;
                    GbLista.Enabled = true;
                    break;
            }
        }

        private void ControlesPersonaJuridica_Mostrar(bool show)
        {
            LbNombres.Visible = !show;
            TbNombres.Visible = !show;
            LbApellido1.Visible = !show;
            TbApellido1.Visible = !show;
            LbApellido2.Visible = !show;
            TbApellido2.Visible = !show;

            LbRazonSocial.Visible = show;
            TbRazonSocial.Visible = show;

            LbCelular.Location = show ? new Point(75, 108) : new Point(75, 143);
            TbCelular.Location = show ? new Point(153, 106) : new Point(153, 140);
            LbEmail.Location = show ? new Point(479, 108) : new Point(479, 143);
            TbEmail.Location = show ? new Point(547, 106) : new Point(547, 140);
        }

        #endregion Métodos

        private void CmbTipoDocumentoIdentidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tipoDocumentoIdentidad = (TipoDocumentoIdentidad)CmbTipoDocumentoIdentidad.SelectedItem;
            if (tipoDocumentoIdentidad == null)
            {
                TbDocumentoIdentidadNumero.MaxLength = 0;
                TbDocumentoIdentidadNumero.TipoCaracteres = CustomTextBox.TipoInput.Todo;
                ControlesPersonaJuridica_Mostrar(false);
            }
            else
            {
                TbDocumentoIdentidadNumero.MaxLength = tipoDocumentoIdentidad.LongitudMaxima;
                TbDocumentoIdentidadNumero.TipoCaracteres = tipoDocumentoIdentidad.Alfanumerico ? CustomTextBox.TipoInput.NumerosYLetras : CustomTextBox.TipoInput.SoloNumeros;
                ControlesPersonaJuridica_Mostrar(tipoDocumentoIdentidad.PersonaJuridica);
            }
            TbDocumentoIdentidadNumero.Clear();
        }

        private void BnNuevo_Click(object sender, EventArgs e)
        {
            SetAccion(FormAccion.nuevo);
        }

        private void BnEditar_Click(object sender, EventArgs e)
        {
            var cliente = (Cliente)DgvCliente.CurrentRow?.Tag;
            if (cliente == null)
            {
                MessageBox.Show(this, "Olvidó seleccionar un cliente", "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            SetAccion(FormAccion.editar);
            GbDatos_MostrarDatos(cliente);
        }

        private async void BnDeshabilitar_Click(object sender, EventArgs e)
        {
            var cliente = (Cliente)DgvCliente.CurrentRow?.Tag;
            if (cliente == null)
            {
                MessageBox.Show(this, "Olvidó seleccionar un cliente", "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string datosCliente = "\n";
            datosCliente += "\n\r - Tipo de Doc.:" + cliente.TipoDocumentoIdentidad.Nombre;
            datosCliente += "\n\r - Nº de Documento: " + cliente.NumeroDocumentoIdentidad;
            if (cliente.TipoDocumentoIdentidad.PersonaJuridica)
            {
                datosCliente += "\n\r - Razón Social: " + cliente.RazonSocial;
            }
            else
            {
                datosCliente += "\n\r - Nombres: " + cliente.Nombres;
                datosCliente += "\n\r - Apellido1: " + cliente.Apellido1;
                datosCliente += "\n\r - Apellido2: " + cliente.Apellido2;
            }

            if (MessageBox.Show(this, "¿Está seguro de deshabilitar al cliente?" + datosCliente, "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                BnDeshabilitar.Enabled = false;
                this.Cursor = Cursors.WaitCursor;
                await LogCliente.Instancia.ClienteDeshbilitar(cliente.IdCliente);
                cliente.Activo = false;
                DgvCliente_Actualizar(cliente);


                this.Cursor = Cursors.Default;
                MessageBox.Show(this, "El cliente fue deshabilitado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var tipoDocumentoIdentidad = (TipoDocumentoIdentidad)CmbTipoDocumentoIdentidad.SelectedItem;

                if (TbDocumentoIdentidadNumero.Text.Trim() == "") datosFaltantes += "\n\r - Nª de documento de identidad";
                if (tipoDocumentoIdentidad.PersonaJuridica)
                {
                    if (TbRazonSocial.Text.Trim() == "") datosFaltantes += "\n\r - Razón Social";
                }
                else
                {
                    if (TbNombres.Text.Trim() == "") datosFaltantes += "\n\r - Nombres";
                    if (TbApellido1.Text.Trim() == "") datosFaltantes += "\n\r - Apellido1";
                }

                if (!string.IsNullOrEmpty(datosFaltantes))
                {
                    MessageBox.Show(this, "Olvidó ingresar los siguientes datos: " + datosFaltantes, "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var documentoIdentidadNumero = TbDocumentoIdentidadNumero.Text.Trim();
                if (tipoDocumentoIdentidad.LongitudMinima > documentoIdentidadNumero.Length)
                {
                    string mensaje = $"El tipo de documento de identidad \"{tipoDocumentoIdentidad.Nombre}\" debe tener como mínimo {tipoDocumentoIdentidad.LongitudMinima} dígitos";
                    MessageBox.Show(this, mensaje, "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                if (this.Accion == FormAccion.nuevo) this.CurrentCliente = new Cliente();
                this.CurrentCliente.TipoDocumentoIdentidad = tipoDocumentoIdentidad;
                this.CurrentCliente.IdTipoDocumentoIdentidad = tipoDocumentoIdentidad.IdTipoDocumentoIdentidad;
                this.CurrentCliente.NumeroDocumentoIdentidad = TbDocumentoIdentidadNumero.Text.Trim();
                this.CurrentCliente.RazonSocial = tipoDocumentoIdentidad.PersonaJuridica ? TbRazonSocial.Text.Trim() : null;
                this.CurrentCliente.Nombres = tipoDocumentoIdentidad.PersonaJuridica ? null : TbNombres.Text.Trim();
                this.CurrentCliente.Apellido1 = tipoDocumentoIdentidad.PersonaJuridica ? null : TbApellido1.Text.Trim();
                this.CurrentCliente.Apellido2 = tipoDocumentoIdentidad.PersonaJuridica ? null : TbApellido2.Text.Trim();
                this.CurrentCliente.Celular = TbCelular.Text.Trim();
                this.CurrentCliente.Email = TbEmail.Text.Trim();

                if (MessageBox.Show(this, "¿Está seguro guardar los datos?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }


                BnGuardar.Enabled = false;
                this.Cursor = Cursors.WaitCursor;

                if (this.Accion == FormAccion.nuevo)
                {
                    this.CurrentCliente.IdCliente = await LogCliente.Instancia.ClienteInsertar(this.CurrentCliente);
                    DgvCliente_Agregar(this.CurrentCliente);
                }
                else
                {
                    await LogCliente.Instancia.ClienteActualizar(this.CurrentCliente);
                    DgvCliente_Actualizar(this.CurrentCliente);
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
                DgvCliente.Rows.Clear();
                BnFiltrar.Enabled = false;
                this.Cursor = Cursors.WaitCursor;

                var tipoDocumentoIdentidad = (TipoDocumentoIdentidad)CmbTipoDocumentoIdentidad.SelectedItem;
                var listaClientes = await LogCliente.Instancia.ClienteBusquedaGeneral(
                    tipoDocumentoIdentidad?.IdTipoDocumentoIdentidad,
                    TbDocumentoIdentidadNumero.Text.Trim(),
                    TbRazonSocial.Text.Trim(),
                    TbNombres.Text.Trim(),
                    TbApellido1.Text.Trim(),
                    TbApellido2.Text.Trim()
                );

                foreach (var cliente in listaClientes)
                {
                    DgvCliente_Agregar(cliente);
                }

                BnFiltrar.Enabled = true;
                this.Cursor = Cursors.Default;

                if (listaClientes.Count() == 0)
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

        private void FrmCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this._menu.Enabled = true;
        }
    }
}
