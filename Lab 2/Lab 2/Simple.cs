using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Simple : Habitacion
    {
        public int NumeroDeCamas { get; set; }

        public Simple(int numero, double precioPorNoche, int numeroDeCamas)
            : base(numero, precioPorNoche)
        {
            NumeroDeCamas = numeroDeCamas;
        }

        public void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Número de Camas: {NumeroDeCamas}");
        }
    }
}
