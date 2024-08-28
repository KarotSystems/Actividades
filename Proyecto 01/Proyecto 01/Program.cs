using Proyecto_01;
using static Proyecto_01.Vehiculo;

namespace Proyecto_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            int elegir;
            do
            {
                Console.WriteLine("Menu Principal");
                Console.WriteLine("1) Registrar vehiculo");
                Console.WriteLine("2) Retirar vehiculo");
                Console.WriteLine("3) Mostrar vehiculos estacionados");
                Console.WriteLine("4) Mostrar espacios disponibles");
                Console.WriteLine("5) Salir del Sistema");
                elegir = Convert.ToInt32(Console.ReadLine());
                switch(elegir)
                {
                    case 1:
                        {
                            Console.WriteLine("Registrar Vehiculo");
                            Console.WriteLine("Ingrese Datos");
                            var estacionamiento = new Estacionamiento(50);
                            estacionamiento.RegistrarVehiculo(new VehiculoCompacto("P123XYZ", "Toyota"));
                            estacionamiento.VerVehiculosEstacionados();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Retirar Vehiculo");
                            Console.WriteLine("Ingrese Datos");
                            var estacionamiento = new Estacionamiento(50);
                            estacionamiento.RegistrarVehiculo(new VehiculoCompacto("P123XYZ", "Toyota"));
                            estacionamiento.VerVehiculosEstacionados();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Mostrando datos del Vehiculo");
                            Console.WriteLine("Ingrese Datos");
                            var estacionamiento = new Estacionamiento(50);
                            estacionamiento.RegistrarVehiculo(new VehiculoCompacto("P123XYZ", "Toyota"));
                            estacionamiento.VerVehiculosEstacionados();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Mostrando datos estacionamiento");
                            Console.WriteLine("Ingrese Datos");
                            var estacionamiento = new Estacionamiento(50);
                            estacionamiento.RegistrarVehiculo(new VehiculoCompacto("P123XYZ", "Toyota"));
                            estacionamiento.VerVehiculosEstacionados();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Saliendo del programa");
                            Console.WriteLine("Nos vemos!");
                            break;
                        }
                }
                Console.WriteLine("Desea regresar al menu? S/N");
                opcion = Convert.ToString(Console.ReadLine().ToUpper());
                Console.Clear();
            } while (opcion == "S");
           
        } 
    } 
}


