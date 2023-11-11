using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAD.Dtos
{
    public class SearchDtos
    {

    }
    public class IdiomaDto
    {
        public string? nombre { get; set; }
        public int id_Idioma { get; set; }
    }

    public class LibroDto
    {
        public string? nombre { get; set; }
        public int id_Libro { get; set; }
    }
    public class VersionDto
    {
        public string? nombre { get; set; }
        public int id_Version { get; set; }
    }

    public class TestamentoDto
    {
        public string? nombre { get; set; }
        public int id_Testamento { get; set; }
    }
}
