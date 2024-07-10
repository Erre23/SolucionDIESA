using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DaoInspector
    {
        #region sigleton
        private static readonly DaoInspector _instancia = new DaoInspector();
        public static DaoInspector Instancia { get { return _instancia; } }
        #endregion singleton

        #region métodos
        public async Task<int> Insertar(Inspector Inspector)
        {
            var cmd = (SqlCommand)null;
            SqlConnection cnn = Conexion.Instancia.Conectar();
            await cnn.OpenAsync();
            using (var tran = cnn.BeginTransaction())
            { 
                try
                {
                    cmd = new SqlCommand("spInspectorInsertar", cnn, tran);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(CreateParams.TinyInt("IdTipoDocumentoIdentidad", Inspector.IdTipoDocumentoIdentidad));
                    cmd.Parameters.Add(CreateParams.NVarchar("NumeroDocumentoIdentidad", Inspector.NumeroDocumentoIdentidad, 20));
                    cmd.Parameters.Add(CreateParams.NVarchar("Nombres", Inspector.Nombres, 100));
                    cmd.Parameters.Add(CreateParams.NVarchar("Apellido1", Inspector.Apellido1, 50));
                    cmd.Parameters.Add(CreateParams.NVarchar("Apellido2", Inspector.Apellido2, 50));
                    cmd.Parameters.Add(CreateParams.NVarchar("Celular", Inspector.Celular, 50));
                    cmd.Parameters.Add(CreateParams.NVarchar("Email", Inspector.Email, 100));

                    Inspector.IdInspector = Convert.ToInt32(await cmd.ExecuteScalarAsync());

                    tran.Commit();
                    cmd.Connection.Close();
                    cmd.Dispose();
                }
                catch (Exception e)
                {
                    tran.Rollback();
                    cmd.Connection.Close();
                    cmd.Dispose();
                    throw e;
                }
            }

            return Inspector.IdInspector;
        }


        public async Task Actualizar(Inspector Inspector)
        {
            var cmd = (SqlCommand)null;
            SqlConnection cnn = Conexion.Instancia.Conectar();
            await cnn.OpenAsync();
            using (var tran = cnn.BeginTransaction())
            {
                try
                {
                    cmd = new SqlCommand("spInspectorActualizar", cnn, tran);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(CreateParams.Int("IdInspector", Inspector.IdInspector));
                    cmd.Parameters.Add(CreateParams.TinyInt("IdTipoDocumentoIdentidad", Inspector.IdTipoDocumentoIdentidad));
                    cmd.Parameters.Add(CreateParams.NVarchar("NumeroDocumentoIdentidad", Inspector.NumeroDocumentoIdentidad, 20));
                    cmd.Parameters.Add(CreateParams.NVarchar("Nombres", Inspector.Nombres, 100));
                    cmd.Parameters.Add(CreateParams.NVarchar("Apellido1", Inspector.Apellido1, 50));
                    cmd.Parameters.Add(CreateParams.NVarchar("Apellido2", Inspector.Apellido2, 50));
                    cmd.Parameters.Add(CreateParams.NVarchar("Celular", Inspector.Celular, 50));
                    cmd.Parameters.Add(CreateParams.NVarchar("Email", Inspector.Email, 100));

                    cmd.ExecuteNonQuery();
                    tran.Commit();
                    cmd.Connection.Close();
                    cmd.Dispose();
                }
                catch (Exception e)
                {
                    tran.Rollback();
                    cmd.Connection.Close();
                    cmd.Dispose();
                    throw e;
                }
            }
        }


        public async Task Deshabilitar(int idInspector)
        {
            var cmd = (SqlCommand)null;
            SqlConnection cnn = Conexion.Instancia.Conectar();
            await cnn.OpenAsync();
            using (var tran = cnn.BeginTransaction())
            { 
                try
                {
                    cmd = new SqlCommand("spInspectorDeshabilitar", cnn, tran);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(CreateParams.Int("IdInspector", idInspector));

                    cmd.ExecuteNonQuery(); 
                    
                    tran.Commit();
                    cmd.Connection.Close();
                    cmd.Dispose();
                }
                catch (Exception e)
                {
                    tran.Rollback();
                    cmd.Connection.Close();
                    cmd.Dispose();
                    throw e;
                }
            }
        }

        public async Task<Inspector> BuscarPorIdInspector(int idInspector)
        {
            var cmd = (SqlCommand)null;
            var Inspector = (Inspector)null;
            try
            {
                SqlConnection cnn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInspectorBuscarPorIdInspector", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(CreateParams.Int("IdInspector", idInspector));
                await cnn.OpenAsync();

                SqlDataReader dr = await cmd.ExecuteReaderAsync();
                while (await dr.ReadAsync())
                {
                    Inspector = await ReadEntidad(dr);
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

            return Inspector;
        }

        public async Task<Inspector> BuscarPorDocumentoIdentidad(short idTipoDocumentoIdentidad, string numeroDocumentoIdentidad)
        {
            var cmd = (SqlCommand)null;
            var Inspector = (Inspector)null;
            try
            {
                SqlConnection cnn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInspectorBuscarPorDocumentoIdentidad", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(CreateParams.TinyInt("IdTipoDocumentoIdentidad", idTipoDocumentoIdentidad));
                cmd.Parameters.Add(CreateParams.NVarchar("NumeroDocumentoIdentidad", numeroDocumentoIdentidad, 20));
                await cnn.OpenAsync();

                SqlDataReader dr = await cmd.ExecuteReaderAsync();
                while (await dr.ReadAsync())
                {
                    Inspector = await ReadEntidad(dr);
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

            return Inspector;
        }

        public async Task<List<Inspector>> BusquedaGeneral(short? idTipoDocumentoIdentidad, string numeroDocumentoIdentidad, string nombres, string apellido1, string apellido2)
        {
            var cmd = (SqlCommand)null;
            var listaInspectors = new List<Inspector>();
            try
            {
                SqlConnection cnn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInspectorBusquedaGeneral", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(CreateParams.TinyInt("idTipoDocumentoIdentidad", idTipoDocumentoIdentidad));
                cmd.Parameters.Add(CreateParams.NVarchar("numeroDocumentoIdentidad", numeroDocumentoIdentidad, 20));
                cmd.Parameters.Add(CreateParams.NVarchar("Nombres", nombres, 100));
                cmd.Parameters.Add(CreateParams.NVarchar("Apellido1", apellido1, 50));
                cmd.Parameters.Add(CreateParams.NVarchar("Apellido2", apellido2, 50));
                await cnn.OpenAsync();

                SqlDataReader dr = await cmd.ExecuteReaderAsync();
                while (await dr.ReadAsync())
                {
                    var Inspector = await ReadEntidad(dr);
                    listaInspectors.Add(Inspector);
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

            return listaInspectors;
        }

        public async Task<List<Inspector>> ListarActivos()
        {
            var cmd = (SqlCommand)null;
            var listaInspectors = new List<Inspector>();
            try
            {
                SqlConnection cnn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInspectorListarActivos", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                await cnn.OpenAsync();

                SqlDataReader dr = await cmd.ExecuteReaderAsync();
                while (await dr.ReadAsync())
                {
                    var Inspector = await ReadEntidad(dr);
                    listaInspectors.Add(Inspector);
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

            return listaInspectors;
        }

        private async Task<Inspector> ReadEntidad(SqlDataReader dr, bool traerContraseña = false)
        {
            try
            {
                var obj = new Inspector();
                obj.IdInspector = Convert.ToInt32(dr["IdInspector"]);
                obj.IdTipoDocumentoIdentidad = Convert.ToInt16(dr["IdTipoDocumentoIdentidad"]);
                obj.NumeroDocumentoIdentidad = dr["NumeroDocumentoIdentidad"].ToString();
                if (!(await dr.IsDBNullAsync(dr.GetOrdinal("Nombres")))) obj.Nombres = dr["Nombres"].ToString();
                if (!(await dr.IsDBNullAsync(dr.GetOrdinal("Apellido1")))) obj.Apellido1 = dr["Apellido1"].ToString();
                if (!(await dr.IsDBNullAsync(dr.GetOrdinal("Apellido2")))) obj.Apellido2 = dr["Apellido2"].ToString();
                if (!(await dr.IsDBNullAsync(dr.GetOrdinal("Celular")))) obj.Celular = dr["Celular"].ToString();
                if (!(await dr.IsDBNullAsync(dr.GetOrdinal("Email")))) obj.Email = dr["Email"].ToString();
                obj.Activo = Convert.ToBoolean(dr["Activo"]);

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
