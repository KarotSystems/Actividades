using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2
{
    public class Prestamo
    {
        public Lector Lector { get; set; }
        public Libro Libro { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; }

        public Prestamo(Lector lector, Libro libro)
        {
            Lector = lector;
            Libro = libro;
            FechaPrestamo = DateTime.Now;
            FechaDevolucion = null;
        }
        public void RegistrarDevolucion()
        {
            FechaDevolucion = DateTime.Now;
            Libro.Disponible = true;
            Console.WriteLine($"Libro {Libro.Titulo} devuelto correctamente.");
        }
        public void MostrarInformacion()
        {
            Console.WriteLine($"Libro: {Libro.Titulo}, Prestado a: {Lector.Usuario}, Fecha de Préstamo: {FechaPrestamo}, Fecha de Devolución: {(FechaDevolucion.HasValue ? FechaDevolucion.Value.ToString() : "No devuelto")}");
        }
    }
}
