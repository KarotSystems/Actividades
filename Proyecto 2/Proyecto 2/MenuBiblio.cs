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

        private void btnGestionLib_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarLib agregarLibro = new AgregarLib();
            agregarLibro.Show();
        }

        private void btnPretamos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Informes informes = new Informes();
            informes.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio inicio = new Inicio();
            inicio.Show();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            EliminarLibr eliminarLibr = new EliminarLibr();
            eliminarLibr.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuscarLib buscarlb = new BuscarLib();
            buscarlb.Show();
        }

        private void btnGestionUsser_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroUsuario gestion = new RegistroUsuario();
            gestion.Show();
        }
    }
}
