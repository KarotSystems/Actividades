using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_7
{
    public class Calculadora
    {
        private List<double> numeros;

        public Calculadora()
        {
            numeros = new List<double>();
        }

        public void IngresarNumeros()
        {
            Console.WriteLine("Ingrese los números separados por espacios:");
            string entrada = Console.ReadLine();
            try
            {
                numeros = entrada.Split(' ').Select(double.Parse).ToList();
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese solo números separados por espacios.");
                IngresarNumeros();
            }
        }

        public double CalcularMedia()
        {
            return numeros.Average();
        }

        public double CalcularMediana()
        {
            var numerosOrdenados = numeros.OrderBy(n => n).ToList();
            int n = numerosOrdenados.Count;
            if (n % 2 == 0)
            {
                return (numerosOrdenados[n / 2 - 1] + numerosOrdenados[n / 2]) / 2.0;
            }
            else
            {
                return numerosOrdenados[n / 2];
            }
        }

        public double CalcularModa()
        {
            return numeros.GroupBy(n => n).OrderByDescending(g => g.Count()).First().Key;
        }

        public double CalcularDesviacionEstandar()
        {
            double media = CalcularMedia();
            double sum = numeros.Sum(n => Math.Pow(n - media, 2));
            return Math.Sqrt(sum / numeros.Count);
        }

        public void MostrarResultados()
        {
            Console.WriteLine($"Media: {CalcularMedia()}");
            Console.WriteLine($"Mediana: {CalcularMediana()}");
            Console.WriteLine($"Moda: {CalcularModa()}");
            Console.WriteLine($"Desviación estándar: {CalcularDesviacionEstandar()}");
        }
    }
}
