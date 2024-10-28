int elegir;
string placa;
string marca;
bool salir = false;
string opciones;
do
{
    Console.WriteLine("╔═════════════════════════════════════════════════════╗");
    Console.WriteLine("║                       Listas                        ║");
    Console.WriteLine("║        1) Lista arreglo                             ║");
    Console.WriteLine("║        2) lista Secuencial                          ║");
    Console.WriteLine("║        3) Lista secuencial en lista enlazada        ║");
    Console.WriteLine("║        4) Salir                                     ║");
    Console.WriteLine("╚═════════════════════════════════════════════════════╝");
    Console.WriteLine(" ");
    Console.Write("Ingrese la opcion a realizar: ");
    elegir = Convert.ToInt32(Console.ReadLine());
    switch (elegir)
    {
        case 1:
            {
                Console.WriteLine(" ");
                Console.WriteLine("╔════════════════════╗");
                Console.WriteLine("║    Lista arreglo   ║");
                Console.WriteLine("╚════════════════════╝");
                Console.WriteLine(" ");
                int[] numeros = { 3, 7, 1, 9, 2, 5 };

                Console.WriteLine("Ingrese el número que desea buscar en el arreglo:");
                int numeroBuscado = int.Parse(Console.ReadLine());

                int indice = BuscarSecuencialEnArreglo(numeros, numeroBuscado);

                if (indice != -1)
                {
                    Console.WriteLine($"El número {numeroBuscado} fue encontrado en el índice {indice}.");
                }
                else
                {
                    Console.WriteLine($"El número {numeroBuscado} no se encuentra en el arreglo.");
                }
                static int BuscarSecuencialEnArreglo(int[] arreglo, int valor)
                {
                    for (int i = 0; i < arreglo.Length; i++)
                    {
                        if (arreglo[i] == valor)
                        {
                            return i;
                        }
                    }
                    return -1;
                }
                break;
            }
        case 2:
            {
                Console.WriteLine(" ");
                Console.WriteLine("╔══════════════════════╗");
                Console.WriteLine("║   lista Secuencial   ║");
                Console.WriteLine("╚══════════════════════╝");
                Console.WriteLine(" ");
                List<int> numeros = new List<int> { 3, 7, 1, 9, 2, 5 };

                Console.WriteLine("Ingrese el número que desea buscar en la lista:");
                int numeroBuscado = int.Parse(Console.ReadLine());

                int indice = BuscarSecuencialEnLista(numeros, numeroBuscado);

                if (indice != -1)
                {
                    Console.WriteLine($"El número {numeroBuscado} fue encontrado en el índice {indice}.");
                }
                else
                {
                    Console.WriteLine($"El número {numeroBuscado} no se encuentra en la lista.");
                }
                static int BuscarSecuencialEnLista(List<int> lista, int valor)
                {
                    for (int i = 0; i < lista.Count; i++)
                    {
                        if (lista[i] == valor)
                        {
                        return i;
                    }
                }
                return -1;
            }
            break;
            }
        case 3:
            {
                Console.WriteLine(" ");
                Console.WriteLine("╔═══════════════════════════════╗");
                Console.WriteLine("║   Deshacer la última salida   ║");
                Console.WriteLine("╚═══════════════════════════════╝");
                Console.WriteLine(" ");
                LinkedList<int> listaEnlazada = new LinkedList<int>();

                listaEnlazada.AddLast(3);
                listaEnlazada.AddLast(7);
                listaEnlazada.AddLast(1);
                listaEnlazada.AddLast(9);
                listaEnlazada.AddLast(2);
                listaEnlazada.AddLast(5);

                Console.WriteLine("Ingrese el número que desea buscar en la lista enlazada:");
                int numeroBuscado = int.Parse(Console.ReadLine());

                int indice = BuscarSecuencialEnListaEnlazada(listaEnlazada, numeroBuscado);

                if (indice != -1)
                {
                    Console.WriteLine($"El número {numeroBuscado} fue encontrado en el índice {indice}.");
                }
                else
                {
                    Console.WriteLine($"El número {numeroBuscado} no se encuentra en la lista enlazada.");
                }

            static int BuscarSecuencialEnListaEnlazada(LinkedList<int> lista, int valor)
            {
                int indice = 0;

                LinkedListNode<int> nodoActual = lista.First;
                while (nodoActual != null)
                {
                    if (nodoActual.Value == valor)
                    {
                        return indice;
                    }
                    nodoActual = nodoActual.Next;
                    indice++;
                }

                return -1;
            }
            break;
            }
        case 4:
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
