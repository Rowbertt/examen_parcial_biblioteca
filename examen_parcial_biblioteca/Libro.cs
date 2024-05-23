using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace examen_parcial_biblioteca
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public string AnioPublicacion { get; set; }

        public Libro()
        {
            Titulo = string.Empty;
            Autor = string.Empty;
            Genero = string.Empty;
            AnioPublicacion = string.Empty;
        }
    }
}
