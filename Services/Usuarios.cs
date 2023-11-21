using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MAD.Services
{
    public class Usuarios
    {
        private static Usuarios instance;
        public static Usuarios GetInstance()
        {
            if (instance == null)
            {
                instance = new Usuarios();
            }
            return instance;
        }

        private string? connectionString;
        public Usuarios()
        {
            if (Program.Configuration != null)
            {
                connectionString = Program.Configuration.GetConnectionString("DefaultConnection");
            }
        }
        public void AltaUsuario(string correoElectronico, string contrasena)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("sp_AltaUsuario", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@Correo", correoElectronico);
                    sqlCommand.Parameters.AddWithValue("@ContrasenaActual", contrasena);

                    // Agregar parámetro de salida para manejar el caso de usuario existente
                    SqlParameter outputParameter = new SqlParameter("@UsuarioExistente", SqlDbType.Bit);
                    outputParameter.Direction = ParameterDirection.Output;
                    sqlCommand.Parameters.Add(outputParameter);

                    sqlCommand.ExecuteNonQuery();

                    // Obtener el valor de la variable de salida
                    bool usuarioExistente = Convert.ToBoolean(outputParameter.Value);

                    if (usuarioExistente)
                    {
                        // El usuario ya existe, puedes manejar la lógica de manejo de errores o mensajes de usuario aquí
                        MessageBox.Show("El usuario ya está registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // El usuario se ha registrado con éxito
                        MessageBox.Show("Usuario registrado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                sqlConnection.Close();
            }
        }
        public void ActualizaInfoPersonal(string correo, char genero, string nombreCompleto, DateTime fechaNacimiento)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("sp_ActualizaInfoPersonal", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@Correo", correo);
                    sqlCommand.Parameters.AddWithValue("@Genero", genero);
                    sqlCommand.Parameters.AddWithValue("@NombreCompleto", nombreCompleto);
                    sqlCommand.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);

                    sqlCommand.ExecuteNonQuery();

                    SesionUsuario.NombreCom = nombreCompleto;
                    SesionUsuario.Genero = genero;
                    SesionUsuario.FechaNac = fechaNacimiento;

                    MessageBox.Show("Información personal actualizada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void ObtenerInfoUsuario(string correoElectronico)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("ObtenerInfoUsuario", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    // Parámetros de entrada
                    sqlCommand.Parameters.AddWithValue("@CorreoElectronico", SesionUsuario.CorreoElectronico);

                    // Parámetros de salida
                    sqlCommand.Parameters.Add("@NombreCompleto", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                    sqlCommand.Parameters.Add("@Genero", SqlDbType.Char, 1).Direction = ParameterDirection.Output;
                    sqlCommand.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Direction = ParameterDirection.Output;
                    sqlCommand.Parameters.Add("@Tipo", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    sqlCommand.Parameters.Add("@Estatus", SqlDbType.Char, 15).Direction = ParameterDirection.Output;

                    sqlCommand.ExecuteNonQuery();

                    // Verificar si los valores son DBNull antes de asignarlos a las propiedades de SesionUsuario
                    SesionUsuario.NombreCom = (sqlCommand.Parameters["@NombreCompleto"].Value != DBNull.Value) ? sqlCommand.Parameters["@NombreCompleto"].Value.ToString() : null;
                    SesionUsuario.Genero = (sqlCommand.Parameters["@Genero"].Value != DBNull.Value) ? Convert.ToChar(sqlCommand.Parameters["@Genero"].Value) : default(char);
                    SesionUsuario.FechaNac = (sqlCommand.Parameters["@FechaNacimiento"].Value != DBNull.Value) ? (DateTime)sqlCommand.Parameters["@FechaNacimiento"].Value : DateTime.Now;
                    SesionUsuario.Tipo = (sqlCommand.Parameters["@Tipo"].Value != DBNull.Value) ? Convert.ToBoolean(sqlCommand.Parameters["@Tipo"].Value) : default(bool);
                    SesionUsuario.Estatus = (sqlCommand.Parameters["@Estatus"].Value != DBNull.Value) ? sqlCommand.Parameters["@Estatus"].Value.ToString().Trim() : null;
                }
            }
        }
        public void CambiarContrasena(string CorreoUsuario, string ContrasenaActual, string NuevaContrasena)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("sp_CambiarContrasena", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@CorreoUsu", CorreoUsuario);
                    sqlCommand.Parameters.AddWithValue("@ContrasenaActual", ContrasenaActual);
                    sqlCommand.Parameters.AddWithValue("@NuevaContrasena", NuevaContrasena);

                    // Agregar parámetro de salida para la operación exitosa
                    SqlParameter operacionExitosaParam = new SqlParameter("@OperacionExitosa", SqlDbType.Bit);
                    operacionExitosaParam.Direction = ParameterDirection.Output;
                    sqlCommand.Parameters.Add(operacionExitosaParam);

                    sqlCommand.ExecuteNonQuery();

                    // Obtener el resultado de la operación exitosa
                    bool operacionExitosa = (bool)operacionExitosaParam.Value;

                    if (operacionExitosa)
                    {
                        // Operación exitosa: actualizar la información en la sesión del usuario
                        SesionUsuario.Contrasena = NuevaContrasena;

                        MessageBox.Show("Contraseña actualizada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Operación no exitosa: mostrar un mensaje de error
                        MessageBox.Show("Error: La nueva contraseña es igual a alguna de las ultimas dos o a la actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public void CambiarCorreoElectronico(string correoActual, string nuevoCorreo)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("sp_CambiarCorreoElectronico", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@CorreoActual", correoActual);
                    sqlCommand.Parameters.AddWithValue("@NuevoCorreo", nuevoCorreo);

                    sqlCommand.ExecuteNonQuery();

                    // Actualizar la información en la sesión del usuario
                    SesionUsuario.CorreoElectronico = nuevoCorreo;

                    MessageBox.Show("Correo electrónico actualizado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void BajaUsuario(string CorreoUsu)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("sp_BajaUsuario", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@Correo", CorreoUsu);

                    sqlCommand.ExecuteNonQuery();

                    // Puedes eliminar esta línea si no necesitas actualizar la sesión del usuario en este punto
                    // SesionUsuario.CorreoElectronico = nuevoCorreo;

                    MessageBox.Show("Usuario dado de baja con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public bool BuscarUsuario(string? email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                SqlCommand command = new SqlCommand("SELECT CorreoElectronico,Estado,AdminOrNot FROM dbo.BuscarUsuario(@correoElectronico)", connection);
                command.Parameters.AddWithValue("@CorreoElectronico", email);

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        // Usuario encontrado
                        DataRow row = dataTable.Rows[0];
                        gestionUsuariosDto.email = row["CorreoElectronico"].ToString();
                        gestionUsuariosDto.estado = row["Estado"].ToString().Trim();
                        gestionUsuariosDto.adminOrNot = (bool)row["AdminOrNot"];
                        connection.Close();
                        return true;

                    }
                    else
                    {
                        MessageBox.Show("no hay ningun usuario con ese correo electronico");
                        connection.Close();
                        return false;
                    }
                }



            }
        }

        public void addTemporalPass(string temporalPass, string email)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("addPassTemporal", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@temporalPass", temporalPass);
                    command.Parameters.AddWithValue("@CorreoElectronico", email ?? (object)DBNull.Value);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
        public void updAdmin(string email, byte accion)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("updAdmin", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@accion", accion);
                    command.Parameters.AddWithValue("@CorreoElectronico", email ?? (object)DBNull.Value);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public List<inactivosDto> viewInactivos()
        {
            List<inactivosDto> usuariosInactivos = new List<inactivosDto>();
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand comando = new SqlCommand("ObtenerUsuariosInactivos", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        conexion.Open();
                        using (SqlDataReader lector = comando.ExecuteReader())
                        {

                            while (lector.Read())
                            {
                                inactivosDto usuario = new inactivosDto
                                {
                                    EMAIL = lector["CorreoElectronico"].ToString(),
                                    ESTADO = lector["Estado"].ToString().Trim()
                                };
                                usuariosInactivos.Add(usuario);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener usuarios inactivos: " + ex.Message);
                }

            }
            return usuariosInactivos;
        }
    }
}
