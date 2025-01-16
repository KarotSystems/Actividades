using System;
using System.Reflection.Emit;
using System.Collections.Generic;

public class Nodo
{
    public string Nombre { get; set; }
    public Nodo Siguiente { get; set; }

    public Nodo(string nombre)
    {
        Nombre = nombre;
        Siguiente = null;
    }
}

public class ListaEnlazada
{
    private Nodo cabeza;
    private Nodo turnoActual;

    public ListaEnlazada()
    {
        cabeza = null;
        turnoActual = null;
    }
    public void AgregarJugador(string nombre)
    {
        Nodo nuevoJugador = new Nodo(nombre);
        if (cabeza == null)
        {
            cabeza = nuevoJugador;
            turnoActual = cabeza;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoJugador;
        }
        Console.WriteLine($"Jugador {nombre} ha sido agregado");
    }

    public void AvanzarTurno()
    {
        if (turnoActual != null)
        {
            turnoActual = turnoActual.Siguiente ?? cabeza;
            Console.WriteLine($"Turno avanzado. Ahora es el turno de {turnoActual.Nombre}");
        }
        else
        {
            Console.WriteLine("No hay jugadores en la lista");
        }
    }

    public void MostrarJugadorActual()
    {
        if (turnoActual != null)
        {
            Console.WriteLine($"Jugador actual: {turnoActual.Nombre}");
        }
        else
        {
            Console.WriteLine("No hay jugadores en la lista");
        }
    }

    public void MostrarTodosJugadores()
    {
        if (cabeza == null)
        {
            Console.WriteLine("No hay jugadores en la lista");
        }
        else
        {
            Nodo actual = cabeza;
            Console.WriteLine("Jugadores en la lista:");
            while (actual != null)
            {
                Console.WriteLine($"- {actual.Nombre}");
                actual = actual.Siguiente;
            }
        }
    }

    public void EliminarJugador(string nombre)
    {
        if (cabeza == null)
        {
            Console.WriteLine("No hay jugadores para eliminar");
            return;
        }
        if (cabeza.Nombre == nombre)
        {
            cabeza = cabeza.Siguiente;
            turnoActual = cabeza;
            Console.WriteLine($"Jugador {nombre} ha sido eliminado");
            return;
        }

        Nodo actual = cabeza;
        Nodo anterior = null;

        while (actual != null && actual.Nombre != nombre)
        {
            anterior = actual;
            actual = actual.Siguiente;
        }

        if (actual == null)
        {
            Console.WriteLine($"Jugador {nombre} no encontrado");
        }
        else
        {
            anterior.Siguiente = actual.Siguiente;
            if (turnoActual == actual)
            {
                turnoActual = anterior?.Siguiente ?? cabeza;
            }
            Console.WriteLine($"Jugador {nombre} eliminado");
        }
    }
}
public class Program
{
    public static void Main()
    {
        ListaEnlazada listaEnlazada = new ListaEnlazada();
        bool salir = false;

        do
        {
            Console.WriteLine("╔═══════════════════════════════════════════════════╗");
            Console.WriteLine("║        Bienvenidos al Turnos de Videojuegos!!     ║");
            Console.WriteLine("║    1) Agregar Jugador                             ║");
            Console.WriteLine("║    2) Avanzar turno                               ║");
            Console.WriteLine("║    3) Eliminar Jugador                            ║");
            Console.WriteLine("║    4) Mostrar Jugador Actual                      ║");
            Console.WriteLine("║    5) Mostrar todos los jugadores actuales        ║");
            Console.WriteLine("║    6) Salir                                       ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════╝");
            Console.Write("Selecciona una opción: ");
            int eleccion = Convert.ToInt32(Console.ReadLine());

            switch (eleccion)
            {
                case 1:
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("╔════════════════════════════════════════════╗");
                        Console.WriteLine("║        Ha seleccionado Agregar Jugador     ║");
                        Console.WriteLine("╚════════════════════════════════════════════╝");
                        Console.WriteLine(" ");
                        Console.Write("Ingrese el nombre del jugador: ");
                        string nombre = Console.ReadLine();
                        listaEnlazada.AgregarJugador(nombre);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("╔══════════════════════════════════════════╗");
                        Console.WriteLine("║        Ha seleccionado Avanzar Turno     ║");
                        Console.WriteLine("╚══════════════════════════════════════════╝");
                        Console.WriteLine(" ");
                        listaEnlazada.AvanzarTurno();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("╔═════════════════════════════════════════════╗");
                        Console.WriteLine("║        Ha seleccionado Eliminar Jugador     ║");
                        Console.WriteLine("╚═════════════════════════════════════════════╝");
                        Console.WriteLine(" ");
                        Console.Write("Ingrese el nombre del jugador a eliminar: ");
                        string nombreEliminar = Console.ReadLine();
                        listaEnlazada.EliminarJugador(nombreEliminar);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("╔═══════════════════════════════════════════════════╗");
                        Console.WriteLine("║        Ha seleccionado Mostrar Jugador Actual     ║");
                        Console.WriteLine("╚═══════════════════════════════════════════════════╝");
                        Console.WriteLine(" ");
                        listaEnlazada.MostrarJugadorActual();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                        Console.WriteLine("║        Ha seleccionado Mostrar Todos los Jugadores     ║");
                        Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                        Console.WriteLine(" ");
                        Console.WriteLine("Ha seleccionado Mostrar Todos los Jugadores");
                        listaEnlazada.MostrarTodosJugadores();
                        break;
                    }
                case 6:
                    {
                        salir = true;
                        break;
                    }
                default:
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("╔══════════════════════════════╗");
                        Console.WriteLine("║        Opción no válida.     ║");
                        Console.WriteLine("╚══════════════════════════════╝");
                        Console.WriteLine(" ");
                        Console.WriteLine("Opción no válida.");
                        break;
                    }
            }
            if (!salir)
            {
                Console.WriteLine(" ");
                Console.WriteLine("╔═════════════════════════════════════════════╗");
                Console.WriteLine("║        ¿Desea realizar otra operación?      ║");
                Console.WriteLine("╚═════════════════════════════════════════════╝");
                Console.WriteLine(" ");
                Console.Write("Si(S) / No(N): ");
                string opcion = Console.ReadLine().ToUpper();
                if (opcion != "S" && opcion != "SI")
                {
                    salir = true;
                }
                Console.Clear();
            }
        } while (!salir);
    }
}
