using Actividad_10;

class Program
{
    static void Menu()
    {
        Productos Biblioteca = new Productos();
        do
        {
            Console.WriteLine("Opciones");
            Console.WriteLine("1. Agregar Libros");
            Console.WriteLine("2. Mostrar Libros");
            Console.WriteLine("3. Buscar Libro");
            Console.WriteLine("4. Salir");

            Console.Write("Ingrese el número de la opción que desea realizar: ");
            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 4)
            {
                Console.WriteLine("Opción no válida. Ingrese un número del 1 al 4.");
                Console.Write("Ingrese el número de la opción que desea realizar: ");
            }

            switch (opcion)
            {
                case 1:
                    Biblioteca.AgregarProducto();
                    Biblioteca.LimpiarConsola();
                    break;
                case 2:
                    Biblioteca.MostrarProducto();
                    Biblioteca.LimpiarConsola();
                    break;
                case 3:
                    Console.WriteLine("Ingrese el nombre del Producto: ");
                    string nombre = Console.ReadLine();
                    Biblioteca.BuscarProducto(nombre);
                    Biblioteca.LimpiarConsola();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Programa terminado. ¡Muchas Gracias!");
                    Environment.Exit(0);
                    break;
            }
        } while (true);
    }
    static void Main(string[] args)
    {
        Menu();
    }
}