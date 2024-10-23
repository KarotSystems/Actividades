using Proyecto_02_Consola;
class Program
{
    static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();
        Bibliotecario bibliotecario = new Bibliotecario("Mario", "A001");
        Lector lector = new Lector("Pedro", "L001");
        bool salir = false;
        string opciones;
        do
        {
            Console.WriteLine("╔═════════════════════════════════════════════╗");
            Console.WriteLine("║               BIBLIOTECA UNDERTALE          ║");
            Console.WriteLine("║        1) Agregar Libro                     ║");
            Console.WriteLine("║        2) Buscar Libro                      ║");
            Console.WriteLine("║        3) Eliminar Libro                    ║");
            Console.WriteLine("║        4) Solicitar Préstamo                ║");
            Console.WriteLine("║        5) Devolver Libro                    ║");
            Console.WriteLine("║        6) Agregar usuario                   ║");
            Console.WriteLine("║        7) Salir                             ║");
            Console.WriteLine("╚═════════════════════════════════════════════╝");
            Console.WriteLine(" ");
            Console.Write("Seleccione una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("╔════════════════════════╗");
                        Console.WriteLine("║     Agregar Libro      ║");
                        Console.WriteLine("╚════════════════════════╝");
                        Console.WriteLine(" ");
                        Console.Write("Ingrese el titulo: ");
                        string titulo = Console.ReadLine();
                        Console.Write("Ingrese el autor: ");
                        string autor = Console.ReadLine();
                        Console.Write("Ingrese el ISBN: ");
                        string ISBN = Console.ReadLine();
                        Console.Write("Ingrese el Genero: ");
                        string genero = Console.ReadLine();

                        Libro nuevoLibro = new Libro(titulo, autor, ISBN, genero);
                        biblioteca.AgregarLibro(biblioteca, nuevoLibro);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("╔════════════════════════╗");
                        Console.WriteLine("║      Buscar Libro      ║");
                        Console.WriteLine("╚════════════════════════╝");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine("╔════════════════════════════════════════════╗");
                        Console.WriteLine("║     ¿Que opcion le resulta mas facil?      ║");
                        Console.WriteLine("╚════════════════════════════════════════════╝");
                        Console.WriteLine(" ");
                        Console.WriteLine("1) Buscar por titulo");
                        Console.WriteLine("2) Buscar por ISBN");
                        Console.Write("Seleccione una opción: ");
                        string buscar = Console.ReadLine();
                        if (buscar == "1")
                        {
                            Console.WriteLine(" ");
                            Console.Write("Ingrese el título del libro: ");
                            string buscarTitulo = Console.ReadLine();
                            biblioteca.BuscarLibroPorTitulo(buscarTitulo);
                        }
                        else if (buscar == "2")
                        {
                            Console.WriteLine(" ");
                            Console.Write("Ingrese el ISBN del libro: ");
                            string buscarISBN = Console.ReadLine();
                            biblioteca.BuscarLibroPorISBN(buscarISBN);
                        }
                        else
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Opción no válida.");
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("╔═════════════════════════╗");
                        Console.WriteLine("║     Eliminar Libro      ║");
                        Console.WriteLine("╚═════════════════════════╝");
                        Console.WriteLine(" ");
                        Console.Write("Ingrese el ISBN del libro que desea eliminar: ");
                        string eliminarISBN = Console.ReadLine();
                        biblioteca.EliminarLibro(biblioteca, eliminarISBN);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("╔═════════════════════════════╗");
                        Console.WriteLine("║     Solicitar Préstamo      ║");
                        Console.WriteLine("╚═════════════════════════════╝");
                        Console.WriteLine(" ");
                        Console.Write("Ingrese el ISBN del libro que desea solicitar: ");
                        string prestamoISBN = Console.ReadLine();
                        biblioteca.SolicitarPrestamo(lector, prestamoISBN);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("╔═════════════════════════╗");
                        Console.WriteLine("║     Devolver Libro      ║");
                        Console.WriteLine("╚═════════════════════════╝");
                        Console.WriteLine(" ");
                        Console.WriteLine("Ingrese el ISBN del libro que desea devolver:");
                        string devolucionISBN = Console.ReadLine();
                        biblioteca.DevolverLibro(devolucionISBN);
                        break; 
                    }
                case 6:
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("╔══════════════════════════╗");
                        Console.WriteLine("║     Agregar usuario      ║");
                        Console.WriteLine("╚══════════════════════════╝");
                        Console.WriteLine(" ");
                        Console.Write("Ingrese el Nombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese el ID: ");
                        string ID = Console.ReadLine();
                        Usuario.GuardarUsuario(nombre, ID);
                        break;
                    }
                case 7:
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