using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un fragmento de código HTML:");
        string input = Console.ReadLine();
        if (Balanciado(input))
        {
            Console.WriteLine("Balanceado");
        }
        else
        {
            Console.WriteLine("No balanceado");
        }
    }

    static bool Balanciado(string html)
    {
        Stack<string> stack = new Stack<string>();
        Dictionary<string, string> tagPairs = new Dictionary<string, string>()
        {
            { "</div>", "<div>" },
            { "</p>", "<p>" },
            { "</span>", "<span>" },
            { "</h1>", "<h1>" }
        };

        for (int i = 0; i < html.Length; i++)
        {
            if (html[i] == '<')
            {
                int closingIndex = html.IndexOf('>', i);
                if (closingIndex == -1) return false;

                string tag = html.Substring(i, closingIndex - i + 1);
                i = closingIndex;

                if (tag[1] != '/')
                {
                    stack.Push(tag);
                }
                else
                {
                    if (stack.Count == 0 || stack.Peek() != tagPairs[tag])
                    {
                        return false;
                    }
                    stack.Pop();
                }
            }
        }

        return stack.Count == 0; 
    }
}