using System;
using System.Collections.Generic;
using System.Linq;

public class Cliente
{
    public string Nombre { get; set; }
    public string Correo { get; set; }
    public string Telefono { get; set; }

    public Cliente(string nombre, string correo, string telefono)
    {
        Nombre = nombre;
        Correo = correo;
        Telefono = telefono;
    }

    public override string ToString()
    {
        return $"Nombre: {Nombre}, Correo: {Correo}, Teléfono: {Telefono}";
    }
}

public class ClienteRegular : Cliente
{
    public ClienteRegular(string nombre, string correo, string telefono)
        : base(nombre, correo, telefono)
    {
    }
}

public class ClienteVIP : Cliente
{
    public double Descuento { get; private set; }

    public ClienteVIP(string nombre, string correo, string telefono, double descuento = 0.1)
        : base(nombre, correo, telefono)
    {
        Descuento = descuento;
    }

    public override string ToString()
    {
        return base.ToString() + $", Descuento: {Descuento * 100}%";
    }
}

public class Plato
{
    public string Nombre { get; set; }
    public double Precio { get; set; }

    public Plato(string nombre, double precio)
    {
        Nombre = nombre;
        Precio = precio;
    }

    public override string ToString()
    {
        return $"{Nombre} - ${Precio:F2}";
    }
}

public class Reserva
{
    public int NumeroReserva { get; set; }
    public DateTime FechaHora { get; set; }
    public Cliente Cliente { get; set; }
    public List<Plato> Platos { get; set; }
    public double Total { get; private set; }

    public Reserva(int numeroReserva, DateTime fechaHora, Cliente cliente, List<Plato> platos)
    {
        NumeroReserva = numeroReserva;
        FechaHora = fechaHora;
        Cliente = cliente;
        Platos = platos;
        CalcularTotal();
    }

    private void CalcularTotal()
    {
        Total = Platos.Sum(plato => plato.Precio);
        if (Cliente is ClienteVIP clienteVIP)
        {
            Total *= (1 - clienteVIP.Descuento);
        }
    }

    public override string ToString()
    {
        return $"Reserva No: {NumeroReserva}, Fecha: {FechaHora}, Cliente: {Cliente.Nombre}, Total: ${Total:F2}";
    }
}

public class Restaurante
{
    private List<Cliente> clientes = new List<Cliente>();
    private List<Reserva> reservas = new List<Reserva>();
    private int contadorReservas = 1;

    public void RegistrarCliente(Cliente cliente)
    {
        clientes.Add(cliente);
        Console.WriteLine("Cliente registrado exitosamente.");
    }

    public void RegistrarReserva(Cliente cliente, DateTime fechaHora, List<Plato> platos)
    {
        var reserva = new Reserva(contadorReservas++, fechaHora, cliente, platos);
        reservas.Add(reserva);
        Console.WriteLine("Reserva registrada exitosamente.");
    }

    public void MostrarClientes()
    {
        foreach (var cliente in clientes)
        {
            Console.WriteLine(cliente);
        }
    }

    public void MostrarReservas()
    {
        foreach (var reserva in reservas)
        {
            Console.WriteLine(reserva);
        }
    }

    public Cliente BuscarClientePorNombre(string nombre)
    {
        return clientes.FirstOrDefault(c => c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
    }

    public Reserva BuscarReservaPorNumero(int numeroReserva)
    {
        return reservas.FirstOrDefault(r => r.NumeroReserva == numeroReserva);
    }

    public static void Main()
    {
        Restaurante restaurante = new Restaurante();

        while (true)
        {
            Console.WriteLine("Hotel Trivago");
            Console.WriteLine("1. Registrar Cliente Regular");
            Console.WriteLine("2. Registrar Cliente VIP");
            Console.WriteLine("3. Registrar Reserva");
            Console.WriteLine("4. Mostrar Detalles de Clientes");
            Console.WriteLine("5. Mostrar Detalles de Reservas");
            Console.WriteLine("6. Buscar Cliente por Nombre");
            Console.WriteLine("7. Buscar Reserva por Número");
            Console.WriteLine("8. Salir");
            Console.Write("Que accion desea realizar? ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    {
                        Console.Write("Ingrese nombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese correo: ");
                        string correo = Console.ReadLine();
                        Console.Write("Ingrese teléfono: ");
                        string telefono = Console.ReadLine();
                        restaurante.RegistrarCliente(new ClienteRegular(nombre, correo, telefono));
                        break;
                    }
                case 2:
                    {
                        Console.Write("Ingrese nombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese correo: ");
                        string correo = Console.ReadLine();
                        Console.Write("Ingrese teléfono: ");
                        string telefono = Console.ReadLine();
                        restaurante.RegistrarCliente(new ClienteVIP(nombre, correo, telefono));
                        break;
                    }
                case 3:
                    {
                        Console.Write("Ingrese nombre del cliente: ");
                        string nombre = Console.ReadLine();
                        Cliente cliente = restaurante.BuscarClientePorNombre(nombre);
                        if (cliente == null)
                        {
                            Console.WriteLine("Cliente no encontrado.");
                            break;
                        }
                        Console.Write("Ingrese fecha y hora (yyyy-mm-dd hh:mm): ");
                        DateTime fechaHora = DateTime.Parse(Console.ReadLine());

                        List<Plato> platos = new List<Plato>();
                        while (true)
                        {
                            Console.Write("Ingrese nombre del plato (o 'fin' para terminar): ");
                            string nombrePlato = Console.ReadLine();
                            if (nombrePlato.ToLower() == "fin") break;

                            Console.Write("Ingrese precio del plato: ");
                            double precioPlato = double.Parse(Console.ReadLine());
                            platos.Add(new Plato(nombrePlato, precioPlato));
                        }

                        restaurante.RegistrarReserva(cliente, fechaHora, platos);
                        break;
                    }
                case 4:
                    {
                        restaurante.MostrarClientes();
                        break;
                    }
                case 5:
                    {
                        restaurante.MostrarReservas();
                        break;
                    }
                case 6:
                    {
                        Console.Write("Ingrese nombre del cliente: ");
                        string nombre = Console.ReadLine();
                        Cliente cliente = restaurante.BuscarClientePorNombre(nombre);
                        if (cliente != null)
                        {
                            Console.WriteLine(cliente);
                        }
                        else
                        {
                            Console.WriteLine("Cliente no encontrado.");
                        }
                        break;
                    }
                case 7:
                    {
                        Console.Write("Ingrese número de reserva: ");
                        int numeroReserva = int.Parse(Console.ReadLine());
                        Reserva reserva = restaurante.BuscarReservaPorNumero(numeroReserva);
                        if (reserva != null)
                        {
                            Console.WriteLine(reserva);
                        }
                        else
                        {
                            Console.WriteLine("Reserva no encontrada.");
                        }
                        break;
                    }
                case 8:
                    {
                        return;
                    }
                default:
                    {
                        Console.WriteLine("Opción no válida.");
                        break;
                    }
            }
        }
    }
}
