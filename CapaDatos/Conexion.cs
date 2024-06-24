using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }
        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=BDDiesa;User ID=Eduardo;Password=Erod050289;Integrated Security=true";
            return cn;
        }
    }
}
