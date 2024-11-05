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
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
            ActualizarLista();
        }
        //actualiza el richtexbox
        private void ActualizarLista()
        {
            rchtxtUser.Clear();
            foreach (var uss in User.Instancia.ListaUsuarios)
            {
                rchtxtUser.AppendText($"Usuario: {uss.Usuario}, Contraseña: {uss.Contraseña}, Rol: {uss.Rol}\n");
            }
        }
        //limpia los campos
        private void LimpiarCampo()
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
            RpBiblio.Checked = false;
            RpLector.Checked = false;
        }
        //Boton regreso
        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuBiblio menuBiblio = new MenuBiblio();
            menuBiblio.Show();
        }
        //guarda usuarios en la lista
        private void Registro_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            string rol = "";
            if (RpLector.Checked)
            {
                rol = "Lector";
            }
            else if (RpBiblio.Checked)
            {
                rol = "Bibliotecario";
            }
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña) || string.IsNullOrEmpty(rol))
            {
                MessageBox.Show("Por favor, complete toda la información.");
                return;
            }
            User.Instancia.GuardarUsuario(usuario, contraseña, rol);
            ActualizarLista();
            LimpiarCampo();
        }
        //boton editar los datos de la lista
        private void btnEditar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            string rol = "";
            if (RpLector.Checked)
            {
                rol = "Lector";
            }
            else if (RpBiblio.Checked)
            {
                rol = "Bibliotecario";
            }
            var usuarioExistente = User.Instancia.ListaUsuarios.FirstOrDefault(u => u.Usuario == usuario);

            if (usuarioExistente != null)
            {
                usuarioExistente.Contraseña = contraseña;
                usuarioExistente.Rol = rol;
                MessageBox.Show("El usuario ha sido editado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró un usuario con el nombre especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ActualizarLista();
            LimpiarCampo();
        }
        //boton borrar los datos de la lista
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            User.Instancia.EliminarUsuario(usuario, contraseña);
            ActualizarLista();
            LimpiarCampo();
        }
    }
}
