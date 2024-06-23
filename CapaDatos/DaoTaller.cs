using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DaoTaller
    {
        #region sigleton
        private static readonly DaoTaller _instancia = new DaoTaller();
        public static DaoTaller Instancia { get { return _instancia; } }
        #endregion singleton

        #region métodos
        public async Task<short> Insertar(Taller Taller)
        {
            var cmd = (SqlCommand)null;
            SqlConnection cnn = Conexion.Instancia.Conectar();
            await cnn.OpenAsync();
            using (var tran = cnn.BeginTransaction())
            { 
                try
                {
                    cmd = new SqlCommand("spTallerInsertar", cnn, tran);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(CreateParams.NVarchar("Nombre", Taller.Nombre, 50));
                    cmd.Parameters.Add(CreateParams.NVarchar("Direccion", Taller.Direccion, 200));
                    cmd.Parameters.Add(CreateParams.Int("IdDistrito", Taller.IdDistrito));
                    cmd.Parameters.Add(CreateParams.Time("HoraInicio", Taller.HoraInicio));
                    cmd.Parameters.Add(CreateParams.Time("HoraFin", Taller.HoraFin));
                    cmd.Parameters.Add(CreateParams.Bit("Lunes", Taller.Lunes));
                    cmd.Parameters.Add(CreateParams.Bit("Martes", Taller.Martes));
                    cmd.Parameters.Add(CreateParams.Bit("Miercoles", Taller.Miercoles));
                    cmd.Parameters.Add(CreateParams.Bit("Jueves", Taller.Jueves));
                    cmd.Parameters.Add(CreateParams.Bit("Viernes", Taller.Viernes));
                    cmd.Parameters.Add(CreateParams.Bit("Sabado", Taller.Sabado));
                    cmd.Parameters.Add(CreateParams.Bit("Domingo", Taller.Domingo));

                    Taller.IdTaller = Convert.ToInt16(await cmd.ExecuteScalarAsync());

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

            return Taller.IdTaller;
        }


        public async Task Actualizar(Taller Taller)
        {
            var cmd = (SqlCommand)null;
            SqlConnection cnn = Conexion.Instancia.Conectar();
            await cnn.OpenAsync();
            using (var tran = cnn.BeginTransaction())
            {
                try
                {
                    cmd = new SqlCommand("spTallerActualizar", cnn, tran);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(CreateParams.TinyInt("IdTaller", Taller.IdTaller));
                    cmd.Parameters.Add(CreateParams.NVarchar("Nombre", Taller.Nombre, 50));
                    cmd.Parameters.Add(CreateParams.NVarchar("Direccion", Taller.Direccion, 200));
                    cmd.Parameters.Add(CreateParams.Int("IdDistrito", Taller.IdDistrito));
                    cmd.Parameters.Add(CreateParams.Time("HoraInicio", Taller.HoraInicio));
                    cmd.Parameters.Add(CreateParams.Time("HoraFin", Taller.HoraFin));
                    cmd.Parameters.Add(CreateParams.Bit("Lunes", Taller.Lunes));
                    cmd.Parameters.Add(CreateParams.Bit("Martes", Taller.Martes));
                    cmd.Parameters.Add(CreateParams.Bit("Miercoles", Taller.Miercoles));
                    cmd.Parameters.Add(CreateParams.Bit("Jueves", Taller.Jueves));
                    cmd.Parameters.Add(CreateParams.Bit("Viernes", Taller.Viernes));
                    cmd.Parameters.Add(CreateParams.Bit("Sabado", Taller.Sabado));
                    cmd.Parameters.Add(CreateParams.Bit("Domingo", Taller.Domingo));

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


        public async Task Deshabilitar(short idTaller)
        {
            var cmd = (SqlCommand)null;
            SqlConnection cnn = Conexion.Instancia.Conectar();
            await cnn.OpenAsync();
            using (var tran = cnn.BeginTransaction())
            { 
                try
                {
                    cmd = new SqlCommand("spTallerDeshabilitar", cnn, tran);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(CreateParams.SmallInt("IdTaller", idTaller));

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

        public async Task<Taller> BuscarPorIdTaller(int idTaller)
        {
            var cmd = (SqlCommand)null;
            var Taller = (Taller)null;
            try
            {
                SqlConnection cnn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spTallerBuscarPorIdTaller", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(CreateParams.Int("IdTaller", idTaller));
                await cnn.OpenAsync();

                SqlDataReader dr = await cmd.ExecuteReaderAsync();
                while (await dr.ReadAsync())
                {
                    Taller = ReadEntidad(dr);
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

            return Taller;
        }

        public async Task<List<Taller>> BusquedaGeneral(string nombre, int? idDepartamento, int? idProvincia, int? idDistrito)
        {
            var cmd = (SqlCommand)null;
            var listaTallers = new List<Taller>();
            try
            {
                SqlConnection cnn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spTallerBusquedaGeneral", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(CreateParams.NVarchar("Nombre", nombre, 50));
                cmd.Parameters.Add(CreateParams.Int("IdDepartamento", idDepartamento == 0 ? null : idDepartamento));
                cmd.Parameters.Add(CreateParams.Int("IdProvincia", idProvincia == 0 ? null : idProvincia));
                cmd.Parameters.Add(CreateParams.Int("IdDistrito", idDistrito == 0 ? null : idDistrito));
                await cnn.OpenAsync();

                SqlDataReader dr = await cmd.ExecuteReaderAsync();
                while (await dr.ReadAsync())
                {
                    var Taller = ReadEntidad(dr);
                    listaTallers.Add(Taller);
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

            return listaTallers;
        }

        public async Task<List<Taller>> BuscarDisponiblesPorFecha(DateTime Fecha)
        {
            var cmd = (SqlCommand)null;
            var listaTallers = new List<Taller>();
            try
            {
                SqlConnection cnn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spTallerBuscarDisponiblesPorFecha", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(CreateParams.Date("Fecha", Fecha));
                await cnn.OpenAsync();

                SqlDataReader dr = await cmd.ExecuteReaderAsync();
                while (await dr.ReadAsync())
                {
                    var Taller = ReadEntidad(dr);
                    listaTallers.Add(Taller);
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

            return listaTallers;
        }

        private Taller ReadEntidad(SqlDataReader dr, bool traerContraseña = false)
        {
            try
            {
                var obj = new Taller();
                obj.IdTaller = Convert.ToInt16(dr["IdTaller"]);
                obj.Nombre = Convert.ToString(dr["Nombre"]);
                obj.Direccion = Convert.ToString(dr["Direccion"]);
                obj.IdDistrito = Convert.ToInt32(dr["IdDistrito"]);
                obj.HoraInicio = DateTime.Now.Date + dr.GetTimeSpan(dr.GetOrdinal("HoraInicio"));
                obj.HoraFin = DateTime.Now.Date + dr.GetTimeSpan(dr.GetOrdinal("HoraFin"));
                obj.Lunes = Convert.ToBoolean(dr["Lunes"]);
                obj.Martes = Convert.ToBoolean(dr["Martes"]);
                obj.Miercoles = Convert.ToBoolean(dr["Miercoles"]);
                obj.Jueves = Convert.ToBoolean(dr["Jueves"]);
                obj.Viernes = Convert.ToBoolean(dr["Viernes"]);
                obj.Sabado = Convert.ToBoolean(dr["Sabado"]);
                obj.Domingo = Convert.ToBoolean(dr["Domingo"]);
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
