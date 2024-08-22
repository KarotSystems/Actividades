using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Parcial
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Cliente(string nombre, string correo, string direccion)
        {
            Nombre = nombre;
            CorreoElectronico = correo;
            Direccion = direccion;
            FechaRegistro = DateTime.Now;
        }
    }

    public class ClientePremium : Cliente
    {
        public double Descuento { get; set; }

        public ClientePremium(string nombre, string correo, string direccion, double descuento)
            : base(nombre, correo, direccion)
        {
            Descuento = descuento;
        }
    }

}
