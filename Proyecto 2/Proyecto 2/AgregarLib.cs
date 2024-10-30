using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_2
{
    public partial class AgregarLib : Form
    {
        public AgregarLib()
        {
            InitializeComponent();
            ActualizarListaLibros(); // Muestra los libros guardados en el RichTextBox al cargar
        }

        // Método para agregar un libro
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string titulo = Txttitulo.Text;
            string autor = TxtAutor.Text;
            string ISBN = TxtISBN.Text;
            string genero = TxtGenero.Text;
            bool disponible = rdbtnDisponibildad.Checked;

            Biblioteca.Instancia.AgregarLibro(titulo, autor, ISBN, genero, disponible);
            ActualizarListaLibros(); // Actualiza el RichTextBox
            LimpiarCampos(); // Limpia los campos de texto
        }
        //botón Editar, que permite editar los datos de un libro existente usando su ISBN
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Obtiene el ISBN ingresado y busca el libro en el inventario
            string ISBN = TxtISBN.Text;
            var libroExistente = Biblioteca.Instancia.inventario.FirstOrDefault(libro => libro.ISBN == ISBN);

            // Si el libro existe, actualiza sus datos con los valores ingresados
            if (libroExistente != null)
            {
                libroExistente.Titulo = Txttitulo.Text;
                libroExistente.Autor = TxtAutor.Text;
                libroExistente.Genero = TxtGenero.Text;

                // Muestra un mensaje confirmando la edición
                MessageBox.Show("El libro ha sido editado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarListaLibros();
                LimpiarCampos();
            }
            else
            {
                // Si no se encuentra el libro, muestra un mensaje de advertencia
                MessageBox.Show("No se encontró un libro con el ISBN especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Método para actualizar el RichTextBox con los datos del inventario
        private void ActualizarListaLibros()
        {
            rchtxtLibros.Clear();
            foreach (var libro in Biblioteca.Instancia.inventario)
            {
                rchtxtLibros.AppendText($"Título: {libro.Titulo}, Autor: {libro.Autor}, ISBN: {libro.ISBN}, Género: {libro.Genero}, Disponibilidad: {libro.Disponible}\n");
            }
        }

        private void LimpiarCampos()
        {
            Txttitulo.Clear();
            TxtAutor.Clear();
            TxtISBN.Clear();
            TxtGenero.Clear();
        }
        //botón Regresar, que cierra la ventana actual y muestra el menú principal
        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuBiblio menuBiblio = new MenuBiblio();
            menuBiblio.Show();
        }

        private void AgregarLib_MouseClick(object sender, MouseEventArgs e)
        {
        }
    }
}