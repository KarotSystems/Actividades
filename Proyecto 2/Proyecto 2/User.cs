using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_2
{
    public class User
    {
        private static User instancia;
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }

        // Lista de usuarios, ahora es una propiedad de instancia
        public List<User> ListaUsuarios { get; private set; }

        // Propiedad para obtener la instancia única de User (Singleton)
        public static User Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new User();
                }
                return instancia;
            }
        }

        // Constructor privado para evitar instanciación adicional y para inicializar usuarios predeterminados
        private User()
        {
            ListaUsuarios = new List<User>
            {
                new User("Mario", "A001", "Bibliotecario"),
                new User("Mabel", "B001", "Lector")
            };
        }

        // Constructor para crear un usuario nuevo (no añade directamente a ListaUsuarios)
        public User(string usuario, string contraseña, string rol)
        {
            Usuario = usuario;
            Contraseña = contraseña;
            Rol = rol;
        }

        // Método para guardar un nuevo usuario en la lista única de usuarios
        public void GuardarUsuario(string nombre, string contraseña, string rol)
        {
            User nuevoUsuario = new User(nombre, contraseña, rol);
            ListaUsuarios.Add(nuevoUsuario);
            MessageBox.Show($"Usuario: {nombre}\nContraseña: {contraseña}\nRol: {rol}", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Método para autenticar usuario
        public User AutenticarUsuario(string nombre, string contraseña)
        {
            foreach (User user in ListaUsuarios)
            {
                if (user.Usuario == nombre && user.Contraseña == contraseña)
                {
                    return user;
                }
            }
            return null;
        }
        // Método para eliminar usuario
        public bool EliminarUsuario(string nombre, string contraseña)
        {
            var usuario = ListaUsuarios.FirstOrDefault(u => u.Usuario == nombre && u.Contraseña == contraseña);
            if (usuario != null)
            {
                MessageBox.Show("El usuario ha sido eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListaUsuarios.Remove(usuario);
                return true;
            }
            else
            {
                MessageBox.Show("No se ha encontrado el usuario ha eliminar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
    }
}
