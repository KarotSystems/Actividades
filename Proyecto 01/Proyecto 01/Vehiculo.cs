using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_01
{
    public class Vehiculo
    {
        public string Placa { get; set; }
        public string Marca { get; set; }
        public DateTime HoraEntrada { get; set; }

        public Vehiculo(string placa, string marca)
        {
            Placa = placa;
            Marca = marca;
            HoraEntrada = DateTime.Now;
        }
        public double CalcularCosto(TimeSpan tiempoEstacionado)
        {
            return Math.Ceiling(tiempoEstacionado.TotalHours) * 10.0; // Ejemplo de tarifa por hora
        }

        public class VehiculoCompacto : Vehiculo
        {
            public VehiculoCompacto(string placa, string marca) 
                : base(placa, marca)
            {
            }
        }

    }
}
