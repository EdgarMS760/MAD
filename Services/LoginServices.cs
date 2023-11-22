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

                            _UsuarioSrvs.IncrementarIntentosFallidos(email);
                            int intentosFallidos = _UsuarioSrvs.ObtenerIntentosFallidos(email);
                            if (intentosFallidos >= 3)
                            {

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
        public int autenticacionPassTemporal(string email, string pass)
        {
            if (connectionString == null) { return 4; }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT dbo.AutenticarUsuarioPassTemporal(@Correo, @Contrasena)", connection);
                command.Parameters.AddWithValue("@Correo", email);
                command.Parameters.AddWithValue("@Contrasena", pass);

                int autenticado = (int)command.ExecuteScalar();

                switch (autenticado)
                {
                    case 1:
                        {
                            MessageBox.Show("FAVOR DE CAMBIAR SU CONTRASEÑA DESDE EL PANEL DE CONFIGURACION ", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            SesionUsuario.CorreoElectronico = email;
                            SesionUsuario.Contrasena = pass;
                            _UsuarioSrvs.ObtenerInfoUsuario(SesionUsuario.CorreoElectronico);
                            _UsuarioSrvs.ReiniciarIntentosFallidos(email);
                        }
                        break;
                    case 2:
                        {
                            MessageBox.Show("contraseña temporal incorrecta", "Error de autenticacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
     
        public string validacionEstado(string email)
        {
            string resultado = null;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("ProcViewEstadoUsuario", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@CorreoElectronico", email);
                    object result = sqlCommand.ExecuteScalar();
                    if (result != null)
                    {
                         resultado = result.ToString().Trim();
                    }
                    sqlCommand.ExecuteNonQuery();
                }
            }
            return resultado;
        }
        public void loginPassTemporal(string email,string pass)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("loginPassTemporal", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@CorreoElectronico", email);
                    sqlCommand.Parameters.AddWithValue("@Contrasena", pass);
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
