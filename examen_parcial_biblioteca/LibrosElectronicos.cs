using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace examen_parcial_biblioteca
{
    public class LibroElectronico : Libro
    {
        public string Formato { get; set; }
        public string Tamanio { get; set; }

        public LibroElectronico()
        {
            Formato = string.Empty;
            Tamanio = string.Empty;
        }
    }
}
