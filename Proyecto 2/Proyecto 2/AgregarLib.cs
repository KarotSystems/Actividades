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
        }
        List<Libro> inventario = new List<Libro>();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string titulo = Txttitulo.Text;
            string autor = TxtAutor.Text;
            string ISBN = TxtISBN.Text;
            string Genero = TxtGenero.Text;
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.AgregarLibro(inventario, titulo, autor, ISBN, Genero);
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuBiblio menuBiblio = new MenuBiblio();
            menuBiblio.Show();
        }

        private void rchtxtLibros_TextChanged(object sender, EventArgs e)
        {
            string titulo = Txttitulo.Text;
            string autor = TxtAutor.Text;
            string ISBN = TxtISBN.Text;
            string Genero = TxtGenero.Text;
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.AgregarLibro(inventario, titulo, autor, ISBN, Genero);
        }
    }
}
