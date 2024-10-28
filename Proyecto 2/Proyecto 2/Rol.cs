using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2
{
    public class Lector : User
    {
        public Lector(string nombre, string contraseña, string rol) : base(nombre, contraseña, rol)
        {
            Rol = "Lector";
        }
    }
    public class Bibliotecario : User
    {
        public Bibliotecario(string nombre, string contraseña, string rol) : base(nombre, contraseña, rol)
        {
            Rol = "Bibliotecario";
        }
    }
}
