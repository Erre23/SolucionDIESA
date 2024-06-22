using CapaEntidad;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DaoUsuario
    {
        #region sigleton
        private static readonly DaoUsuario _instancia = new DaoUsuario();
        public static DaoUsuario Instancia { get { return _instancia; } }
        #endregion singleton

        #region métodos
        private const int SaltSize = 16; // Tamaño de la sal en bytes
        private const int Iterations = 100000; // Número de iteraciones para PBKDF2
        private string Encriptar(string contrasena)
        {
            // Genera una sal aleatoria
            byte[] salt = new byte[SaltSize];
            new RNGCryptoServiceProvider().GetBytes(salt);

            // Crea el hash de la contraseña
            var pbkdf2 = new Rfc2898DeriveBytes(contrasena, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20); // 20 bytes para el hash

            // Combina la sal y el hash para almacenar
            byte[] hashBytes = new byte[SaltSize + 20];
            Array.Copy(salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(hash, 0, hashBytes, SaltSize, 20);

            // Convierte a Base64 para almacenar en la base de datos
            string hashedPassword = Convert.ToBase64String(hashBytes);

            return hashedPassword;
        }

        public bool VerificarContrasena(string hashContrasenaGuardada, string contrasenaIngresada)
        {
            // Extrae la sal y el hash almacenados
            byte[] hashBytesContrasenaGuardada = Convert.FromBase64String(hashContrasenaGuardada);
            byte[] salt = new byte[SaltSize];
            Array.Copy(hashBytesContrasenaGuardada, 0, salt, 0, SaltSize);

            // Calcula el hash para la contraseña ingresada
            var pbkdf2 = new Rfc2898DeriveBytes(contrasenaIngresada, salt, Iterations);
            byte[] hashBytesContrasenaIngresada = pbkdf2.GetBytes(20);

            // Compara los hashes
            for (int i = 0; i < 20; i++)
            {
                if (hashBytesContrasenaGuardada[i + SaltSize] != hashBytesContrasenaIngresada[i])
                    return false;
            }

            return true;
        }

        public async Task<int> Insertar(Usuario usuario)
        {

            usuario.HashContrasena = Encriptar(usuario.HashContrasena);
            var cmd = (SqlCommand)null;

            SqlConnection cnn = Conexion.Instancia.Conectar();
            await cnn.OpenAsync();
            using (var tran = cnn.BeginTransaction())
            {
                try
                {
                    cmd = new SqlCommand("spUsuarioInsertar", cnn, tran);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(CreateParams.TinyInt("IdTipoDocumentoIdentidad", usuario.IdTipoDocumentoIdentidad));
                    cmd.Parameters.Add(CreateParams.NVarchar("NumeroDocumentoIdentidad", usuario.NumeroDocumentoIdentidad, 20));
                    cmd.Parameters.Add(CreateParams.NVarchar("Nombres", usuario.Nombres, 100));
                    cmd.Parameters.Add(CreateParams.NVarchar("Apellido1", usuario.Apellido1, 50));
                    cmd.Parameters.Add(CreateParams.NVarchar("Apellido2", usuario.Apellido2, 50));
                    cmd.Parameters.Add(CreateParams.NVarchar("HashContrasena", usuario.HashContrasena, -1));
                    cmd.Parameters.Add(CreateParams.Bit("CambioContrasena", usuario.CambioContrasena));
                    cmd.Parameters.Add(CreateParams.Bit("Activo", usuario.Activo));                    

                    usuario.IdUsuario = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                    tran.Commit();
                }
                catch (Exception e)
                {
                    tran.Rollback();
                    cmd.Connection.Close();
                    cmd.Dispose();
                    throw e;
                }
                finally
                {                    
                    cmd.Connection.Close();
                    cmd.Dispose();
                }

            }

            return usuario.IdUsuario;
        }

        public async Task<Usuario> Login(int idUsuario, string contrasena)
        {
            var cmd = (SqlCommand)null;
            var usuario = (Usuario)null;
            try
            {
                SqlConnection cnn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spUsuarioBuscarPorId", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(CreateParams.Int("IdUsuario", idUsuario));
                await cnn.OpenAsync();

                SqlDataReader dr = await cmd.ExecuteReaderAsync();
                while (await dr.ReadAsync())
                {
                    usuario = ReadEntidad(dr, true);
                }

                dr.Close();

                /* Si las contraseñas no coinciden retornamos el usuario null */
                if (!VerificarContrasena(usuario.HashContrasena, contrasena)) usuario = null;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }

            return usuario;
        }

        public async Task<Usuario> BuscarPorDocumentoIdentidad(short idTipoDocumentoIdentidad, string numeroDocumentoIdentidad)
        {
            var cmd = (SqlCommand)null;
            var usuario = (Usuario)null;
            try
            {
                SqlConnection cnn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spUsuarioBuscarTipoDocumentoIdentidad", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(CreateParams.TinyInt("idTipoDocumentoIdentidad", idTipoDocumentoIdentidad));
                cmd.Parameters.Add(CreateParams.NVarchar("numeroDocumentoIdentidad", numeroDocumentoIdentidad, 20));
                await cnn.OpenAsync();

                SqlDataReader dr = await cmd.ExecuteReaderAsync();
                while (await dr.ReadAsync())
                {
                    usuario = ReadEntidad(dr);
                }
                dr.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }

            return usuario;
        }

        private Usuario ReadEntidad(SqlDataReader dr, bool traerContraseña = false)
        {
            try
            {

                var obj = new Usuario();
                obj.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                obj.IdTipoDocumentoIdentidad = Convert.ToInt16(dr["IdTipoDocumentoIdentidad"]);
                obj.NumeroDocumentoIdentidad = dr["NumeroDocumentoIdentidad"].ToString();
                obj.Nombres = dr["Nombres"].ToString();
                obj.Apellido1 = dr["Apellido1"].ToString();
                obj.Apellido2 = dr["Apellido2"].ToString();
                obj.CambioContrasena = Convert.ToBoolean(dr["CambioContrasena"]);
                obj.Activo = Convert.ToBoolean(dr["Activo"]);
                if (traerContraseña) obj.HashContrasena = dr["HashContrasena"].ToString();

                return obj;
            }
            catch(Exception ex)
            {
                dr.Close();
                throw ex;
            }
        }
        #endregion métodos
    }
}
