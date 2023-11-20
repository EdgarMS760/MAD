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
    public class Historial
    {
        private string? connectionString;
        public Historial()
        {
            if (Program.Configuration != null)
            {
                connectionString = Program.Configuration.GetConnectionString("DefaultConnection");
            }
        }
        public List<ObtenerHistorialCompleto> ObtenerHistorialCompleto(string correoElectronico)
        {
            List<ObtenerHistorialCompleto> historialCompletoList = new List<ObtenerHistorialCompleto>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("ObtenerHistorialCompleto", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@CorreoElectronico", correoElectronico);

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ObtenerHistorialCompleto historialCompleto = new ObtenerHistorialCompleto();

                            historialCompleto.Palabras = reader["Palabra"] == DBNull.Value ? null : reader["Palabra"].ToString();
                            historialCompleto.FechaYHora = reader["FechaHora"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["FechaHora"]);
                            historialCompleto.Libro = reader["Libro"] == DBNull.Value ? null : reader["Libro"].ToString();
                            historialCompleto.Capitulo = reader["Capitulo"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["Capitulo"]);
                            historialCompleto.Versiculo = reader["Versiculos"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["Versiculos"]);


                            historialCompletoList.Add(historialCompleto);
                        }
                    }
                }
            }

            return historialCompletoList;
        }
        public void EliminarHistorialPorFecha(DateTime fechaRegistro)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("EliminarHistorialPorFecha", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@FechaRegistro", fechaRegistro);

                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
        public void EliminarHistorialPorUsuario(string correoUsuario)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("EliminarHistorialPorUsuario", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@CorreoUsuario", correoUsuario);

                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

    }
}
