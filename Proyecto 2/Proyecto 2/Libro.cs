using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2
{
    // Clase que representa un libro en el sistema de gestión de biblioteca
    public class Libro
    {
        // Propiedades del libro: título, autor, ISBN, género y disponibilidad
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public string Genero { get; set; }
        public bool Disponible { get; set; }

        // Constructor de la clase Libro que asigna los valores al crear un nuevo objeto
        public Libro(string titulo, string autor, string isbn, string genero)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            Genero = genero;
            Disponible = true;
        }

        // Método para mostrar la información del libro en un cuadro de mensaje
        public void MostrarInformacion()
        {
            // Muestra un MessageBox con los detalles del libro (título, autor, ISBN, género y disponibilidad)
            MessageBox.Show($"Título: {Titulo}, Autor: {Autor}, ISBN: {ISBN}, Género: {Genero}, Disponible: {Disponible}","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }

}
