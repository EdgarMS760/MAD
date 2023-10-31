using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAD.Services
{
    public class Login
    {
        private string? connectionString;
        public Login()
        { 
            if(Program.Configuration != null) 
            {
                connectionString = Program.Configuration.GetConnectionString("DefaultConnection");            
            }
        }

        public bool SelectUser(string email, string pass)
        {
            if (connectionString == null) { return false; }
            using (SqlConnection sqlConnection = new SqlConnection(connectionString)) 
            { 
                sqlConnection.Open();
                string query = "SELECT COUNT(*) FROM Contrasena WHERE CorreoElectronico = @email AND ContrasenaActual = @pass";

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@email", email);
                    sqlCommand.Parameters.AddWithValue("@pass", pass);

                    int count = (int)sqlCommand.ExecuteScalar();
                    sqlConnection.Close();
                    // Si count es mayor que 0, significa que se encontró un usuario con las credenciales proporcionadas
                    return count > 0;
                }
            }
        }
    }
}
