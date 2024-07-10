using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DaoProgramacionInspeccion
    {
        #region sigleton
        private static readonly DaoProgramacionInspeccion _instancia = new DaoProgramacionInspeccion();
        public static DaoProgramacionInspeccion Instancia { get { return _instancia; } }
        #endregion singleton

        #region métodos
        public async Task<int> Insertar(ProgramacionInspeccion programacionInspeccion)
        {
            var cmd = (SqlCommand)null;
            SqlConnection cnn = Conexion.Instancia.Conectar();
            await cnn.OpenAsync();
            using (var tran = cnn.BeginTransaction())
            { 
                try
                {
                    cmd = new SqlCommand("spProgramacionInspeccionInsertar", cnn, tran);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(CreateParams.DateTime("FechaHoraRegistro", programacionInspeccion.FechaHoraRegistro));
                    cmd.Parameters.Add(CreateParams.Int("IdCliente", programacionInspeccion.IdCliente));
                    cmd.Parameters.Add(CreateParams.Int("IdTipoInspeccion", programacionInspeccion.IdTipoInspeccion));
                    cmd.Parameters.Add(CreateParams.NVarchar("Vehiculo", programacionInspeccion.Vehiculo, 10));
                    cmd.Parameters.Add(CreateParams.SmallInt("IdTaller", programacionInspeccion.IdTaller));
                    cmd.Parameters.Add(CreateParams.Date("InspeccionFecha", programacionInspeccion.InspeccionFecha));
                    cmd.Parameters.Add(CreateParams.Time("InspeccionHora", programacionInspeccion.InspeccionHora));
                    cmd.Parameters.Add(CreateParams.Int("IdInspector", programacionInspeccion.IdInspector));
                    cmd.Parameters.Add(CreateParams.SmallInt("IdMetodoPago", programacionInspeccion.IdMetodoPago));
                    cmd.Parameters.Add(CreateParams.Decimal("Total", programacionInspeccion.Total, 10, 2));

                    programacionInspeccion.IdProgramacionInspeccion = Convert.ToInt32(await cmd.ExecuteScalarAsync());

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

            return programacionInspeccion.IdProgramacionInspeccion;
        }


        public async Task Anular(int idProgramacionInspeccion)
        {
            var cmd = (SqlCommand)null;
            SqlConnection cnn = Conexion.Instancia.Conectar();
            await cnn.OpenAsync();
            using (var tran = cnn.BeginTransaction())
            { 
                try
                {
                    cmd = new SqlCommand("spProgramacionInspeccionAnular", cnn, tran);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(CreateParams.Int("IdProgramacionInspeccion", idProgramacionInspeccion));

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

        public async Task<ProgramacionInspeccion> BuscarPorIdProgramacionInspeccion(int idProgramacionInspeccion)
        {
            var cmd = (SqlCommand)null;
            var programacionInspeccion = (ProgramacionInspeccion)null;
            try
            {
                SqlConnection cnn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spProgramacionInspeccionBuscarPorIdProgramacionInspeccion", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(CreateParams.Int("IdProgramacionInspeccion", idProgramacionInspeccion));
                await cnn.OpenAsync();

                SqlDataReader dr = await cmd.ExecuteReaderAsync();
                while (await dr.ReadAsync())
                {
                    programacionInspeccion = ReadEntidad(dr);
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

            return programacionInspeccion;
        }

        public async Task<List<ProgramacionInspeccion>> BuscarPorTallerFecha(short idTaller, DateTime fecha)
        {
            var cmd = (SqlCommand)null;
            var programacionesInspeccion = new List<ProgramacionInspeccion>();
            try
            {
                SqlConnection cnn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spProgramacionInspeccionBuscarPorTallerFecha", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(CreateParams.SmallInt("IdTaller", idTaller));
                cmd.Parameters.Add(CreateParams.Date("Fecha", fecha));
                await cnn.OpenAsync();

                SqlDataReader dr = await cmd.ExecuteReaderAsync();
                while (await dr.ReadAsync())
                {
                    var programacionInspeccion = ReadEntidad(dr);
                    programacionesInspeccion.Add(programacionInspeccion);
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

            return programacionesInspeccion;
        }

        private ProgramacionInspeccion ReadEntidad(SqlDataReader dr)
        {
            try
            {
                var obj = new ProgramacionInspeccion();
                obj.IdProgramacionInspeccion = Convert.ToInt32(dr["IdProgramacionInspeccion"]);
                obj.FechaHoraRegistro = Convert.ToDateTime(dr["FechaHoraRegistro"]);
                obj.IdCliente = Convert.ToInt32(dr["IdCliente"]);
                obj.IdTipoInspeccion = Convert.ToInt16(dr["IdTipoInspeccion"]);
                obj.Vehiculo = Convert.ToString(dr["Vehiculo"]);
                obj.IdTaller = Convert.ToInt16(dr["IdTaller"]);
                obj.InspeccionFecha = Convert.ToDateTime(dr["InspeccionFecha"]);
                obj.InspeccionHora = DateTime.Now.Date + dr.GetTimeSpan(dr.GetOrdinal("InspeccionHora"));
                obj.IdInspector = Convert.ToInt32(dr["IdInspector"]);
                obj.IdMetodoPago = Convert.ToInt16(dr["IdMetodoPago"]);
                obj.Total = Convert.ToDecimal(dr["Total"]);
                obj.Anulado = Convert.ToBoolean(dr["Anulado"]);

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
