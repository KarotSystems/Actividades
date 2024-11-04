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
    public partial class BuscarLib : Form
    {
        public BuscarLib()
        {
            InitializeComponent();
        }
        //Boton regresar, regresa al menu principal
        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuBiblio menuBiblio = new MenuBiblio();
            menuBiblio.Show();
        }
        // Botón Buscar, que busca un libro en el inventario usando el ISBN ingresado
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string ISBN = TxtISBN.Text;
            // Buscar el libro por ISBN en el inventario de la biblioteca
            var libroEncontrado = Biblioteca.Instancia.inventario.FirstOrDefault(libro => libro.ISBN == ISBN);

            // Si el libro se encuentra, muestra su información
            if (libroEncontrado != null)
            {
                MessageBox.Show("Se ha encontrado el libro", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbtitulo.Visible = Enabled;
                lbautor.Visible = Enabled;
                lbisbn.Visible = Enabled;
                lbgenero.Visible = Enabled;
                lbdisponible.Visible = Enabled;

                lbtitulo.Text = libroEncontrado.Titulo.ToString();
                lbautor.Text = libroEncontrado.Autor.ToString();
                lbisbn.Text = libroEncontrado.ISBN.ToString();
                lbgenero.Text = libroEncontrado.Genero.ToString();
                lbdisponible.Text = libroEncontrado.EstadoDisponible.ToString();
            }
            else
            {
                // Si no se encuentra, muestra un mensaje de aviso
                MessageBox.Show("No se encontró un libro con el ISBN especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
