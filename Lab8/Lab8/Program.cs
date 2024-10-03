string opcion;
int eleccion;
string nombre;

Stack<string> tareasUrgentes = new Stack<string>();
Queue<string> tareasRegulares = new Queue<string>();

do
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("-------------------------------------");
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("--------- Menu Interactivo ---------");
    Console.WriteLine("1. Agregar tarea urgente");
    Console.WriteLine("2. Eliminar tarea urgente");
    Console.WriteLine("3. Mostrar todas las tareas urgentes");
    Console.WriteLine("4. Agregar tarea regular");
    Console.WriteLine("5. Eliminar tarea regular");
    Console.WriteLine("6. Mostrar todas las tareas regulares");
    Console.WriteLine("7. Salir");
    Console.Write("Eliga una opcion: ");
    eleccion = Convert.ToInt32(Console.ReadLine());
    switch (eleccion)
    {
        case 1:
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("-------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Agregar tarea urgente: ");
                nombre = Convert.ToString(Console.ReadLine());
                tareasUrgentes.Push(nombre);
                Console.WriteLine($"{nombre} ha sido agregado");
                break;
            }
        case 2:
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("-------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (tareasUrgentes.Count > 0)
                {
                    string tareaEliminada = tareasUrgentes.Pop();
                    Console.WriteLine($"Tarea urgente: {tareaEliminada}");
                    Console.WriteLine("ha sido eliminada.");
                }
                else
                {
                    Console.WriteLine("No hay tareas urgentes para eliminar.");
                }
                break;
            }
        case 3:
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("-------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (tareasUrgentes.Count > 0)
                {
                    Console.WriteLine("Tareas urgentes");
                    foreach(string buscar in tareasUrgentes)
                    {
                        Console.WriteLine(buscar);
                    }
                }
                else
                {
                    Console.WriteLine("No hay tareas urgentes.");
                }
                break;
            }
        case 4:
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("-------------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Agregar tarea regulares: ");
                nombre = Convert.ToString(Console.ReadLine());
                tareasRegulares.Enqueue(nombre);
                Console.WriteLine($"{nombre} ha sido agregado");
                break;
            }
        case 5:
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("-------------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                if (tareasRegulares.Count > 0)
                {
                    string tareaEliminada = tareasRegulares.Dequeue();
                    Console.WriteLine($"Tarea regular: {tareaEliminada}");
                    Console.WriteLine("ha sido eliminada.");
                }
                else
                {
                    Console.WriteLine("No hay tareas regulares para eliminar.");
                }
                break;
            }
        case 6:
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("-------------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                if (tareasRegulares.Count > 0)
                {
                    Console.WriteLine("Tareas regulares");
                    foreach (string buscar in tareasRegulares)
                    {
                        Console.WriteLine(buscar);
                    }
                }
                else
                {
                    Console.WriteLine("No hay tareas regulares.");
                }
                break;
            }
        case 7:
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("-------------------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Saliendo del sistema");
                break;
            }
        default:
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("-------------------------------------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Opción no válida, intente nuevamente.");
                break;
            }
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("-------------------------------------");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Desea reiniciar? S/N");
    opcion = Convert.ToString(Console.ReadLine().ToUpper());
    Console.Clear();
}
while (eleccion != 7 || opcion == "S" || opcion == "SI");