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
    public class HomeServices
    {
        private string? connectionString;
        public HomeServices()
        {
            if (Program.Configuration != null)
            {
                connectionString = Program.Configuration.GetConnectionString("DefaultConnection");
            }
        }
        public List<IdiomaDto> ObtenerIdiomas()
        {
            List<IdiomaDto> idiomas = new List<IdiomaDto>();
            // Consulta SQL para obtener los idiomas

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("ObtenerIdiomas", connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            IdiomaDto idiomaDto = new IdiomaDto
                            {
                                nombre = reader["Nombre"].ToString(),
                                id_Idioma = (int)(short)reader["Id_Idioma"]
                            };
                            idiomas.Add(idiomaDto);
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        connection.Close();
                        MessageBox.Show("Error al obtener los idiomas: " + ex.Message);
                    }
                }
            }

            return idiomas;
        }
        public List<LibroDto> ObtenerLibros(int id_idioma)
        {
            List<LibroDto> libros = new List<LibroDto>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("ObtenerLibrosPorIdioma", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        command.Parameters.AddWithValue("@Id_Idioma", id_idioma);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            LibroDto libroDto = new LibroDto
                            {
                                nombre = reader["Nombre"].ToString(),
                                id_Libro = (int)(short)reader["Id_Libro"]
                            };
                            libros.Add(libroDto);
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        connection.Close();
                        MessageBox.Show("Error al obtener los idiomas: " + ex.Message);
                    }
                }
            }

            return libros;
        }
        public List<VersionDto> ObtenerVersion(int id_idioma)
        {
            List<VersionDto> versiones = new List<VersionDto>();
           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("ObtenerVersionesPorIdioma", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        command.Parameters.AddWithValue("@Id_Idioma", id_idioma);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            VersionDto versionDto = new VersionDto
                            {
                                nombre = reader["NombreVersion"].ToString(),
                                id_Version = (short)reader["Id_Version"]
                            };
                            versiones.Add(versionDto);
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        connection.Close();
                        MessageBox.Show("Error al obtener las versiones: " + ex.Message);
                    }
                }
            }

            return versiones;
        }
        public List<TestamentoDto> ObtenerTestamento(int id_idioma)
        {
            List<TestamentoDto> testamentos = new List<TestamentoDto>();
       
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("ObtenerTestamentosPorIdioma", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        command.Parameters.AddWithValue("@Id_Idioma", id_idioma);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            TestamentoDto testamentoDto = new TestamentoDto
                            {
                                nombre = reader["Nombre"].ToString(),
                                id_Testamento = (short)reader["Id_Testamento"]
                            };
                            testamentos.Add(testamentoDto);
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        connection.Close();
                        MessageBox.Show("Error al obtener los testamentos: " + ex.Message);
                    }
                }
            }

            return testamentos;
        }
        public List<LibroDto> ObtenerLibroPorTestamento(int id_testamento)
        {
            List<LibroDto> libros = new List<LibroDto>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("ObtenerLibrosPorTestamento", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        command.Parameters.AddWithValue("@Id_Testamento", id_testamento);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            LibroDto libroDto = new LibroDto
                            {
                                nombre = reader["Nombre"].ToString(),
                                id_Libro = (int)(short)reader["Id_Libro"]
                            };
                            libros.Add(libroDto);
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        connection.Close();
                        MessageBox.Show("Error al obtener los libros: " + ex.Message);
                    }
                }
            }

            return libros;
        }
        public List<VersiculoDto> BuscarVersiculos(string palabrasClave, int? idVersion, int? idTestamento, int? idLibro)
        {
            List<VersiculoDto> versiculos = new List<VersiculoDto>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("ExecuteBuscarVersiculos", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PalabrasClave", palabrasClave);
                    command.Parameters.AddWithValue("@ID_version", idVersion ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Id_Testamento", idTestamento ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Id_libro", idLibro ?? (object)DBNull.Value);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            VersiculoDto versiculo = new VersiculoDto
                            {
                                texto = reader["Texto"].ToString(),
                                nombreLibro = reader["NombreLibro"].ToString(),
                                numeroCap = (byte)reader["NumeroCap"],
                                numeroVers = (byte)reader["NumeroVers"]
                            };
                            versiculos.Add(versiculo);
                        }
                        connection.Close();
                    }
                }
            }
            
            return versiculos;
        }

        public List<FullChapterDto> fullChapter(string nombreLibro, int numCap)
        {
            List<FullChapterDto> chapter = new List<FullChapterDto>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("ObtenerCapitulo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        
                        command.Parameters.AddWithValue("@NombreLibro", nombreLibro);
                        command.Parameters.AddWithValue("@NumeroCap", numCap);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            FullChapterDto chapterDto = new FullChapterDto
                            {
                                numeroCap=numCap,
                                nombreLibro = reader["NombreLibro"].ToString(),
                                numeroVers = (byte)reader["NumeroVers"],
                                texto = reader["Texto"].ToString()
                            };
                            chapter.Add(chapterDto);
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        connection.Close();
                        MessageBox.Show("Error al obtener el capitulo: " + ex.Message);
                    }
                }
            }

            return chapter;
        }
    }
}
