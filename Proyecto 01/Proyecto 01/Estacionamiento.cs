using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_01
{
    public class Estacionamiento
    {
        //atributos
        public int CapacidadTotal { get; set; }
        public int EspaciosDisponibles { get; set; }
        //lista para almacenar los vehiculos estacionados
        private List<Vehiculo> VehiculosEstacionados = new List<Vehiculo>();
        //constructor
        public Estacionamiento(int capacidadTotal)
        {
            CapacidadTotal = capacidadTotal;
            EspaciosDisponibles = capacidadTotal;
        }
        // Método para registrar vehiculo
        public bool RegistrarVehiculo(Vehiculo vehiculo)
        {
            if (EspaciosDisponibles > 0) //Verifica si hay espacios libres
            {
                VehiculosEstacionados.Add(vehiculo); //añade el vehiculo
                EspaciosDisponibles--; //resta la cantidad de espacios libres
                return true;
            }
            return false; //Si no hay espacio, no registra nada
        }
        //metodo para retirar vehiculo
        public Vehiculo RetirarVehiculo(string placa)
        {
            // Busca el vehículo por su placa
            var vehiculo = VehiculosEstacionados.FirstOrDefault(v => v.Placa == placa);
            if (vehiculo != null)
            {
                TimeSpan tiempoEstacionado = DateTime.Now - vehiculo.HoraEntrada; //Calcula el tiempo
                double costo = vehiculo.CalcularCosto(tiempoEstacionado); //Calcula el costo
                Console.WriteLine($"Costo total: Q{costo}");
                Console.WriteLine(" ");
                Console.WriteLine("¿Como desea pagar?");
                Console.WriteLine("1) Efectivo");
                Console.WriteLine("2) Tarjeta");
                Console.Write("Seleccione el método de pago: ");
                int opcionPago = Convert.ToInt32(Console.ReadLine());
                if (opcionPago == 1)
                {
                    Console.WriteLine("Ha seleccionado Efectivo");
                    Console.WriteLine("Monto Ingresado: ");
                    double efectivo = Convert.ToDouble(Console.ReadLine());
                    while (efectivo < costo)
                    {
                        Console.WriteLine($"Monto insuficiente. Ingrese al menos Q{costo}: ");
                        efectivo += Convert.ToDouble(Console.ReadLine());
                    }

                    double cambio = efectivo - costo;
                    Console.WriteLine($"Cambio a devolver: Q{cambio}");
                    int[] billetes = { 200, 100, 50, 20, 10, 5, 1 };
                    foreach (var billete in billetes)
                    {
                        if (cambio >= billete)
                        {
                            int cantidad = (int)(cambio / billete);
                            cambio -= cantidad * billete;
                            Console.WriteLine($"Billetes de Q{billete}: {cantidad}");
                        }
                    }
                }
                else if (opcionPago == 2)
                {
                    Console.Write("Ingrese el número de tarjeta: ");
                    string numeroTarjeta = Console.ReadLine();
                    Console.Write("Ingrese el nombre del titular: ");
                    string nombreTitular = Console.ReadLine();
                    Console.Write("Ingrese la fecha de vencimiento (MM/AA): ");
                    string fechaVencimiento = Console.ReadLine();
                    Console.Write("Ingrese el CVV: ");
                    string cvv = Console.ReadLine();
                    Console.WriteLine("Procesando pago...");
                    Console.WriteLine("Pago aprobado.");
                }
                VehiculosEstacionados.Remove(vehiculo); // Elimina el vehículo de la lista
                EspaciosDisponibles++; //aumenta el espacio disponibles
                return vehiculo;
            }
            return null; //No retorna nada, si el vehículo no se encuentra
        }
        // Método para mostrar los vehículos estacionados
        public void VerVehiculosEstacionados()
        {
            if (VehiculosEstacionados.Count == 0)
            {
                Console.WriteLine("No hay ningún vehículo estacionado.");
            }
            else
            {
                foreach (var vehiculo in VehiculosEstacionados)
                {
                    Console.WriteLine($"{vehiculo.Placa} - {vehiculo.Marca} - {vehiculo.HoraEntrada}");
                }
            }
        }
    }
}
