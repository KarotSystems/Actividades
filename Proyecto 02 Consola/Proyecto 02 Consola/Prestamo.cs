using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_02_Consola
{
    public class Prestamo
    {
        public Libro LibroPrestado { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; } = null;

        public Prestamo(Libro libro, Usuario usuario)
        {
            LibroPrestado = libro;
            Usuario = usuario;
            FechaPrestamo = DateTime.Now;
        }
    }
}
