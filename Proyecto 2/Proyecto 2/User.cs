﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_2
{
    public class User
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }

        public static List<User> listaUsuarios = new List<User>();
        static User()
        {
            listaUsuarios.Add(new User("Mario", "A001", "Bibliotecario"));
            listaUsuarios.Add(new User("Mabel", "B001", "Lector"));
        }
        public User(string usuario, string contraseña, string rol)
        {
            Usuario = usuario;
            Contraseña = contraseña;
            Rol = rol;
        }
        public static void GuardarUsuario(string nombre, string contraseña, string rol)
        {
            User nuevoUsuario = new User(nombre, contraseña, rol);
            listaUsuarios.Add(nuevoUsuario);
            MessageBox.Show($"Usuario: {nombre}\nContraseña: {contraseña}\nRol: {rol}", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static User AutenticarUsuario(string nombre, string contraseña)
        {
            foreach (User user in listaUsuarios)
            {
                if (user.Usuario == nombre && user.Contraseña == contraseña)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
