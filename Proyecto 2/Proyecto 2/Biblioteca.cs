using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2
{
    public class Biblioteca
    {
        private List<Libro> inventario = new List<Libro>();
        private List<Usuario> usuarios = new List<Usuario>();
        private List<Prestamo> prestamos = new List<Prestamo>();
        private Queue<Lector> listaDeEspera = new Queue<Lector>();
        public void AgregarLibro(List<Libro> inventario, string titulo, string autor, string isbn, string genero)
        {
            if (!inventario.Exists(libro => libro.ISBN == isbn))
            {
                inventario.Add(new Libro(titulo, autor, isbn, genero));
                MessageBox.Show($"Libro {titulo} agregado correctamente.", "Informacion", MessageBoxButtons.OK);
            }
            else
            {
                Console.WriteLine("Error: ISBN ya registrado.");
            }
        }

        public void EliminarLibro(List<Libro> inventario, string isbn)
        {
            var libro = inventario.Find(l => l.ISBN == isbn);
            if (libro != null)
            {
                inventario.Remove(libro);
                Console.WriteLine($"Libro con ISBN {isbn} eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("Error: Libro no encontrado.");
            }
        }
        public void EditarLibro(List<Libro> inventario, string isbn, string nuevoTitulo, string nuevoAutor, string nuevoGenero)
        {
            var libro = inventario.Find(l => l.ISBN == isbn);
            if (libro != null)
            {
                libro.Titulo = nuevoTitulo;
                libro.Autor = nuevoAutor;
                libro.Genero = nuevoGenero;
                Console.WriteLine("Libro editado correctamente.");
            }
            else
            {
                Console.WriteLine("Error: Libro no encontrado.");
            }
        }
        public void SolicitarPrestamo(Lector lector, string isbn)
        {
            var libro = inventario.Find(l => l.ISBN == isbn);
            if (libro != null && libro.Disponible)
            {
                libro.Disponible = false;
                prestamos.Add(new Prestamo(lector, libro));
                Console.WriteLine($"Préstamo del libro {libro.Titulo} registrado.");
            }
            else if (libro != null && !libro.Disponible)
            {
                listaDeEspera.Enqueue(lector);
                Console.WriteLine($"Libro {libro.Titulo} no disponible. {lector.Usuario} añadido a la lista de espera.");
            }
            else
            {
                Console.WriteLine("Libro no encontrado.");
            }
        }
        public void DevolverLibro(Lector lector, string isbn)
        {
            var prestamo = prestamos.Find(p => p.Libro.ISBN == isbn && p.Lector == lector);
            if (prestamo != null)
            {
                prestamo.RegistrarDevolucion();
                prestamos.Remove(prestamo);

                // Si hay alguien en la lista de espera para este libro, ofrecerlo
                if (listaDeEspera.Count > 0)
                {
                    var siguienteLector = listaDeEspera.Dequeue();
                    SolicitarPrestamo(siguienteLector, isbn);
                }
            }
            else
            {
                Console.WriteLine("Préstamo no encontrado o libro ya devuelto.");
            }
        }
        public void MostrarLibros()
        {
            if (inventario.Count == 0)
            {
                Console.WriteLine("No hay libros en el inventario.");
            }
            else
            {
                foreach (var libro in inventario)
                {
                    libro.MostrarInformacion();
                }
            }
        }
        public void MostrarPrestamos()
        {
            if (prestamos.Count == 0)
            {
                Console.WriteLine("No hay préstamos activos.");
            }
            else
            {
                foreach (var prestamo in prestamos)
                {
                    prestamo.MostrarInformacion();
                }
            }
        }
    }
}
