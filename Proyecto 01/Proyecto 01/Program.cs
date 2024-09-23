using Proyecto_01;
using static Proyecto_01.Vehiculo;
using static Proyecto_01.Estacionamiento;

namespace Proyecto_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //ingresa la cantidad del estacionamiento
            Console.WriteLine("Estacionamiento San Carlos ");
            Console.Write("Cantidad de espacio disponible: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            var estacionamiento = new Estacionamiento(cantidad);
            string opcion;
            int elegir;
            Console.Clear();
            do
            {
                //opciones del menu
                Console.WriteLine("Estacionamiento San Carlos ");
                Console.WriteLine("Menu Principal");
                Console.WriteLine("1) Registrar vehiculo");
                Console.WriteLine("2) Retirar vehiculo");
                Console.WriteLine("3) Mostrar vehiculos estacionados");
                Console.WriteLine("4) Mostrar espacios disponibles");
                Console.WriteLine("5) Expandir el espacio");
                Console.WriteLine("6) Salir del Sistema");
                Console.Write("Ingrese la opcion deseada: ");
                elegir = Convert.ToInt32(Console.ReadLine());
                switch(elegir)
                {
                    case 1:
                        {
                            // Registrar un vehículo
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("Registrar Vehiculo");
                            Console.Write("Ingrese su placa: ");
                            string placa = Console.ReadLine();
                            Console.Write("Ingrese su marca: ");
                            string marca = Console.ReadLine();
                            if(estacionamiento.RegistrarVehiculo(new VehiculoCompacto(placa, marca)))
                            {
                                Console.WriteLine("El vehículo se ha registrado exitosamente");
                                estacionamiento.VerVehiculosEstacionados();
                            }
                            else
                            {
                                Console.WriteLine("No hay espacio disponible.");
                            }
                            Console.WriteLine("--------------------------------------------------");
                            break;
                        }
                    case 2:
                        {
                            //Retira el vehiculo
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("Retirar Vehiculo");
                            Console.WriteLine("Mostrando Vehiculos estacionados");
                            Console.WriteLine(" ");
                            estacionamiento.VerVehiculosEstacionados();
                            Console.WriteLine(" ");
                            Console.Write("Ingrese la placa del vehiculo: ");
                            string placa = Console.ReadLine();
                            if (estacionamiento.RetirarVehiculo(placa) != null)
                            {
                                Console.WriteLine("El Vehiculo se ha retirado...");
                            }
                            else
                            {
                                Console.WriteLine("No se encontró el vehículo con la placa especificada.");
                            }
                            Console.WriteLine("--------------------------------------------------");
                            break;
                        }
                    case 3:
                        {
                            //Mostrar vehiculos estacionados
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("Mostrando datos del Vehiculo");
                            Console.WriteLine("");
                            estacionamiento.VerVehiculosEstacionados();
                            Console.WriteLine("");
                            Console.WriteLine("--------------------------------------------------");
                            break;
                        }
                    case 4:
                        {
                            //Mostrar espacio libre
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("");
                            Console.WriteLine("Mostrando datos de estacionamiento");
                            Console.WriteLine($"Hay {estacionamiento.EspaciosDisponibles} espacios disponibles");
                            Console.WriteLine("");
                            Console.WriteLine("--------------------------------------------------");
                            break;
                        }
                    case 5:
                        {
                            //Expandiendo almacenamiento
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("Expandiendo datos de estacionamiento");
                            Console.Write("Cantidad de estacionamiento disponible: ");
                            int agregar = Convert.ToInt32(Console.ReadLine());
                            estacionamiento.CapacidadTotal += agregar;
                            estacionamiento.EspaciosDisponibles += agregar;
                            Console.WriteLine($"Dispone de {estacionamiento.EspaciosDisponibles} espacios libres");
                            Console.WriteLine("--------------------------------------------------");
                            break;
                        }
                    case 6:
                        {
                            //salir del programa
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("Saliendo del programa");
                            Console.WriteLine("--------------------------------------------------");
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


