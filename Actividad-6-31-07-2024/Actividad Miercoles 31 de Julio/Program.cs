using Microsoft.Win32;
using System;
using System.IO.Compression;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text.RegularExpressions;
class Receta
{
    public string nombre;
    public int cantidad_no;
    public string ingredientes;

    public Receta(string Nombre, int Cantidad_No, string Ingredientes)
    {
        nombre = Nombre;
        cantidad_no = Cantidad_No;
        ingredientes = Ingredientes;
    }
}

class Recetas
{
    public List<Receta> ListaRecetas;

    public Recetas()
    {
        ListaRecetas = new List<Receta>();
    }

    public void IngresarDatos()
    {
        Console.WriteLine("Ha elegido Ingresar Recetas");
        Console.WriteLine("Cuantas recetas agregara?");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"Receta numero: {i + 1}");
            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la cantidad: ");
            int cantidad_no = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese los Ingredientes: ");
            string ingredientes = Console.ReadLine();
            ListaRecetas.Add(new Receta(nombre, cantidad_no, ingredientes));
            Console.WriteLine(" ");
        }
    }

    public void BuscarNombre()
    {
        Console.WriteLine("Ha elegido >Buscar por Nombre<");
        Console.Write("Ingrese el nombre de la receta a localizar: ");
        string Buscar = Console.ReadLine();
        bool encontrado = false;

        foreach (var receta in ListaRecetas)
        {
            if (receta.nombre.Equals(Buscar, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Receta encontrada:");
                Console.WriteLine($"Nombre: {receta.nombre}");
                Console.WriteLine($"Cantidad: {receta.cantidad_no}");
                Console.WriteLine($"Ingredientes: {receta.ingredientes}");
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine($"No se encontró la receta {Buscar}");
        }
    }

    public void MostrarTodasLasRecetas()
    {
        Console.WriteLine("Todas las recetas:");
        foreach (var receta in ListaRecetas)
        {
            Console.WriteLine($"Nombre: {receta.nombre}");
            Console.WriteLine($"Cantidad: {receta.cantidad_no}");
            Console.WriteLine($"Ingredientes: {receta.ingredientes}");
            Console.WriteLine(" ");
        }
    }
}

namespace Actividad
{
    class Program
    {
        static void Main(string[] args)
        {
            Recetas recetas = new Recetas();
            string opcion;

            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1) Ingresar Recetas");
                Console.WriteLine("2) Buscar Receta");
                Console.WriteLine("3) Mostrar todas las recetas");
                int elegir = Convert.ToInt32(Console.ReadLine());

                switch (elegir)
                {
                    case 1:
                        {
                            recetas.IngresarDatos();
                            break;
                        }
                    case 2:
                        {
                            recetas.BuscarNombre();
                            break;
                        }
                    case 3:
                        {
                            recetas.MostrarTodasLasRecetas();
                            break;
                        }
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine("¿Desea regresar? S|N");
                opcion = Console.ReadLine().ToUpper();

            } while (opcion == "S");
        }
    }
}