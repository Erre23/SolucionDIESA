using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DaoMetodoPago
    {
        #region sigleton
        private static readonly DaoMetodoPago _instancia = new DaoMetodoPago();
        public static DaoMetodoPago Instancia { get { return _instancia; } }
        #endregion singleton

        #region métodos
        public async Task<short> Insertar(MetodoPago MetodoPago)
        {
            var cmd = (SqlCommand)null;
            SqlConnection cnn = Conexion.Instancia.Conectar();
            await cnn.OpenAsync();
            using (var tran = cnn.BeginTransaction())
            { 
                try
                {
                    cmd = new SqlCommand("spMetodoPagoInsertar", cnn, tran);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(CreateParams.NVarchar("Nombre", MetodoPago.Nombre, 50));

                    MetodoPago.IdMetodoPago = Convert.ToInt16(await cmd.ExecuteScalarAsync());

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

            return MetodoPago.IdMetodoPago;
        }


        public async Task Actualizar(MetodoPago MetodoPago)
        {
            var cmd = (SqlCommand)null;
            SqlConnection cnn = Conexion.Instancia.Conectar();
            await cnn.OpenAsync();
            using (var tran = cnn.BeginTransaction())
            {
                try
                {
                    cmd = new SqlCommand("spMetodoPagoActualizar", cnn, tran);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(CreateParams.SmallInt("IdMetodoPago", MetodoPago.IdMetodoPago));
                    cmd.Parameters.Add(CreateParams.NVarchar("Nombre", MetodoPago.Nombre, 50));

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


        public async Task Deshabilitar(short idMetodoPago)
        {
            var cmd = (SqlCommand)null;
            SqlConnection cnn = Conexion.Instancia.Conectar();
            await cnn.OpenAsync();
            using (var tran = cnn.BeginTransaction())
            { 
                try
                {
                    cmd = new SqlCommand("spMetodoPagoDeshabilitar", cnn, tran);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(CreateParams.SmallInt("IdMetodoPago", idMetodoPago));

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

        public async Task<MetodoPago> BuscarPorIdMetodoPago(short idMetodoPago)
        {
            var cmd = (SqlCommand)null;
            var MetodoPago = (MetodoPago)null;
            try
            {
                SqlConnection cnn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spMetodoPagoBuscarPorIdMetodoPago", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(CreateParams.SmallInt("IdMetodoPago", idMetodoPago));
                await cnn.OpenAsync();

                SqlDataReader dr = await cmd.ExecuteReaderAsync();
                while (await dr.ReadAsync())
                {
                    MetodoPago = ReadEntidad(dr);
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

            return MetodoPago;
        }

        public async Task<List<MetodoPago>> ListarActivos()
        {
            var cmd = (SqlCommand)null;
            var listaMetodoPagos = new List<MetodoPago>();
            try
            {
                SqlConnection cnn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spMetodoPagoListarActivos", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                await cnn.OpenAsync();

                SqlDataReader dr = await cmd.ExecuteReaderAsync();
                while (await dr.ReadAsync())
                {
                    var MetodoPago = ReadEntidad(dr);
                    listaMetodoPagos.Add(MetodoPago);
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

            return listaMetodoPagos;
        }

        public async Task<List<MetodoPago>> ListarTodos()
        {
            var cmd = (SqlCommand)null;
            var listaMetodoPagos = new List<MetodoPago>();
            try
            {
                SqlConnection cnn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spMetodoPagoListarTodos", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                await cnn.OpenAsync();

                SqlDataReader dr = await cmd.ExecuteReaderAsync();
                while (await dr.ReadAsync())
                {
                    var MetodoPago = ReadEntidad(dr);
                    listaMetodoPagos.Add(MetodoPago);
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

            return listaMetodoPagos;
        }

        private MetodoPago ReadEntidad(SqlDataReader dr)
        {
            try
            {
                var obj = new MetodoPago();
                obj.IdMetodoPago = Convert.ToInt16(dr["IdMetodoPago"]);
                obj.Nombre = Convert.ToString(dr["Nombre"]);
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
