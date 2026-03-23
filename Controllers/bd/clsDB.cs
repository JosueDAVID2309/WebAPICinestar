using System.Data;
using System.Data.SqlClient;
namespace WebAPICinestar.Controllers.bd
{
    public class clsDB
    {
        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True; Initial Catalog=Cinestar");

        public SqlConnection AbrirConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexion: " + ex.Message);
                throw;
            }
        }

        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
    }
}
