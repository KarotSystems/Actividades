using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_02_Consola
{
    public class Biblioteca
    {
        public List<Libro> Libros { get; set; } = new List<Libro>();
        public List<Prestamo> Prestamos { get; set; } = new List<Prestamo>();
        public void AgregarLibro(Biblioteca biblioteca, Libro libro)
        {
            biblioteca.Libros.Add(libro);
            Console.WriteLine("Libro agregado con éxito");
        }
        public void EliminarLibro(Biblioteca biblioteca, string isbn)
        {
            var libro = biblioteca.Libros.Find(l => l.ISBN == isbn);
            if (libro != null)
            {
                biblioteca.Libros.Remove(libro);
                Console.WriteLine("Libro eliminado con éxito");
            }
            else
            {
                Console.WriteLine("El libro no se encontró");
            }
        }
        public void BuscarLibroPorTitulo(string titulo)
        {
            foreach (var libro in Libros)
            {
                if (libro.Titulo.Contains(titulo, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Título: {libro.Titulo}, Autor: {libro.Autor}, ISBN: {libro.ISBN}, Género: {libro.Genero}, Disponible: {libro.Disponible}");
                }
            }
        }
        public void BuscarLibroPorISBN(string isbn)
        {
            foreach (var isb in Libros)
            {
                if (isb.ISBN.Contains(isbn, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Título: {isb.Titulo}, Autor: {isb.Autor}, ISBN: {isb.ISBN}, Género: {isb.Genero}, Disponible: {isb.Disponible}");
                }
            }
        }
        public void SolicitarPrestamo(Lector lector, string isbn)
        {
            foreach (var isb in Libros)
            {
                if (isb.ISBN.Contains(isbn, StringComparison.OrdinalIgnoreCase))
                {
                    Prestamos.Add(new Prestamo(isb, lector));
                    isb.Disponible = false;
                    Console.WriteLine($"El libro {isb.Titulo} ha sido prestado a {lector.Nombre}.");
                }
                else
                {
                    Console.WriteLine("El libro no está disponible.");
                }
            }
        }
        public void DevolverLibro(string isbn)
        {
            var prestamo = Prestamos.Find(p => p.LibroPrestado.ISBN == isbn && p.FechaDevolucion == null);
            if (prestamo != null)
            {
                prestamo.FechaDevolucion = DateTime.Now;
                prestamo.LibroPrestado.Disponible = true;
                Console.WriteLine($"El libro {prestamo.LibroPrestado.Titulo} ha sido devuelto.");
            }
            else
            {
                Console.WriteLine("El libro no está en préstamo.");
            }
        }
    } 
}
