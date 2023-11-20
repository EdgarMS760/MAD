using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAD.Dtos
{
    internal class DatosHistorial
    {
    }
    public class ObtenerHistorialCompleto
    {
        public string? Palabras { get; set; }
        public DateTime FechaYHora { get; set; }
        public string? Libro { get; set; }
        public int? Capitulo { get; set; }
        public int? Versiculo { get; set; }
    }

}
