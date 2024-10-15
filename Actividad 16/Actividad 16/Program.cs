using System;
using System.Collections.Generic;

class Program
{
    static bool Balanceada(string expresion)
    {
        Stack<char> pila = new Stack<char>();
        foreach (char c in expresion)
        {

            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
            }
            else if (c == ')' || c == '}' || c == ']')
            {
                if (pila.Count == 0)
                {
                    return false;
                }

                char apertura = pila.Pop();
                if ((c == ')' && apertura != '(') ||
                    (c == '}' && apertura != '{') ||
                    (c == ']' && apertura != '['))
                {
                    return false;
                }
            }
        }
        return pila.Count == 0;
    }
    static void Main()
    {
        string repetir;
        do
        {
            Console.Write("Ingresa una expresión matemática: ");
            string expresion = Console.ReadLine();

            if (Balanceada(expresion))
            {
                Console.WriteLine("Balanceado");
            }
            else
            {
                Console.WriteLine("No balanceado");
            }
            Console.WriteLine("Desea hacer otra expresion? S/N");
            repetir = Convert.ToString(Console.ReadLine().ToUpper());
        } while (repetir == "S" || repetir == "SI");
    }
}