using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DaoMetodoPago
    {
        #region sigleton
        private static readonly DaoMetodoPago _instancia = new DaoMetodoPago();
        public static DaoMetodoPago Instancia { get { return _instancia; } }
        #endregion singleton

        public List<EntMetodoPago> ListarMetodoPago()
        {
            SqlCommand cmd = null;
            List<EntMetodoPago> lista = new List<EntMetodoPago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntMetodoPago Cli = new EntMetodoPago();
                    Cli.IdMetodoPago = Convert.ToInt32(dr["IdMetodoP"]);
                    Cli.NombreMetodoP= dr["NombreMP"].ToString();
                    Cli.Descripcion = dr["Descripcion"].ToString();
                    Cli.TipoPago = dr["TipoPago"].ToString();
                    Cli.Credito_Debito= dr["CreditoDebito"].ToString();
                    Cli.TipoTarjeta= dr["TipoTarjeta"].ToString();
                    Cli.TipoMoneda = dr["TipoMoneda"].ToString();
                    Cli.TasaComision= int.Parse(dr["TazaComision"].ToString());
                    Cli.Estado = dr["Estado"].ToString();

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

        public Boolean InsertarMetodoPago(EntMetodoPago MP)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NombreMP", MP.NombreMetodoP);
                cmd.Parameters.AddWithValue("@Descripcion", MP.Descripcion);
                cmd.Parameters.AddWithValue("@TipoPago", MP.TipoPago);
                cmd.Parameters.AddWithValue("@CreditoDebito", MP.Credito_Debito);
                cmd.Parameters.AddWithValue("@TipoTarjeta", MP.TipoTarjeta);
                cmd.Parameters.AddWithValue("@TipoMoneda", MP.TipoMoneda);
                cmd.Parameters.AddWithValue("@TazaComision", MP.TasaComision);
                cmd.Parameters.AddWithValue("@Estado", MP.Estado);

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
        public Boolean EditarMetodoPago(EntMetodoPago MP)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdMetodoP", MP.IdMetodoPago);
                cmd.Parameters.AddWithValue("@NombreMP", MP.NombreMetodoP);
                cmd.Parameters.AddWithValue("@Descripcion", MP.Descripcion);
                cmd.Parameters.AddWithValue("@TipoPago", MP.TipoPago);
                cmd.Parameters.AddWithValue("@CreditoDebito", MP.Credito_Debito);
                cmd.Parameters.AddWithValue("@TipoTarjeta", MP.TipoTarjeta);
                cmd.Parameters.AddWithValue("@TipoMoneda", MP.TipoMoneda);
                cmd.Parameters.AddWithValue("@TazaComision", MP.TasaComision);
                cmd.Parameters.AddWithValue("@Estado", MP.Estado);

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

        public Boolean DeshabilitarMetodoPago(EntMetodoPago Ins)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdMetodoP", Ins.IdMetodoPago);
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
    }
}
