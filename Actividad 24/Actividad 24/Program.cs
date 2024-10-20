using System;
class Vehiculo
{
    public string Placa { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string TipoReparacion { get; set; }
    public string Prioridad { get; set; }
    public Vehiculo(string placa, string marca, string modelo, string tipoReparacion, string prioridad)
    {
        Placa = placa;
        Marca = marca;
        Modelo = modelo;
        TipoReparacion = tipoReparacion;
        Prioridad = prioridad;
    }
    public void MostrarInfo()
    {
        Console.WriteLine($"Placa: {Placa}, Marca: {Marca}, Modelo: {Modelo}, Reparación: {TipoReparacion}, Prioridad: {Prioridad}");
    }
}
class Nodo
{
    public Vehiculo Vehiculo { get; set; }
    public Nodo Siguiente { get; set; }
    public Nodo(Vehiculo vehiculo)
    {
        Vehiculo = vehiculo;
        Siguiente = null;
    }
}
class Cola
{
    private Nodo principal;
    private Nodo ultimo;
    public Cola()
    {
        principal = null;
        ultimo = null;
    }
    public void Encolar(Vehiculo vehiculo)
    {
        Nodo nuevoNodo = new Nodo(vehiculo);
        if (ultimo == null)
        {
            principal = nuevoNodo;
            ultimo = nuevoNodo;
        }
        else
        {
            ultimo.Siguiente = nuevoNodo;
            ultimo = nuevoNodo;
        }
        Console.WriteLine($"Vehículo {vehiculo.Placa} registrado en la cola para reparación rutinaria.");
    }
    public Vehiculo Desencolar()
    {
        if (principal == null)
        {
            Console.WriteLine("No hay vehículos en la cola de reparaciones rutinarias.");
            return null;
        }
        Vehiculo vehiculo = principal.Vehiculo;
        principal = principal.Siguiente;
        if (principal == null)
        {
            ultimo = null;
        }
        return vehiculo;
    }
    public void MostrarCola()
    {
        if (principal == null)
        {
            Console.WriteLine("No hay vehículos en la cola.");
            return;
        }
        Nodo actual = principal;
        while (actual != null)
        {
            actual.Vehiculo.MostrarInfo();
            actual = actual.Siguiente;
        }
    }
}
class Pila
{
    private Nodo cima;
    public Pila()
    {
        cima = null;
    }
    public void Apilar(Vehiculo vehiculo)
    {
        Nodo nuevoNodo = new Nodo(vehiculo);
        nuevoNodo.Siguiente = cima;
        cima = nuevoNodo;
        Console.WriteLine($"Vehículo {vehiculo.Placa} registrado en la pila para reparación urgente.");
    }
    public Vehiculo Desapilar()
    {
        if (cima == null)
        {
            Console.WriteLine("No hay vehículos en la pila de reparaciones urgentes.");
            return null;
        }
        Vehiculo vehiculo = cima.Vehiculo;
        cima = cima.Siguiente;
        return vehiculo;
    }
    public void MostrarPila()
    {
        if (cima == null)
        {
            Console.WriteLine("No hay vehículos en la pila.");
            return;
        }
        Nodo actual = cima;
        while (actual != null)
        {
            actual.Vehiculo.MostrarInfo();
            actual = actual.Siguiente;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Cola colaReparaciones = new Cola();
        Pila pilaUrgencias = new Pila();

        bool salir = false;

        while (!salir)
        {
            Console.WriteLine(" ");
            Console.WriteLine("--- TALLER DE REPARACIONES ---");
            Console.WriteLine("1. Registrar vehículo para reparación rutinaria");
            Console.WriteLine("2. Registrar vehículo para reparación urgente");
            Console.WriteLine("3. Atender un vehículo");
            Console.WriteLine("4. Mostrar lista de vehículos pendientes");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    {
                        Console.WriteLine(" ");
                        Vehiculo vehiculoRutinario = CrearVehiculo("rutinaria");
                        colaReparaciones.Encolar(vehiculoRutinario);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(" ");
                        Vehiculo vehiculoUrgente = CrearVehiculo("urgente");
                        pilaUrgencias.Apilar(vehiculoUrgente);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(" ");
                        AtenderVehiculo(pilaUrgencias, colaReparaciones);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Vehículos en la pila de urgencias:");
                        pilaUrgencias.MostrarPila();
                        Console.WriteLine(" ");
                        Console.WriteLine("Vehículos en la cola de reparaciones rutinarias:");
                        colaReparaciones.MostrarCola();
                        break;
                    }
                case 5:
                    {
                        salir = true;
                        break;
                    }
                default:
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Opción no válida.");
                        break;
                    }
            }
        }
    }
    static Vehiculo CrearVehiculo(string prioridad)
    {
        Console.Write("Ingrese la placa del vehículo: ");
        string placa = Console.ReadLine();
        Console.Write("Ingrese la marca del vehículo: ");
        string marca = Console.ReadLine();
        Console.Write("Ingrese el modelo del vehículo: ");
        string modelo = Console.ReadLine();
        Console.Write("Ingrese el tipo de reparación: ");
        string tipoReparacion = Console.ReadLine();

        return new Vehiculo(placa, marca, modelo, tipoReparacion, prioridad);
    }
    static void AtenderVehiculo(Pila pilaUrgencias, Cola colaReparaciones)
    {
        Vehiculo vehiculoAtendido = pilaUrgencias.Desapilar();
        if (vehiculoAtendido == null)
        {
            vehiculoAtendido = colaReparaciones.Desencolar();
        }
        if (vehiculoAtendido != null)
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Atendiendo al vehículo con placa {vehiculoAtendido.Placa} (Prioridad: {vehiculoAtendido.Prioridad})");
        }
        else
        {
            Console.WriteLine(" ");
            Console.WriteLine("No hay vehículos pendientes de atención.");
        }
    }
}