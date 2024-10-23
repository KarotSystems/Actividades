using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2
{
    public class Lector : User
    {
        public Lector(string nombre, string contraseña, string rol) : base(nombre, contraseña, rol)
        {
            Rol = "Lector";
        }
    }
    public class Bibliotecario : User
    {
        public Bibliotecario(string nombre, string contraseña, string rol) : base(nombre, contraseña, rol)
        {
            Rol = "Bibliotecario";
        }
        public void AgregarLibro(List<Libro> inventario, string titulo, string autor, string isbn, string genero)
        {
            if (!inventario.Exists(libro => libro.ISBN == isbn))
            {
                inventario.Add(new Libro(titulo, autor, isbn, genero));

                Console.WriteLine($"Libro {titulo} agregado correctamente.");
            }
            else
            {
                MessageBox.Show("Error: ISBN ya registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
