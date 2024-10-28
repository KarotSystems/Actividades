using System;
public class Nodo
{
    public string objeto;
    public Nodo Siguiente;
}
public class ColasCitas
{
    string Nombre;
    int Edad;
    string Motivo;
    public ColasCitas(string nombre, int edad, string motivo)
    {
        Nombre = nombre;
        Edad = edad;
        Motivo = motivo;
    }
    public void AgregarPacientes()
    {
        List<ColasCitas> lista = new List<ColasCitas>();
        Console.WriteLine(" ");
        Console.WriteLine("Agregar paciente");
        Console.Write("Ingresar el nombre: ");
        string Nombre = Convert.ToString(Console.ReadLine());
        Console.Write("Ingresar la edad: ");
        int Edad = Convert.ToInt32(Console.ReadLine());
        Console.Write("Motivo de visita: ");
        string Motivo = Convert.ToString(Console.ReadLine());
        Console.WriteLine(" ");
        ColasCitas colasCitas = new ColasCitas(Nombre, Edad, Motivo);
    }
    public void AtenderPaciente()
    {
        Nodo principal = new Nodo();
        if (principal == null)
        {
            Console.WriteLine("No hay Pacientes en espera");
        }
        else
        {
            Console.WriteLine($"Datos del paciente: {Nombre}, {Edad}, {Motivo}");
        }
        Nodo secundario = new Nodo();
        if (secundario == null)
        {
            principal = secundario;
        }
    }
    public void PacientePaciente()
    {
        Nodo principal = new Nodo();
        if (principal == null)
        {
            Console.WriteLine("No hay Pacientes en espera");
        }
        else
        {
            Console.WriteLine($"Datos del paciente: {Nombre}, {Edad}, {Motivo}");
        }
        Nodo secundario = new Nodo();
        if (secundario == null)
        {
            principal = secundario;
        }
    }
}
class program
{
    static void Main(string[] args, ColasCitas colas)
    {
        int opcion;
        string regresar;
        bool salir = false;
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
                    {
                        colas.AgregarPacientes();
                        break;
                    }
                case 2:
                    {
                        colas.AtenderPaciente();
                        break;
                    }
                case 3:
                    {
                        colas.PacientePaciente();
                        break;
                    }
                case 4:
                    {
                        salir = true;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Opcion no registrada");
                        break;
                    }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Desea regresar? S/N");
            regresar = Convert.ToString(Console.ReadLine().ToUpper());
        }
        while (regresar == "S" || regresar == "SI" || salir == true);
    }
}
