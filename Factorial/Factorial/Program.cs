using Factorial;
using System;

string opcion;
string elegir;
string principal;
string volver;
do
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("---- Menu Principal ----");
    Console.WriteLine("1) Factorial.");
    Console.WriteLine("2) Serie de Fibonacci.");
    Console.Write("Introducir que desea realizar: ");
    principal = Convert.ToString(Console.ReadLine());
    switch(principal)
    {
        case "1":
            {
                do
                {
                    int n;
                    Console.ForegroundColor= ConsoleColor.White;
                    Console.WriteLine("---------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Factorial");
                    Console.WriteLine("1) if");
                    Console.WriteLine("2) for");
                    Console.WriteLine("3) do while");
                    Console.WriteLine("4) while");
                    Console.Write("Introducir como operar factorial: ");
                    elegir = Convert.ToString(Console.ReadLine());
                    switch (elegir)
                    {
                        case "1":
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("---------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Usando IF");
                                Console.Write("Introducir el número a operar: ");
                                n = int.Parse(Console.ReadLine());
                                int resultado = Factorizar.FactorialIF(n);
                                Console.WriteLine($"Factorial de {n} es: {resultado}");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("---------------------------------------------");
                                break;
                            }
                        case "2":
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("---------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Usando FOR");
                                Console.Write("Introducir el número a operar: ");
                                n = int.Parse(Console.ReadLine());
                                int resultado = Factorizar.FactorialFor(n);
                                Console.WriteLine($"Factorial de {n} es: {resultado}");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("---------------------------------------------");
                                break;
                            }
                        case "3":
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("---------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Usando DO-WHILE");
                                Console.Write("Introducir el número a operar: ");
                                n = int.Parse(Console.ReadLine());
                                int resultado = Factorizar.FactorialDoWhile(n);
                                Console.WriteLine($"Factorial de {n} es: {resultado}");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("---------------------------------------------");
                                break;
                            }
                        case "4":
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("---------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Usando WHILE");
                                Console.Write("Introducir el número a operar: ");
                                n = int.Parse(Console.ReadLine());
                                int resultado = Factorizar.FactorialWhile(n);
                                Console.WriteLine($"Factorial de {n} es: {resultado}");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("---------------------------------------------");
                                break;
                            }
                        default:
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("---------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Opción no válida");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("---------------------------------------------");
                                break;
                            }
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Desea volver operar? S/N");
                    opcion = Convert.ToString(Console.ReadLine().ToUpper());
                }
                while (opcion == "S" || opcion == "SI");
                break;
            }
        case "2":
            {
                do
                {
                    int n;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("---------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Serie de Fibonacci");
                    Console.WriteLine("1) for");
                    Console.WriteLine("2) do while");
                    Console.WriteLine("3) while");
                    Console.Write("Introducir como operar factorial: ");
                    elegir = Convert.ToString(Console.ReadLine());
                    switch (elegir)
                    {
                        case "1":
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("---------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Usando FOR");
                                Console.Write("Introducir el número a operar: ");
                                n = int.Parse(Console.ReadLine());
                                int resultado = Fibonacci.FiboFor(n);
                                Console.WriteLine($"Fibonacci de {n} es: {resultado}");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("---------------------------------------------");
                                break;
                            }
                        case "2":
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("---------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Usando DO-WHILE");
                                Console.Write("Introducir el número a operar: ");
                                n = int.Parse(Console.ReadLine());
                                int resultado = Fibonacci.FiboDoWhile(n);
                                Console.WriteLine($"Fibonacci de {n} es: {resultado}");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("---------------------------------------------");
                                break;
                            }
                        case "3":
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("---------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Usando WHILE");
                                Console.Write("Introducir el número a operar: ");
                                n = int.Parse(Console.ReadLine());
                                int resultado = Fibonacci.FiboWhile(n);
                                Console.WriteLine($"Fibonacci de {n} es: {resultado}");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("---------------------------------------------");
                                break;
                            }
                        default:
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("---------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Opción no válida");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("---------------------------------------------");
                                break;
                            }
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Desea volver operar? S/N");
                    opcion = Convert.ToString(Console.ReadLine().ToUpper());
                }
                while (opcion == "S" || opcion == "SI");
                break;
            }
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("---------------------------------------------");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Desea volver al menu principal? S/N");
    volver = Convert.ToString(Console.ReadLine().ToUpper());
    Console.Clear();
}
while (volver == "S" || volver == "SI");