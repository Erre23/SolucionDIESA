using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
    public class DaoInspector
    {
        #region sigleton
        private static readonly DaoInspector _instancia = new DaoInspector();
        public static DaoInspector Instancia { get { return _instancia; } }
        #endregion singleton

        public List<EntInspector> ListarInspector()
        {
            SqlCommand cmd = null;
            List<EntInspector> lista = new List<EntInspector>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarInspector", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntInspector Cli = new EntInspector();
                    Cli.NumeroEmpleado = Convert.ToInt32(dr["NumeroEmpledo"]);
                    Cli.Estado = dr["Estado"].ToString();
                    Cli.TipoDocumento = dr["TipoDocumento"].ToString();
                    Cli.NumeroDocumentoIdentidad = Convert.ToInt32(dr["NumeroDocumento"]);
                    Cli.Nombres = dr["NombreCompleto"].ToString();
                    Cli.Apellido1= dr["Apellido1"].ToString();
                    Cli.Apellido2= dr["Apellido2"].ToString();
                    Cli.Celular = Convert.ToInt32(dr["Celular"]);
                    Cli.Email= dr["Email"].ToString();  
                    Cli.RazonSocial = dr["razonSocial"].ToString();
                    
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

        public Boolean InsertarInspector(EntInspector Ins)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarInspector", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Estado", Ins.Estado);
                cmd.Parameters.AddWithValue("@TipoDocumento", Ins.TipoDocumento);
                cmd.Parameters.AddWithValue("@NumeroDocumento", Ins.NumeroDocumentoIdentidad);
                cmd.Parameters.AddWithValue("@NombreCompleto", Ins.Nombres);
                cmd.Parameters.AddWithValue("@Apellido1", Ins.Apellido1);
                cmd.Parameters.AddWithValue("@Apellido2", Ins.Apellido2);
                cmd.Parameters.AddWithValue("@razonSocial", Ins.RazonSocial);
                cmd.Parameters.AddWithValue("@Celular", Ins.Celular);
                cmd.Parameters.AddWithValue("@Email", Ins.Email);
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

        public Boolean EditarInspector(EntInspector Ins)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarInspector", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumeroEmpledo",Ins.NumeroEmpleado);
                cmd.Parameters.AddWithValue("@Estado", Ins.Estado);
                cmd.Parameters.AddWithValue("@TipoDocumento", Ins.TipoDocumento);
                cmd.Parameters.AddWithValue("@NumeroDocumento", Ins.NumeroDocumentoIdentidad);
                cmd.Parameters.AddWithValue("@NombreCompleto", Ins.Nombres);
                cmd.Parameters.AddWithValue("@Apellido1", Ins.Apellido1);
                cmd.Parameters.AddWithValue("@Apellido2", Ins.Apellido2);
                cmd.Parameters.AddWithValue("@razonSocial", Ins.RazonSocial);
                cmd.Parameters.AddWithValue("@Celular", Ins.Celular);
                cmd.Parameters.AddWithValue("@Email", Ins.Email);
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

        public Boolean InhabilitarInspector(EntInspector Ins)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaInspector", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumeroEmpledo", Ins.NumeroEmpleado);
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
        public List<EntInspector> BuscarInspector(EntInspector Ins)
        {
            SqlCommand cmd = null;
            List<EntInspector> lista = new List<EntInspector>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumeroEmpledo", Ins.NumeroEmpleado);
                cn.Open();
             
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntInspector Cli = new EntInspector();
                    Cli.NumeroEmpleado = Convert.ToInt32(dr["NumeroEmpledo"]);
                    Cli.Estado = dr["Estado"].ToString();
                    Cli.TipoDocumento = dr["TipoDocumento"].ToString();
                    Cli.NumeroDocumentoIdentidad = Convert.ToInt32(dr["NumeroDocumento"]);
                    Cli.Nombres = dr["NombreCompleto"].ToString();
                    Cli.Apellido1 = dr["Apellido1"].ToString();
                    Cli.Apellido2 = dr["Apellido2"].ToString();
                    Cli.Celular = Convert.ToInt32(dr["Celular"]);
                    Cli.Email = dr["Email"].ToString();
                    Cli.RazonSocial = dr["razonSocial"].ToString();

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
