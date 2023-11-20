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
            if(Program.Configuration != null) 
            {
                connectionString = Program.Configuration.GetConnectionString("DefaultConnection");            
            }
        }

        public bool autenticacion(string email, string pass)
        {
            if (connectionString == null) { return false; }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT dbo.AutenticarUsuario(@Correo, @Contrasena)", connection);
                command.Parameters.AddWithValue("@Correo", email);
                command.Parameters.AddWithValue("@Contrasena", pass);

                bool autenticado = (bool)command.ExecuteScalar();

                if (autenticado)
                {
                    SesionUsuario.CorreoElectronico = email;
                    SesionUsuario.Contrasena = pass;
                    _UsuarioSrvs.ObtenerInfoPersonal(SesionUsuario.CorreoElectronico);
                    _UsuarioSrvs.ObtenerTipoYEstado(SesionUsuario.CorreoElectronico);
                }
                connection.Close();
                return autenticado;

            }

        }
    }
}
