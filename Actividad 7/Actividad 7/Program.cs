using Actividad_7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        Calculadora calculadora = new Calculadora();
        string opcion;

        do
        {
            Console.WriteLine(" ");
            Console.WriteLine("Menu");
            Console.WriteLine("1) Ingresar números");
            Console.WriteLine("2) Calcular y mostrar la media");
            Console.WriteLine("3) Calcular y mostrar la mediana");
            Console.WriteLine("4) Calcular y mostrar la moda");
            Console.WriteLine("5) Calcular y mostrar la desviación estándar");
            Console.WriteLine("6) Volver a ingresar números");
            Console.WriteLine("7) Salir");

            Console.Write("Seleccione una opción: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    {
                        calculadora.IngresarNumeros();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine($"Media: {calculadora.CalcularMedia()}");
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine($"Mediana: {calculadora.CalcularMediana()}");
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine($"Moda: {calculadora.CalcularModa()}");
                        break;
                    }
                case "5":
                    {
                        Console.WriteLine($"Desviación estándar: {calculadora.CalcularDesviacionEstandar()}");
                        break;
                    }
                case "6":
                    {
                        calculadora.IngresarNumeros();
                        break;
                    }
                case "7":
                    {
                        Console.WriteLine("Saliendo...");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                        break;
                    }
            }
        } while (opcion != "7");
    }
}
