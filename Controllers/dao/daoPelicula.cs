using System.Data.SqlClient;
using WebAPICinestar.Models;
using WebAPICinestar.Controllers.bd;

namespace WebAPICinestar.Controllers.dao
{
    public class daoPelicula
    {
        clsDB conexionDB = new clsDB();
        SqlCommand cmd = new SqlCommand();

        public List<Pelicula> getPeliculas(int id)
        {
            List<Pelicula> listaPeliculas = new List<Pelicula>();
            cmd.Connection = conexionDB.AbrirConexion();
            cmd.CommandText = "sp_getPeliculas";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@idEstado", id );
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Pelicula pelicula = new Pelicula();
                pelicula.Id = reader.GetInt32(0);
                pelicula.Titulo = reader.GetString(1);
                pelicula.Link = reader.GetString(2);
                pelicula.Sinopsis = reader.GetString(3);

                listaPeliculas.Add(pelicula);
            }
            reader.Close();
            cmd.Dispose();
            conexionDB.CerrarConexion();
            return listaPeliculas;
        }

        public Pelicula getPelicula(int idcine)
        {
            Pelicula pelicula = new Pelicula();
            cmd.Connection = conexionDB.AbrirConexion();
            cmd.CommandText = "sp_getPelicula";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id",idcine);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                pelicula.Id = reader.GetInt32(0);
                pelicula.Titulo = reader.GetString(1);
                pelicula.FechaEstreno = reader.GetString(2);
                pelicula.Director = reader.GetString(3);
                pelicula.Generos = reader.GetString(4);
                pelicula.IdClasificacion = reader.GetInt32(5);
                pelicula.IdEstado = reader.GetInt32(6);
                pelicula.Duracion = reader.GetString(7);
                pelicula.Link = reader.GetString(8);
                pelicula.Reparto = reader.GetString(9);
                pelicula.Sinopsis = reader.GetString(10);
                pelicula.Geneross = reader.GetString(11);
            }

            reader.Close();
            cmd.Dispose();
            conexionDB.CerrarConexion();
            return pelicula;
            
        }


    }
}
