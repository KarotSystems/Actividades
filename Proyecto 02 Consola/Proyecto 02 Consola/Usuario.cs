using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_02_Consola
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Id { get; set; }
        public Usuario(string nombre, string id)
        {
            Nombre = nombre;
            Id = id;
        }
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, ID: {Id}");
        }
    }
}
