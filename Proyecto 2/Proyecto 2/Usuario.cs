using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_2
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }
        private void Ingresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            User usuarioAutenticado = User.AutenticarUsuario(usuario, contraseña);

            if (usuarioAutenticado != null)
            {
                Inicio inicio = new Inicio();
                inicio.Close();
                if (usuarioAutenticado.Rol == "Lector")
                {     
                    Menu lectorForm = new Menu();
                    lectorForm.Show();
                }
                else if (usuarioAutenticado.Rol == "Bibliotecario")
                {
                    MenuBiblio biblioForm = new MenuBiblio();
                    biblioForm.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Por favor, intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
