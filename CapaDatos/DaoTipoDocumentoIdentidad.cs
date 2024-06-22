using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DaoTipoDocumentoIdentidad
    {
        #region sigleton
        private static readonly DaoTipoDocumentoIdentidad _instancia = new DaoTipoDocumentoIdentidad();        
        public static DaoTipoDocumentoIdentidad Instancia { get { return _instancia; } }
        #endregion singleton


        #region metodos        
        public async Task<List<TipoDocumentoIdentidad>> ListarActivos()
        {
            var cmd = (SqlCommand)null;
            var objLista = new List<TipoDocumentoIdentidad>();
            try
            {
                SqlConnection cnn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spTipoDocumentoIdentidadListarActivos", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                await cnn.OpenAsync();

                SqlDataReader dr = await cmd.ExecuteReaderAsync();
                while (await dr.ReadAsync())
                {
                    var obj = ReadEntidad(dr);
                    objLista.Add(obj);
                }
                dr.Close();

                cmd.Connection.Close();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                cmd.Connection.Close();
                cmd.Dispose();
                throw e;
            }

            return objLista;
        }

        public async Task<List<TipoDocumentoIdentidad>> ListarTodos()
        {
            var cmd = (SqlCommand)null;
            var objLista = new List<TipoDocumentoIdentidad>();
            try
            {
                SqlConnection cnn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spTipoDocumentoIdentidadListarTodos", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                await cnn.OpenAsync();

                SqlDataReader dr = cmd.ExecuteReader();
                while (await dr.ReadAsync())
                {
                    var obj = ReadEntidad(dr);
                    objLista.Add(obj);
                }
                dr.Close();

                cmd.Connection.Close();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                cmd.Connection.Close();
                cmd.Dispose();
                throw e;
            }

            return objLista;
        }

        private TipoDocumentoIdentidad ReadEntidad(SqlDataReader dr)
        {
            try
            {

                var obj = new TipoDocumentoIdentidad();
                obj.IdTipoDocumentoIdentidad = Convert.ToInt16(dr["IdTipoDocumentoIdentidad"]);
                obj.Nombre = dr["Nombre"].ToString();
                obj.LongitudExacta = Convert.ToBoolean(dr["LongitudExacta"]);
                obj.LongitudMaxima = Convert.ToInt16(dr["LongitudMaxima"]);
                obj.LongitudMinima = Convert.ToInt16(dr["LongitudMinima"]);
                obj.Alfanumerico = Convert.ToBoolean(dr["Alfanumerico"]);
                obj.PersonaJuridica = Convert.ToBoolean(dr["PersonaJuridica"]);
                obj.Activo = Convert.ToBoolean(dr["Activo"]);

                return obj;

            }
            catch(Exception ex)
            {
                dr.Close();
                throw ex;
            }
        }
        #endregion metodos
    }
}
