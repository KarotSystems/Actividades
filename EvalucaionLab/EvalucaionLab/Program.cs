using System;
public class Nodo
{
    public ColasCitas Paciente { get; set; }
    public Nodo Siguiente { get; set; }
}

public class ColasCitas
{
    public string Nombre { get; private set; }
    public int Edad { get; private set; }
    public string Motivo { get; private set; }

    public ColasCitas(string nombre, int edad, string motivo)
    {
        Nombre = nombre;
        Edad = edad;
        Motivo = motivo;
    }
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Motivo: {Motivo}");
    }
}

public class ColaPacientes
{
    private Nodo primero;
    private Nodo ultimo;

    public ColaPacientes()
    {
        primero = null;
        ultimo = null;
    }
    public void AgregarPaciente()
    {
        Console.WriteLine("Agregar Paciente:");
        Console.Write("Ingrese el nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese la edad: ");
        int edad = int.Parse(Console.ReadLine());
        Console.Write("Motivo de visita: ");
        string motivo = Console.ReadLine();

        ColasCitas nuevoPaciente = new ColasCitas(nombre, edad, motivo);
        Nodo nuevoNodo = new Nodo { Paciente = nuevoPaciente, Siguiente = null };

        if (primero == null)
        {
            primero = nuevoNodo;
            ultimo = nuevoNodo;
        }
        else
        {
            ultimo.Siguiente = nuevoNodo;
            ultimo = nuevoNodo;
        }

        Console.WriteLine("Paciente agregado a la cola.\n");
    }
    public void AtenderPaciente()
    {
        if (primero == null)
        {
            Console.WriteLine("No hay pacientes en espera.\n");
        }
        else
        {
            Console.WriteLine("Atendiendo al siguiente paciente:");
            primero.Paciente.MostrarInformacion();
            primero = primero.Siguiente;
            if (primero == null)
            {
                ultimo = null;
            }
            Console.WriteLine("Paciente atendido.\n");
        }
    }
    public void MostrarPacientes()
    {
        if (primero == null)
        {
            Console.WriteLine("No hay pacientes en espera.\n");
        }
        else
        {
            Console.WriteLine("Lista de pacientes en espera:");
            Nodo actual = primero;
            while (actual != null)
            {
                actual.Paciente.MostrarInformacion();
                actual = actual.Siguiente;
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ColaPacientes colaPacientes = new ColaPacientes();
        bool salir = false;
        int opcion;
        string regresar;
        do
        {
            Console.WriteLine(" ");
            Console.WriteLine("Menu Principal");
            Console.WriteLine("1) Agregar Paciente");
            Console.WriteLine("2) Atender al siguiente paciente");
            Console.WriteLine("3) Mostrar Lista de pacientes");
            Console.WriteLine("4) Salir del programa");
            Console.Write("Que opcion desea realizar? ");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    colaPacientes.AgregarPaciente();
                    break;
                case 2:
                    colaPacientes.AtenderPaciente();
                    break;
                case 3:
                    colaPacientes.MostrarPacientes();
                    break;
                case 4:
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida.\n");
                    break;
            }
            Console.WriteLine(" ");
            Console.WriteLine("Desea regresar? S/N");
            regresar = Convert.ToString(Console.ReadLine().ToUpper());
        }
        while (regresar == "S" || regresar == "SI" || salir == true);
    }
}