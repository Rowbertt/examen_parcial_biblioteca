using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace examen_parcial_biblioteca
{
    public class Revista : Libro
    {
        public string Volumen { get; set; }
        public string NumEjemplar { get; set; }

        public Revista()
        {
            Volumen = string.Empty;
            NumEjemplar = string.Empty;
        }
    }
}
