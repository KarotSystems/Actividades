using Laboratorio_5;
using System.Runtime.ConstrainedExecution;
using System.Threading;

List<Tarea> tareas = new List<Tarea>();
string opcion;
string eleccion;
string mas;
do
{
    Console.WriteLine("Escuela la milagrosa");
    Console.WriteLine("1) Añadir tarea");
    Console.WriteLine("2) Ver todas las tareas");
    Console.WriteLine("3) Marcar Tarea como completa");
    Console.WriteLine("4) Salir");
    Console.Write("Seleccione la accion a realizar: ");
    eleccion = Convert.ToString(Console.ReadLine());
    switch (eleccion)
    {
        case "1":
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("Ha elegido añadir tarea");
                Console.WriteLine("Ingrese el nombre de la tarea");
                string nombre = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Ingrese una breve descripcion de la tarea");
                string descripcion = Convert.ToString(Console.ReadLine());
                tareas.Add(new Tarea(nombre, descripcion));
                Console.WriteLine("Tarea añadida exitosamente.");
                Console.WriteLine("-------------------");
                break;
                }
            case "2":
                {
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Ha elegido ver tareas");
                    if (tareas.Count == 0)
                    {
                        Console.WriteLine("No hay tareas disponibles");
                    }
                    else
                    {
                        for (int x = 0; x < tareas.Count; x++)
                        {
                            Tarea tarea = tareas[x];
                            string estado;
                            if (tarea.Completada)
                            {
                                estado = "Completada";
                            }
                            else
                            {
                                estado = "Pendiente";
                            }
                            Console.WriteLine($"{x + 1}. {tarea.Nombre} - {estado}");
                            Console.WriteLine($"   Descripción: {tarea.Descripcion}");
                        }
                    }
                    Console.WriteLine("-------------------");
                break;
                }
            case "3":
                {
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Ha elegido Marcar Tarea");
                    if (tareas.Count == 0)
                    {
                        Console.WriteLine("No hay tareas disponibles para completar.");
                    }
                    else
                    {
                        Console.WriteLine("Mostrando tareas disponibles:");
                        for (int x = 0; x < tareas.Count; x++)
                        {
                            Tarea tarea = tareas[x];
                            string estado;
                            if (tarea.Completada)
                            {
                                estado = "Completada";
                            }
                            else
                            {
                                estado = "Pendiente";
                            }
                            Console.WriteLine($"{x + 1}. {tarea.Nombre} - {estado}");
                        }
                        Console.WriteLine("Seleccione el número de la tarea que desea marcar como completada: ");
                        int numero = Convert.ToInt32(Console.ReadLine());
                    if (tareas[numero - 1].Completada = true)
                    {
                        Console.WriteLine("La tarea esta marcada como completa.");
                    }
                    else if (numero <= tareas.Count)
                    {
                        tareas[numero - 1].Completada = true;
                        Console.WriteLine("Tarea marcada como completada exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("Número de tarea no válido.");
                    }
                }
                break;
                }
            case "4":
                {
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Saliendo del sistema");
                    Console.WriteLine("-------------------");
                return;
                }
            default:
                {
                Console.WriteLine("Opcion no disponible");
                return;
                }
        }
    Console.WriteLine("Desea realizar otra operacion? S/N");
    opcion = Convert.ToString(Console.ReadLine().ToUpper());
    Console.Clear();
    } while (opcion == "S");
