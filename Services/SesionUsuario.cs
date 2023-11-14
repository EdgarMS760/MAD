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
        // Agrega otras propiedades según sea necesario
    }
}
