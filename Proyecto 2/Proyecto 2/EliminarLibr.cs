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
    public partial class EliminarLibr : Form
    {
        public EliminarLibr()
        {
            InitializeComponent();
            ActualizarListaLibros(); // Muestra los libros guardados en el RichTextBox al cargar

        }
        // Método para actualizar el RichTextBox con los datos del inventario
        private void ActualizarListaLibros()
        {
            rchtxtLibros.Clear();
            foreach (var libro in Biblioteca.Instancia.inventario)
            {
                rchtxtLibros.AppendText($"Título: {libro.Titulo}, Autor: {libro.Autor}, ISBN: {libro.ISBN}, Género: {libro.Genero}, Disponibilidad: {libro.EstadoDisponible}\n\n");
            }
        }
        //Metodo limpieza
        private void LimpiarCampos()
        {
            TxtISBN.Clear();
        }
        //botón Regresar, que cierra la ventana actual y muestra el menú principal
        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuBiblio menuBiblio = new MenuBiblio();
            menuBiblio.Show();
        }
        //boton eliminar libro
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string ISBN = TxtISBN.Text;
            Biblioteca.Instancia.EliminarLibro(ISBN);
            ActualizarListaLibros();
            LimpiarCampos();
        }
    }
}
