using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_02_Consola
{
    public class Lector : Usuario
    {
        public Lector(string nombre, string id) : base(nombre, id) { }
    }
    public class Bibliotecario : Usuario
    {
        public Bibliotecario(string nombre, string id) : base(nombre, id) { }
    }
}
