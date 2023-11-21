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
    public static class SesionUsuario
    {
        public static string CorreoElectronico { get; set; }
        public static string Contrasena { get; set; }
        public static string NombreCom { get; set; }
        public static char Genero { get; set; }
        public static DateTime FechaNac { get; set; }
        public static bool Tipo { get; set; }
        public static string Estatus { get; set; }
    }

    public static class gestionUsuariosDto
    {
        public static string email { get; set; }
        public static bool adminOrNot { get; set; }
        public static string estado { get; set; }
    }

    public class inactivosDto
    {
        public  string EMAIL { get; set; }
        public  string ESTADO { get; set; }
    }
}
