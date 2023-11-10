using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAD.Services
{
    public class Usuarios
    {
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
    }
}
