using MAD.Dtos;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MAD.Services
{
    public class Favoritos
    {
        private string? connectionString;
        public Favoritos()
        {
            if (Program.Configuration != null)
            {
                connectionString = Program.Configuration.GetConnectionString("DefaultConnection");
            }
        }
        public List<ObtenerFavoritos> ObtenerFavs(string correoElectronico)
        {
            List<ObtenerFavoritos> favoritosList = new List<ObtenerFavoritos>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("ObtenerFavoritos", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@CorreoElectronico", correoElectronico);

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ObtenerFavoritos favorito = new ObtenerFavoritos();

                            favorito.Libro = reader["LibroFav"] == DBNull.Value ? null : reader["LibroFav"].ToString();
                            favorito.Capitulo = reader["CapituloFav"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["CapituloFav"]);
                            favorito.Versiculo = reader["VersiculosFav"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["VersiculosFav"]);

                            favoritosList.Add(favorito);
                        }
                    }
                }
            }

            return favoritosList;
        }
        public void EliminarFavorito(string correoElectronico, string libro, int? capitulo, int? versiculo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("EliminarFavorito", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@CorreoElectronico", correoElectronico);
                    sqlCommand.Parameters.AddWithValue("@LibroFav", libro);
                    sqlCommand.Parameters.AddWithValue("@CapituloFav", capitulo ?? (object)DBNull.Value);
                    sqlCommand.Parameters.AddWithValue("@VersiculosFav", versiculo ?? (object)DBNull.Value);

                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

    }
}
