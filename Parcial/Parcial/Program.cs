using Parcial;
using static System.Runtime.InteropServices.JavaScript.JSType;
public class Tienda
{
    private List<Cliente> clientes = new List<Cliente>();
    private List<Pedido> pedidos = new List<Pedido>();

    public void RegistrarCliente(Cliente cliente)
    {
        clientes.Add(cliente);
    }

    public void RegistrarPedido(Pedido pedido)
    {
        if (!pedidos.Any(p => p.NumeroPedido == pedido.NumeroPedido))
        {
            pedidos.Add(pedido);
        }
        else
        {
            Console.WriteLine("Error: Número de pedido duplicado.");
        }
    }

    public Cliente BuscarClientePorNombre(string nombre)
    {
        return clientes.FirstOrDefault(c => c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
    }

    public Pedido BuscarPedidoPorNumero(int numero)
    {
        return pedidos.FirstOrDefault(p => p.NumeroPedido == numero);
    }

    public void MostrarClientes()
    {
        foreach (var cliente in clientes)
        {
            Console.WriteLine($"Nombre: {cliente.Nombre}, Email: {cliente.CorreoElectronico}, Dirección: {cliente.Direccion}, Fecha de Registro: {cliente.FechaRegistro}");
            if (cliente is ClientePremium premium)
            {
                Console.WriteLine($"Descuento: {premium.Descuento}%");
            }
        }
    }

    public void MostrarPedidos()
    {
        foreach (var pedido in pedidos)
        {
            Console.WriteLine($"Número: {pedido.NumeroPedido}, Fecha: {pedido.Fecha}, Cliente: {pedido.Cliente.Nombre}, Total: {pedido.Total}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Tienda tienda = new Tienda();
        bool salir = false;
        string op;
        do
        {
            int eleccion;
            Console.WriteLine("Menu Principal");
            Console.WriteLine("1) Registrar Cliente Estandar");
            Console.WriteLine("2) Registrar Cliente Premium");
            Console.WriteLine("3) Registrar Pedido");
            Console.WriteLine("4) Mostrar Detalles de Cliente");
            Console.WriteLine("5) Mostrar Detalles de Pedido");
            Console.WriteLine("6) Buscar Cliente por Nombre");
            Console.WriteLine("7) Buscar Pedido por Número");
            Console.WriteLine("8) Salir");
            Console.Write("Que desea realizar? ");
            eleccion = Convert.ToInt32(Console.ReadLine());
            switch (eleccion)
            {
                case 1:
                    {
                        Console.WriteLine("Registrar Cliente");
                        Console.Write("Nombre del Cliente: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Correo Electrónico: ");
                        string correo = Console.ReadLine();
                        Console.Write("Dirección: ");
                        string direccion = Console.ReadLine();

                        Cliente cliente = new Cliente(nombre, correo, direccion);
                        tienda.RegistrarCliente(cliente);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Registrar Cliente Premium");
                        Console.Write("Nombre del Cliente: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Correo Electrónico: ");
                        string correo = Console.ReadLine();
                        Console.Write("Dirección: ");
                        string direccion = Console.ReadLine();
                        Console.Write("Descuento (%): ");
                        double descuento = Convert.ToDouble(Console.ReadLine());

                        ClientePremium clientePremium = new ClientePremium(nombre, correo, direccion, descuento);
                        tienda.RegistrarCliente(clientePremium);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Registrar Pedido");
                        int numeroPedido = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nombre del Cliente: ");
                        string nombreCliente = Console.ReadLine();
                        Cliente cliente = tienda.BuscarClientePorNombre(nombreCliente);

                        if (cliente != null)
                        {
                            Console.Write("Monto del Pedido: ");
                            double monto = Convert.ToDouble(Console.ReadLine());

                            Pedido pedido = new Pedido(numeroPedido, cliente, monto);
                            tienda.RegistrarPedido(pedido);
                        }
                        else
                        {
                            Console.WriteLine("Cliente no encontrado.");
                        }
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Mostrar Detalles de Cliente");
                        tienda.MostrarClientes();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Mostrar Detalles de Pedido");
                        tienda.MostrarPedidos();
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Buscar Cliente por Nombre");
                        Console.Write("Ingrese el nombre del cliente: ");
                        string nombre = Console.ReadLine();
                        Cliente cliente = tienda.BuscarClientePorNombre(nombre);

                        if (cliente != null)
                        {
                            Console.WriteLine($"Nombre: {cliente.Nombre}, Email: {cliente.CorreoElectronico}, Dirección: {cliente.Direccion}, Fecha de Registro: {cliente.FechaRegistro}");
                            if (cliente is ClientePremium premium)
                            {
                                Console.WriteLine($"Descuento: {premium.Descuento}%");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Cliente no encontrado.");
                        }
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Buscar Pedido por Número");
                        Console.Write("Ingrese el número del pedido: ");
                        int numeroPedido = Convert.ToInt32(Console.ReadLine());
                        Pedido pedido = tienda.BuscarPedidoPorNumero(numeroPedido);

                        if (pedido != null)
                        {
                            Console.WriteLine($"Número: {pedido.NumeroPedido}, Fecha: {pedido.Fecha}, Cliente: {pedido.Cliente.Nombre}, Total: {pedido.Total}");
                        }
                        else
                        {
                            Console.WriteLine("Pedido no encontrado.");
                        }
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("ABANDONANDO EL PROGRAMA");
                        salir = true;
                        break;
                    }
                default:
                    {
                        return;
                    }
            }
            Console.WriteLine("Desea Volver? S/N");
            op = Convert.ToString(Console.ReadLine().ToUpper());
            Console.Clear();
        }
        while (op == "S");
    }
}