using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_01
{
    // Clase Vehiculo que representa un vehículo genérico
    public class Vehiculo
    {
        public string Placa { get; set; } // Número de placa del vehículo
        public string Marca { get; set; } // Marca del vehículo
        public DateTime HoraEntrada { get; set; } // Hora de entrada al estacionamiento
        // Constructor que inicializa las propiedades del vehículo
        public Vehiculo(string placa, string marca)
        {
            Placa = placa;
            Marca = marca;
            HoraEntrada = DateTime.Now; // Hora de entrada establecida
        }
        // Método para calcular el costo del estacionamiento
        public double CalcularCosto(TimeSpan tiempoEstacionado)
        {
            //Funcion que devuelve el entero mayor o igual más próximo a un número dado.
            return Math.Ceiling(tiempoEstacionado.TotalHours) * 10.0; // Ejemplo de tarifa por hora
        }
        // Clase VehiculoCompacto que hereda de Vehiculo
        public class VehiculoCompacto : Vehiculo
        {
            // Constructor que llama al primer constructor
            public VehiculoCompacto(string placa, string marca) 
                : base(placa, marca)
            {
            }
        }

    }
}
