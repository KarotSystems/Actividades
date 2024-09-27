using System;

string opcion;
int factorial;
Stack<int> pila = new Stack<int>();
do
{
    Console.WriteLine("Factoriales");
    Console.Write("Ingrese un número para calcular su factorial: ");
    factorial = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");
    Console.WriteLine("Factoriales calculados:");
    foreach (var resulta in pila)
    {
        Console.WriteLine(resulta);
    }
    int resultado = CalcularFactorialParcial(factorial, pila: pila);
    Console.WriteLine("");
    Console.WriteLine($"El factorial de {factorial} es: {resultado}");
    pila.Push(resultado);
    Console.WriteLine("");
    Console.WriteLine("¿Desea calcular otro factorial? (S/Si para continuar):");
    opcion = Console.ReadLine().ToUpper();
    Console.Clear();
} while (opcion == "S" || opcion == "SI");

static int CalcularFactorialParcial(int num, Stack<int> pila)
{
    if (num <= 0)
    {
        return 1;
    }
    else
    {
        int resultado = 1;
        for (int i = 1; i <= num; i++)
        {
            resultado *= i;
            pila.Push(i);
            int fact = pila.Pop();
            Console.WriteLine(fact);
        }
        return resultado;
    }
}