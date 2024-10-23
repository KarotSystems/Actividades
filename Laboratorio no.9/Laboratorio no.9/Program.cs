public class Vehiculo
{
    public string Marca;
    public string Placa;
    public Vehiculo Siguiente;
    public Vehiculo(string marca, string placa)
    {
        Marca = marca;
        Placa = placa;
        Siguiente = null;
    }
    public void Mostrar()
    {
        Console.WriteLine($"Vehículo {Marca} - {Placa}");
    }
}
public class Estacionamiento
{
    public Vehiculo Principal;
    public int capacidadMaxima;
    public int cantidadActual;
    Stack<Vehiculo> Salidas;
    Queue<Vehiculo> ListaEspera;
    public Estacionamiento(int capacidad)
    {
        Principal = null;
        capacidadMaxima = capacidad;
        cantidadActual = 0;
        Salidas = new Stack<Vehiculo>();
        ListaEspera = new Queue<Vehiculo>();
    }
    public void IngresarVehiculo(string marca, string placa)
    {
        if (cantidadActual < capacidadMaxima)
        {
            Vehiculo nuevoVehiculo = new Vehiculo(marca, placa);
            if (Principal == null)
            {
                Principal = nuevoVehiculo;
            }
            else
            {
                Vehiculo actual = Principal;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoVehiculo;
            }
            cantidadActual++;
            Console.WriteLine($"Vehículo {marca} - {placa} ha ingresado al estacionamiento.");
        }
        else
        {
            Vehiculo nuevoVehiculo = new Vehiculo(marca, placa);
            ListaEspera.Enqueue(nuevoVehiculo);
            Console.WriteLine($"Estacionamiento lleno. Vehículo {marca} - {placa} agregado a la lista de espera.");
        }
    }
    public void RetiraVehiculo(string placa)
    {
        if (Principal == null)
        {
            Console.WriteLine("El estacionamiento está vacío.");
            return;
        }
        Vehiculo primero = Principal;
        Vehiculo anterior = null;
        while (primero != null && primero.Placa != placa)
        {
            anterior = primero;
            primero = primero.Siguiente;
        }
        if (primero != null)
        {
            Principal = primero.Siguiente;
        }
        else
        {
            anterior.Siguiente = primero.Siguiente; 
        }
        cantidadActual--;
        Salidas.Push(primero);
        Console.WriteLine($"Vehículo {primero.Marca} - {primero.Placa} ha salido del estacionamiento.");
        if (ListaEspera.Count > 0)
        {
            Vehiculo VehiculoEspera = ListaEspera.Dequeue();
            IngresarVehiculo(VehiculoEspera.Marca, VehiculoEspera.Placa);
        }
    }
    public void Deshacer()
    {
        if (Salidas.Count > 0)
        {
            Vehiculo ultimoVehiculo = Salidas.Pop();
            IngresarVehiculo(ultimoVehiculo.Marca, ultimoVehiculo.Placa);
            Console.WriteLine($"Se ha deshecho {ultimoVehiculo.Marca} - {ultimoVehiculo.Placa} ");
        }
        else
        {
            Console.WriteLine("No hay Salidas por deshacer");
        }
    }
    public void MostrarEstacionamiento()
    {
        if (Principal == null)
        {
            Console.WriteLine("No hay vehículos en el estacionamiento.");
            return;
        }
        Vehiculo primero = Principal;
        Console.WriteLine("Vehículos en el estacionamiento: ");
        while (primero != null)
        {
            primero.Mostrar();
            primero = primero.Siguiente;
        }
    }
    public void EnEspera()
    {
        if(ListaEspera.Count > 0)
        {
            Vehiculo proximo = ListaEspera.Peek();
            Console.WriteLine($"Próximo vehículo en la lista de espera: {proximo.Marca} - {proximo.Placa}");
        }
        else
        {
            Console.WriteLine("No hay vehiculos en espera");
        }
    }
}
public class program
{
    public static void Main()
    {
        Estacionamiento estacionamiento = new Estacionamiento(10);
        Queue<string> Cola = new Queue<string>();
        int elegir;
        string placa;
        string marca;
        bool salir = false;
        string opciones;
        do
        {
            //alt+201 ╔, alt+205 ═, alt+187 ╗, alt+186 ║, alt+200 ╚, alt+188 ╝
            Console.WriteLine("╔═════════════════════════════════════════════════════════════╗"); 
            Console.WriteLine("║                    ESTACIONAMIENTO EL PEPE                  ║");
            Console.WriteLine("║        1) Ingresar el vehiculo                              ║");
            Console.WriteLine("║        2) Retira el vehiculo                                ║");
            Console.WriteLine("║        3) Deshacer la última salida                         ║");
            Console.WriteLine("║        4) Mostrar los vehículos en el estacionamiento       ║");
            Console.WriteLine("║        5) Mostrar el próximo vehículo en la lista de espera ║");
            Console.WriteLine("║        6) Salir                                             ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
            Console.WriteLine(" ");
            Console.Write("Ingrese la opcion a realizar: ");
            elegir = Convert.ToInt32(Console.ReadLine());
            switch (elegir)
            {
                case 1:
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("╔════════════════════════╗");
                        Console.WriteLine("║    Ingrese los datos   ║");
                        Console.WriteLine("╚════════════════════════╝");
                        Console.WriteLine(" ");
                        Console.Write("Ingrese la marca: ");
                        marca = Console.ReadLine();
                        Console.Write("Ingrese la placa: ");
                        placa = Console.ReadLine();
                        estacionamiento.IngresarVehiculo(marca, placa);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("╔════════════════════════╗");
                        Console.WriteLine("║   Retira el vehiculo   ║");
                        Console.WriteLine("╚════════════════════════╝");
                        Console.WriteLine(" ");
                        Console.Write("Ingrese la placa: ");
                        placa = Console.ReadLine();
                        estacionamiento.RetiraVehiculo(placa);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("╔═══════════════════════════════╗");
                        Console.WriteLine("║   Deshacer la última salida   ║");
                        Console.WriteLine("╚═══════════════════════════════╝");
                        Console.WriteLine(" ");
                        estacionamiento.Deshacer();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("╔═══════════════════════════╗");
                        Console.WriteLine("║   Mostrar los vehículos   ║");
                        Console.WriteLine("╚═══════════════════════════╝");
                        Console.WriteLine(" ");
                        estacionamiento.MostrarEstacionamiento();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("╔════════════════════════════════════╗");
                        Console.WriteLine("║   Mostrar los proximos vehículos   ║");
                        Console.WriteLine("╚════════════════════════════════════╝");
                        Console.WriteLine(" ");
                        estacionamiento.EnEspera();
                        break;
                    }
                case 6:
                    {
                        salir = true;
                        break;
                    }
                default:
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("╔══════════════════════════╗");
                        Console.WriteLine("║   Opcion no disponible   ║");
                        Console.WriteLine("╚══════════════════════════╝");
                        Console.WriteLine(" ");
                        return;
                    }
            }
            if (!salir)
            {
                Console.WriteLine(" ");
                Console.WriteLine("╔═════════════════════════════════════════╗");
                Console.WriteLine("║   ¿Desea realizar otra operación? S/N   ║");
                Console.WriteLine("╚═════════════════════════════════════════╝");
                Console.WriteLine(" ");
                opciones = Convert.ToString(Console.ReadLine().ToUpper());
                if (opciones != "S" && opciones != "SI")
                {
                    salir = true;
                }
                Console.Clear();
            }
        } while (!salir);
    }
}