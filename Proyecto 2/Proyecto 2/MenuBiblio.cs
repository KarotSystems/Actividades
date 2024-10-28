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
    public partial class MenuBiblio : Form
    {
        public MenuBiblio()
        {
            InitializeComponent();
        }
        private void libreria_Click(object sender, EventArgs e)
        {
            this.Hide();
            Libreria agregarLibro = new Libreria();
            agregarLibro.Show();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuscarLib buscarlb = new BuscarLib();
            buscarlb.Show();
        }

        private void gestionuser_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionUsuarios gestion = new GestionUsuarios();
            gestion.Show();
        }
        private void Modulopretamos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prestamos preta = new Prestamos();
            preta.Show();
        }
        private void Biblotecario_Load(object sender, EventArgs e)
        {

        }
    }
}
