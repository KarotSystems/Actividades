using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_01
{
    public class Estacionamiento
    {
        public int CapacidadTotal { get; set; }
        public int EspaciosDisponibles { get; set; }
        private List<Vehiculo> VehiculosEstacionados = new List<Vehiculo>();

        public Estacionamiento(int capacidadTotal)
        {
            CapacidadTotal = capacidadTotal;
            EspaciosDisponibles = capacidadTotal;
        }

        public bool RegistrarVehiculo(Vehiculo vehiculo)
        {
            if (EspaciosDisponibles > 0)
            {
                VehiculosEstacionados.Add(vehiculo);
                EspaciosDisponibles--;
                return true;
            }
            return false;
        }

        public Vehiculo RetirarVehiculo(string placa)
        {
            var vehiculo = VehiculosEstacionados.FirstOrDefault(v => v.Placa == placa);
            if (vehiculo != null)
            {
                TimeSpan tiempoEstacionado = DateTime.Now - vehiculo.HoraEntrada;
                double costo = vehiculo.CalcularCosto(tiempoEstacionado);
                Console.WriteLine($"Costo total: Q{costo}");
                VehiculosEstacionados.Remove(vehiculo);
                EspaciosDisponibles++;
                return vehiculo;
            }
            return null;
        }

        public void VerVehiculosEstacionados()
        {
            foreach (var vehiculo in VehiculosEstacionados)
            {
                Console.WriteLine($"{vehiculo.Placa} - {vehiculo.Marca} - {vehiculo.HoraEntrada}");
            }
        }
    }
}
