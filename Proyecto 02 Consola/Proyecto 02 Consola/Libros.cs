using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_02_Consola
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public string Genero { get; set; }
        public bool Disponible { get; set; } = true;

        public Libro(string titulo, string autor, string isbn, string genero)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            Genero = genero;
        }
    }
}
