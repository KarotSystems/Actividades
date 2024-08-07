using Lab_2;
using System;

public class Program
{
    public static void Main()
    {
        Hotel hotel = new Hotel();
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("___________________________________");
            Console.WriteLine("Menú de gestión de reservas del hotel:");
            Console.WriteLine("1. Agregar Habitación");
            Console.WriteLine("2. Eliminar Habitación");
            Console.WriteLine("3. Mostrar Habitaciones");
            Console.WriteLine("4. Asignar Habitación a Cliente");
            Console.WriteLine("5. Liberar Habitación");
            Console.WriteLine("6. Salir");

            Console.Write("Elija una opción: ");
            int opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("___________________________________");
            switch (opcion)
            {
                case 1:
                    {
                        AgregarHabitacion(hotel);
                        break;
                    }
                case 2:
                    {
                        EliminarHabitacion(hotel);
                        break;
                    }
                case 3:
                    {
                        hotel.MostrarHabitaciones();
                        break;
                    }
                case 4:
                    {
                        AsignarHabitacion(hotel);
                        break;
                    }
                case 5:
                    {
                        LiberarHabitacion(hotel);
                        break;
                    }
                case 6:
                    {
                        salir = true;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Opción no válida.");
                        break;
                    }
            }
        }
    }

    private static void AgregarHabitacion(Hotel hotel)
    {
        Console.Clear();
        Console.WriteLine("------- Tipo de Habitación -------");
        Console.WriteLine("1. Habitación Simple");
        Console.WriteLine("2. Habitación Doble");
        Console.WriteLine("3. Suite");
        Console.WriteLine("4. Habitación Deluxe");
        Console.Write("Elija una opción: ");
        int tipo = int.Parse(Console.ReadLine());
        Console.Write("Número: ");
        int numero = int.Parse(Console.ReadLine());
        Console.Write("Precio por Noche: ");
        double precio = double.Parse(Console.ReadLine());

        switch (tipo)
        {
            case 1:
                {
                    Console.Write("Número de Camas: ");
                    int numeroDeCamas = int.Parse(Console.ReadLine());
                    hotel.AgregarHabitacion(new Simple(numero, precio, numeroDeCamas));
                    break;
                }
            case 2:
                {
                    Console.Write("Vista al Mar (true/false): ");
                    bool vistaAlMar = bool.Parse(Console.ReadLine());
                    hotel.AgregarHabitacion(new Doble(numero, precio, vistaAlMar));
                    break;
                }
            case 3:
                {
                    Console.Write("Número de Habitaciones: ");
                    int numeroDeHabitaciones = int.Parse(Console.ReadLine());
                    Console.Write("Tiene Jacuzzi (true/false): ");
                    bool tieneJacuzzi = bool.Parse(Console.ReadLine());
                    hotel.AgregarHabitacion(new Suite(numero, precio, numeroDeHabitaciones, tieneJacuzzi));
                    break;
                }
            case 4:
                {
                    Console.Write("Servicios Extras: ");
                    string serviciosExtras = Console.ReadLine();
                    hotel.AgregarHabitacion(new Deluxe(numero, precio, serviciosExtras));
                    break;
                }
            default:
                {
                    Console.WriteLine("Tipo no válido.");
                    break;
                }
        }
    }
    private static void EliminarHabitacion(Hotel hotel)
    {
        Console.Clear();
        Console.Write("Número de Habitación a eliminar: ");
        int numero = int.Parse(Console.ReadLine());
        hotel.EliminarHabitacion(numero);
    }
    private static void AsignarHabitacion(Hotel hotel)
    {
        Console.Clear();
        Console.Write("Número de Habitación: ");
        int numero = int.Parse(Console.ReadLine());
        Console.Write("Nombre del Cliente: ");
        string nombreCliente = Console.ReadLine();
        hotel.AsignarHabitacion(numero, nombreCliente);
    }
    private static void LiberarHabitacion(Hotel hotel)
    {
        Console.Clear();
        Console.Write("Número de Habitación: ");
        int numero = int.Parse(Console.ReadLine());
        hotel.LiberarHabitacion(numero);
    }
}
