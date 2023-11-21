using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAD.Services
{
    public class LoginServices
    {
        private static LoginServices instance;
        private Usuarios _UsuarioSrvs = Usuarios.GetInstance();


        public static LoginServices GetInstance()
        {
            if (instance == null)
            {
                instance = new LoginServices();
            }
            return instance;
        }

        private string? connectionString;
        public LoginServices()
        {
            if (Program.Configuration != null)
            {
                connectionString = Program.Configuration.GetConnectionString("DefaultConnection");
            }
        }

        public int autenticacion(string email, string pass)
        {
            if (connectionString == null) { return 4; }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT dbo.AutenticarUsuario(@Correo, @Contrasena)", connection);
                command.Parameters.AddWithValue("@Correo", email);
                command.Parameters.AddWithValue("@Contrasena", pass);

                int autenticado = (int)command.ExecuteScalar();

                switch (autenticado)
                {
                    case 1:
                        {
                            SesionUsuario.CorreoElectronico = email;
                            SesionUsuario.Contrasena = pass;
                            _UsuarioSrvs.ObtenerInfoUsuario(SesionUsuario.CorreoElectronico);
                            _UsuarioSrvs.ReiniciarIntentosFallidos(email);
                        }
                        break;
                    case 2:
                        {
                            MessageBox.Show("contraseña incorrecta", "Error de autenticacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // Incrementar el contador de intentos fallidos
                            _UsuarioSrvs.IncrementarIntentosFallidos(email);
                            int intentosFallidos = _UsuarioSrvs.ObtenerIntentosFallidos(email);
                            if (intentosFallidos >= 3)
                            {
                                // Desactivar al usuario después de tres intentos fallidos
                                _UsuarioSrvs.DesactivarUsuario(email);
                            }
                        }
                        break;
                    case 3:
                        {
                            MessageBox.Show("correo electronico incorrecto", "Error de autenticacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    default:
                        break;
                }
             
                connection.Close();
                return autenticado;

            }

        }
    }
}
