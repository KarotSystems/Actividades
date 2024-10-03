string opcion;
int eleccion;
string nombre;
do
{
    Queue<string> Cola = new Queue<string>();
    Console.WriteLine("--------- Banrural ---------");
    Console.WriteLine("1. Agregar cliente a la cola");
    Console.WriteLine("2. Atender cliente");
    Console.WriteLine("3. Ver el siguiente cliente a atender");
    Console.WriteLine("4. Mostrar todos los clientes en la cola");
    Console.WriteLine("5. Ver número total de clientes en espera");
    Console.WriteLine("6. Salir");
    Console.Write("Eliga una opcion: ");
    eleccion = Convert.ToInt32(Console.ReadLine());
    switch(eleccion)
    {
        case 1:
            {
                Console.Write("Ingresando Cliente: ");
                nombre = Convert.ToString(Console.ReadLine());
                Cola.Enqueue(nombre);
                Console.WriteLine($"{nombre} ha sido agregad@ cola");
                break;
            }
        case 2:
            {
                if (Cola.Count > 0)
                {
                    string atender = Cola.Dequeue();
                    Console.WriteLine($"Pase adelante {atender}");
                }
                else
                {
                    Console.WriteLine("No hay, a receso");
                }
                break;
            }
        case 3:
            {
                if (Cola.Count > 0)
                {
                    string siguiente = Cola.Peek();
                    Console.WriteLine($"Pase adelante {siguiente}");
                }
                else
                {
                    Console.WriteLine("No hay, a receso");
                }
                break;
            }
        case 4:
            {
                if (Cola.Count > 0)
                {
                    Console.WriteLine("Clientes en espera: ");
                    foreach (string Listado in Cola)
                    {
                        Console.WriteLine($"{Listado}");
                    }
                }
                else
                {
                    Console.WriteLine("No hay, a receso");
                }
                break;
            }
        case 5:
            {
                if (Cola.Count > 0)
                {
                    Console.WriteLine($"Hay {Cola.Count} en espera");
                }
                else
                {
                    Console.WriteLine("No hay, a receso");
                }
                break;
            }
        case 6:
            {
                Console.WriteLine("Saliendo del sistema");
                break;
            }
        default:
            {
                Console.WriteLine("Opción no válida, intente nuevamente.");
                break;
            }
    }
    Console.WriteLine("Desea reiniciar? S/N");
    opcion = Convert.ToString(Console.ReadLine().ToUpper());
}
while (eleccion != 6 || opcion == "S" || opcion == "SI");