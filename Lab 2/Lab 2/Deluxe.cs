using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Deluxe : Habitacion
    {
        public string ServiciosExtras { get; set; }

        public Deluxe(int numero, double precioPorNoche, string serviciosExtras)
            : base(numero, precioPorNoche)
        {
            ServiciosExtras = serviciosExtras;
        }

        public void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Servicios Extras: {ServiciosExtras}");
        }
    }
}
