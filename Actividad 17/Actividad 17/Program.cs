using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string repetir;
        do
        {
            Console.Write("Ingresa una cadena de texto: ");
            string input = Console.ReadLine();
            Stack<char> pila = new Stack<char>();
            foreach (char c in input)
            {
                pila.Push(c);
            }
            Console.Write("Cadena invertida: ");
            while (pila.Count > 0)
            {
                Console.Write(pila.Pop());
            }
            Console.WriteLine();
            Console.Write("Desea repetir? S/N ");
            repetir = Console.ReadLine().ToUpper();
        } while (repetir == "S" || repetir == "SI");
    }
}