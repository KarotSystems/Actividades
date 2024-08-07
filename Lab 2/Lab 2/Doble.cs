using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Doble : Habitacion
    {
        public bool VistaAlMar { get; set; }
        public Doble(int numero, double precioPorNoche, bool vistaAlMar)
            : base(numero, precioPorNoche)
        {
            VistaAlMar = vistaAlMar;
        }
        public void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Vista al Mar: {VistaAlMar}");
        }
    }
}
