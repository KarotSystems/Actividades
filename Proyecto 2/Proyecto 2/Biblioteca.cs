using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2
{
    public class Biblioteca
    {
        private static Biblioteca instancia;

        public List<Libro> inventario = new List<Libro>();
        public List<Usuario> usuarios = new List<Usuario>();
        public List<Prestamo> prestamos = new List<Prestamo>();
        public Queue<Lector> listaDeEspera = new Queue<Lector>();

        // Propiedad para retornar informacion
        public static Biblioteca Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Biblioteca();
                }
                return instancia;
            }
        }

        private Biblioteca() { } // Constructor privado para evitar instancias adicionales

        // Métodos de Biblioteca (AgregarLibro, EliminarLibro, etc.)
        public void AgregarLibro(string titulo, string autor, string isbn, string genero, bool disponible)
        {
            if (!inventario.Exists(libro => libro.ISBN == isbn))
            {
                inventario.Add(new Libro(titulo, autor, isbn, genero) { Disponible = disponible });
                MessageBox.Show($"Libro {titulo} agregado correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: ISBN ya registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EliminarLibro(List<Libro> inventario, string isbn)
        {
            var libro = inventario.Find(l => l.ISBN == isbn);
            if (libro != null)
            {
                inventario.Remove(libro);
                MessageBox.Show($"Libro con ISBN {isbn} eliminado correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Libro no encontrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SolicitarPrestamo(Lector lector, string isbn)
        {
            var libro = inventario.Find(l => l.ISBN == isbn);
            if (libro != null && libro.Disponible)
            {
                libro.Disponible = false;
                prestamos.Add(new Prestamo(lector, libro));
                MessageBox.Show($"Préstamo del libro {libro.Titulo} registrado.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (libro != null && !libro.Disponible)
            {
                listaDeEspera.Enqueue(lector);
                MessageBox.Show($"Libro {libro.Titulo} no disponible. {lector.Usuario} añadido a la lista de espera.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Libro no encontrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Préstamo no encontrado o libro ya devuelto.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void MostrarLibros()
        {
            if (inventario.Count == 0)
            {
                MessageBox.Show("No hay libros en el inventario.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("No hay préstamos activos.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
