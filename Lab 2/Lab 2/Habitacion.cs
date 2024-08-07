using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab_2
{
    public class Habitacion
    {
        public int Numero { get; set; }
        public double PrecioPorNoche { get; set; }
        public bool Disponible { get; set; }
        public string ClienteAsignado { get; set; }

        public Habitacion(int numero, double precioPorNoche)
        {
            Numero = numero;
            PrecioPorNoche = precioPorNoche;
            Disponible = true;
            ClienteAsignado = null;
        }
        public void MostrarInformacion()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Número: {Numero}");
            Console.WriteLine($"Precio por noche: {PrecioPorNoche}");
            Console.WriteLine($"Disponible: {Disponible}");
            Console.WriteLine($"Cliente Asignado: {ClienteAsignado}");
            Console.WriteLine("-----------------------------------------------");
        }
        public void CambiarDisponibilidad(bool disponible)
        {
            Disponible = disponible;
        }

        public void AsignarCliente(string nombreCliente)
        {
            ClienteAsignado = nombreCliente;
            CambiarDisponibilidad(false);
        }
        public void LiberarHabitacion()
        {
            ClienteAsignado = null;
            CambiarDisponibilidad(true);
        }
    }
}
