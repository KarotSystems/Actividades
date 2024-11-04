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
    public partial class Libreria : Form
    {
        public Libreria()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string ISBN = TxtISBN.Text;
            var libroEncontrado = Biblioteca.Instancia.inventario.FirstOrDefault(libro => libro.ISBN == ISBN);

            if (libroEncontrado != null)
            {
                MessageBox.Show("Se ha encontrado el libro", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rchtxtLibros.AppendText($"Título: {libroEncontrado.Titulo}, Autor: {libroEncontrado.Autor}, ISBN: {libroEncontrado.ISBN}, Género: {libroEncontrado.Genero}, Disponibilidad: {libroEncontrado.EstadoDisponible}\n\n");
            }
            else
            {
                // Si no se encuentra, muestra un mensaje de aviso
                MessageBox.Show("No se encontró un libro con el ISBN especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            string ISBN = TxtISBN.Text;
            Lector lectorActual = User.Instancia.Rol();

            if (lectorActual != null)
            {
                Biblioteca.Instancia.SolicitarPrestamo(lectorActual, ISBN);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un lector.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
