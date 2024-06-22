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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private Usuario _usuarioActual { get; set; }
        public Usuario GetUsuarioActual { get { return _usuarioActual; } }

        private async void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                CmbTipoDocumentoIdentidad.Items.Clear();
                CmbTipoDocumentoIdentidad.DisplayMember = "Nombre";
                var tiposDocumentoIdentidad = await LogTipoDocumentoIdentidad.Instancia.TipoDocumentoIdentidaListarActivos();
                foreach (var item in tiposDocumentoIdentidad)
                {
                    if (!item.PersonaJuridica) CmbTipoDocumentoIdentidad.Items.Add(item);
                }

                if (CmbTipoDocumentoIdentidad.Items.Count > 0) CmbTipoDocumentoIdentidad.SelectedIndex = 0;

                //var usuario = new Usuario
                //{
                //    IdTipoDocumentoIdentidad = 1,
                //    NumeroDocumentoIdentidad = "11111111",
                //    Nombres = "Test",
                //    Apellido1 = "Apellido1",
                //    Apellido2 = "Apellido2",
                //    HashContrasena = "123456",
                //    CambioContrasena = true,
                //    Activo = true
                //};
                //await LogUsuario.Instancia.UsuarioInsertar(usuario);
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Se produjo un error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void CmbTipoDocumentoIdentidad_SelectedValueChanged(object sender, EventArgs e)
        {
            TbNumeroDocumentoIdentidad.Clear();
            var tipoDocumentoIdentidad = (TipoDocumentoIdentidad)CmbTipoDocumentoIdentidad.SelectedItem;
            TbNumeroDocumentoIdentidad.MaxLength = tipoDocumentoIdentidad.LongitudMaxima;
        }

        private void TbNumeroDocumentoIdentidad_TextChanged(object sender, EventArgs e)
        {
            TbNumeroDocumentoIdentidad.Tag = null;
            TbApellidosNombres.Clear();
            TbContrasena.Clear();
            TbContrasena.Enabled = false;
        }

        private async void BnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var tipoDocumentoIdentidad = (TipoDocumentoIdentidad)CmbTipoDocumentoIdentidad.SelectedItem;
                if (tipoDocumentoIdentidad == null)
                {
                    MessageBox.Show(this, "Seleccione un tipo de documento de identidad", "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (tipoDocumentoIdentidad.LongitudMinima != TbNumeroDocumentoIdentidad.Text.Length)
                {
                    MessageBox.Show(this, $"El número de documento de identidad debe tener mínimo {tipoDocumentoIdentidad.LongitudMinima} caracteres", "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(TbNumeroDocumentoIdentidad.Text.Trim()))
                {
                    MessageBox.Show(this, "Ingrese un número de documento de identidad", "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                var usuario = await LogUsuario.Instancia.UsuarioBuscarPorDocumentoIdentidad(tipoDocumentoIdentidad.IdTipoDocumentoIdentidad, TbNumeroDocumentoIdentidad.Text);

                if (usuario == null)
                {
                    MessageBox.Show(this, "No se encontró un usuario con los datos ingresados", "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                TbNumeroDocumentoIdentidad.Tag = usuario;
                TbApellidosNombres.Text = usuario.ApellidosNombres;
                TbContrasena.Enabled = true;
                TbContrasena.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Se produjo un error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private async void BnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = (Usuario)TbNumeroDocumentoIdentidad.Tag;
                if (usuario == null)
                {
                    MessageBox.Show(this, "Olvidó ingresar un usuario", "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(TbContrasena.Text))
                {
                    MessageBox.Show(this, "Olvidó ingresar la contraseña", "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                var usuarioLogin = await LogUsuario.Instancia.UsuarioLogin(usuario.IdUsuario, TbContrasena.Text);
                if (usuarioLogin == null)
                {
                    MessageBox.Show(this, "Contraseña incorrecta", "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (!usuarioLogin.Activo)
                {
                    MessageBox.Show(this, "El usuario no se encuentra activo", "Un momento por favor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                
                if (usuarioLogin.CambioContrasena)
                {
                    /* NOTA: Esta pendiente el cambio de contraseña de forma obligatoria */
                }

                MessageBox.Show(this, $"Bienvenido {usuarioLogin.ApellidosNombres}");

                _usuarioActual = usuarioLogin;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Se produjo un error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void BnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
