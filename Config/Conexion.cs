
using System.Data.SqlClient;

namespace PubsCRUD.Config
{
    public class Conexion
    {
        private readonly string cadena =
            "server=.\\SQLEXPRESS;" +
            "Database=pubs;" +
            "User Id=cris;" +
            "Password=12345;" +
            "Encrypt=True;" +
            "TrustServerCertificate=True;";

        public static SqlConnection ObtenerConexion()
        {
            Conexion conexion = new Conexion();
            return new SqlConnection(conexion.cadena);
        }
    }
}
