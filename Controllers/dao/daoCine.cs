using System.Data.SqlClient;
using WebAPICinestar.Models;
using WebAPICinestar.DTO;
using WebAPICinestar.Controllers.bd;

namespace WebAPICinestar.Controllers.dao
{
    public class daoCine
    {
        clsDB conexionDB = new clsDB();
        SqlCommand cmd = new SqlCommand();

        public List<Cine> getCines()
        {
            List<Cine> listaCines = new List<Cine>();
            cmd.Connection = conexionDB.AbrirConexion();
            cmd.CommandText = "sp_getCines";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Cine cine = new Cine();
                cine.idCine = reader.GetInt32(0);
                cine.RazonSocial = reader.GetString(1);
                cine.Salas = reader.GetInt32(2);
                cine.idDistrito = reader.GetInt32(3);
                cine.Direccion = reader.GetString(4);
                cine.Telefonos = reader.GetString(5);
                cine.Detalle = reader.GetString(6);

                listaCines.Add(cine);
            }
            reader.Close();
            cmd.Dispose();
            conexionDB.CerrarConexion();

            return listaCines;
        }

        public Cine getCine(int idCine)
        {
            Cine cine = new Cine();
            cmd.Connection = conexionDB.AbrirConexion();
            cmd.CommandText = "sp_getCine";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", idCine);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cine.idCine = reader.GetInt32(0);
                cine.RazonSocial = reader.GetString(1);
                cine.Salas = reader.GetInt32(2);
                cine.idDistrito = reader.GetInt32(3);
                cine.Direccion = reader.GetString(4);
                cine.Telefonos = reader.GetString(5);
                cine.Detalle = reader.GetString(6);

            }
            reader.Close();
            cmd.Dispose();
            conexionDB.CerrarConexion();

            return cine;
        }

        public List<CinePeliculaDTO> getCinePeliculas(int idCine)
        {
            List<CinePeliculaDTO> peliculaCines = new List<CinePeliculaDTO>();
            cmd.Connection = conexionDB.AbrirConexion();
            cmd.CommandText = "sp_getCinePeliculas";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@idCine", idCine);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CinePeliculaDTO pCines = new CinePeliculaDTO();
                pCines.Pelicula = reader.GetString(0);
                pCines.Horarios = reader.GetString(1);

                peliculaCines.Add(pCines);
            }
            reader.Close();
            cmd.Dispose();
            conexionDB.CerrarConexion();

            return peliculaCines;
        }


        public List<CineTarifaDTO> getCineTarifas(int idCine)
        {
            List<CineTarifaDTO> tarifaCines = new List<CineTarifaDTO>();
            cmd.Connection = conexionDB.AbrirConexion();
            cmd.CommandText = "sp_getCineTarifas";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@idCine", idCine);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CineTarifaDTO tCines = new CineTarifaDTO();   
                tCines.DiasSemana = reader.GetString(0);
                tCines.Precios = reader.GetString(1);

                tarifaCines.Add(tCines);
            }
            reader.Close();
            cmd.Dispose();
            conexionDB.CerrarConexion();

            return tarifaCines;
        }


    }
}
