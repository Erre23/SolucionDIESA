using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidad;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DaoTipoInspeccion
    {
        #region sigleton
        private static readonly DaoTipoInspeccion _instancia = new DaoTipoInspeccion();
        public static DaoTipoInspeccion Instancia { get { return _instancia; } }
        #endregion singleton
        public Boolean InsertarTipoInspeccion(EntTipoInspeccion Ins)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarTipoInspeccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
         
                cmd.Parameters.AddWithValue("@Estado", Ins.Estado);
                cmd.Parameters.AddWithValue("@TipoInspeccion", Ins.TipoInspeccion);
                cmd.Parameters.AddWithValue("@Descripcion", Ins.Descripcion);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        public Boolean EditarTipoInspeccion(EntTipoInspeccion Ins)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarTipoInspeccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TipoInspeccion", Ins.TipoInspeccion);
                cmd.Parameters.AddWithValue("@Descripcion", Ins.Descripcion);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        public Boolean InhabilitarTipoInspeccion(EntTipoInspeccion Ins)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaTipoInspeccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTipoInspeccion", Ins.TipoInspeccion);
                //cmd.Parameters.AddWithValue("@Estado", Ins.Estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;

        }

        public List<EntTipoInspeccion> ListarTipoInspeccion()
        {
            SqlCommand cmd = null;
           
            List<EntTipoInspeccion> lista = new List<EntTipoInspeccion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarTipoInspector", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntTipoInspeccion Cli = new EntTipoInspeccion();

                    Cli.IdTipoInspeccion = Convert.ToInt32(dr["Id de Inspeccion"]);
                    Cli.Estado = dr["Estado"].ToString();
                    Cli.TipoInspeccion = dr["Nombre de la Inspeccion"].ToString();
                    Cli.Descripcion = dr["Drescripcion"].ToString();
                    
                    
                    lista.Add(Cli);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }


    }

}

