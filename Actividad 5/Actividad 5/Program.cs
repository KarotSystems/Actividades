using Actividad_5;

class Program
{
    static void Main(string[] args)
    {
        EstudianteManager manager = new EstudianteManager();
        string opcion;

        do
        {
            Console.WriteLine(" ");
            Console.WriteLine("Menu");
            Console.WriteLine("1) Agregar Estudiante");
            Console.WriteLine("2) Listar todos los estudiantes");
            Console.WriteLine("3) Ordenar por alfabeto");
            Console.WriteLine("4) Buscar estudiante por carnet y mostrar sus datos");
            Console.WriteLine("5) Eliminar un estudiante por carnet");
            Console.WriteLine("6) Salir");
            string op = Console.ReadLine();
            Console.WriteLine(" ");
            switch (op)
            {
                case "1":
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Ha seleccionado Agregar estudiantes");
                        Console.WriteLine("Ingrese la cantidad de estudiantes a agregar:");
                        int cantidad = Convert.ToInt32(Console.ReadLine());
                        manager.AgregarEstudiantes(cantidad);
                        break;
                    }
                case "2":
                    {
                        manager.ListarEstudiantes();
                        break;
                    }
                case "3":
                    {
                        manager.OrdenarPorNombre();
                        break;
                    }
                case "4":
                    {
                        Console.Write("Ingrese el carnet a localizar: ");
                        int carnetABuscar = Convert.ToInt32(Console.ReadLine());
                        manager.BuscarPorCarnet(carnetABuscar);
                        break;
                    }
                case "5":
                    {
                        Console.Write("Ingrese el carnet a eliminar: ");
                        int carnetAEliminar = Convert.ToInt32(Console.ReadLine());
                        manager.EliminarPorCarnet(carnetAEliminar);
                        break;
                    }
                case "6":
                    {
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Opción no válida.");
                        break;
                    }
            }
            Console.WriteLine("Desea regresar al inicio? (SI/NO)");
            opcion = Console.ReadLine().ToUpper();
        }
        while (opcion != "NO" && opcion != "N");
    }
}