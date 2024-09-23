using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laboratorio_5
{
    public class Tarea
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Completada { get; set; }
        public Tarea(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Completada = false;
        }
    }
}
