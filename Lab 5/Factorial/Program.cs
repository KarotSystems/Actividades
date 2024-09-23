using Lab5;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

string opcion;
int factorial = 1;
string elegir;
string principal;
string volver;
do
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("---- Menu Principal ----");
    Console.WriteLine(" ");
    Console.WriteLine("Se ha creado un programa que pueda beneficiar al usuario de la mejor forma posible" +
        "para que pueda operar Factorial o Fibonacci sin ningun problemas. A continuacion tendra 2 sub-menus" +
        "de los problemas solicitados a resolver");
    Console.WriteLine(" ");
    Console.WriteLine("1) Factorial.");
    Console.WriteLine("2) Serie de Fibonacci.");
    Console.WriteLine(" ");
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
                    Console.WriteLine("---- Menu Secundario Factorial----");
                    Console.WriteLine(" ");
                    Console.WriteLine("Existen diversos metodos para conseguir el factorial " +
                        "de un numero, por lo tanto, presentamos algunos metodos que pueda utilizar y" +
                        "conseguir el factorial paso a paso");
                    Console.WriteLine(" ");
                    Console.WriteLine("1) If");
                    Console.WriteLine("2) For");
                    Console.WriteLine("3) Do While");
                    Console.WriteLine("4) While");
                    Console.Write("Introducir una de los metodos para operar el factorial: ");
                    elegir = Convert.ToString(Console.ReadLine());
                    switch (elegir)
                    {
                        case "1":
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("---------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Ha elegido el metodo IF");
                                Console.WriteLine(" ");
                                Console.WriteLine("El metodo If se encarga de comparar si el numero ingresado" +
                                    "puede ser factorizado");
                                Console.WriteLine(" ");
                                Console.Write("Introducir el número a operar: ");
                                n = int.Parse(Console.ReadLine());
                                int resultado = Factorizar.FactorialIF(n);
                                if (n < 0)
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine("El factorial no está definido para números negativos.");
                                }
                                else
                                {
                                    Console.WriteLine(" ");
                                    Console.Write($"Factorial {n}: ");
                                    for (int i = 1; i <= n; i++)
                                    {
                                        factorial *= i;
                                        if (i == n)
                                        {
                                            Console.Write($"{i} = {factorial}"); // Último número, mostrar resultado
                                        }
                                        else
                                        {
                                            Console.Write($"{i} x "); // Mostrar multiplicación intermedia
                                        }
                                    }
                                }
                                Console.WriteLine(" ");
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
                                Console.WriteLine("Ha elegido el metodo For");
                                Console.WriteLine(" ");
                                Console.WriteLine("El metodo For se encarga de repetir la cantidad de digitos desde le numero ingresado de forma ascendente");
                                Console.WriteLine(" ");
                                Console.Write("Introducir el número a operar: ");
                                n = int.Parse(Console.ReadLine());
                                int resultado = Factorizar.FactorialFor(n);
                                Console.WriteLine(" ");
                                Console.Write($"Factorial {n}: ");
                                for (int i = 1; i <= n; i++)
                                {
                                    factorial *= i;
                                    Console.Write($"{i} x ");
                                }
                                Console.WriteLine(" ");
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
                                Console.WriteLine("Ha elegido el metodo Do while");
                                Console.WriteLine(" ");
                                Console.WriteLine("El metodo Do While se encarga de repetir cierta cantidad de digitos" +
                                    "desde el numero iniciar de forma ascendente hasta llegar al numero ingresado");
                                Console.WriteLine(" ");
                                Console.Write("Introducir el número a operar: ");
                                n = int.Parse(Console.ReadLine());
                                int resultado = Factorizar.FactorialDoWhile(n);
                                Console.WriteLine(" ");
                                Console.Write($"Factorial {n}: ");
                                int i = 1;
                                do
                                {
                                    factorial *= i;
                                    Console.Write($"{i} x ");
                                    i++;
                                } while (i <= n);
                                Console.WriteLine(" ");
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
                                Console.WriteLine("Ha elegido el metodo While");
                                Console.WriteLine(" ");
                                Console.WriteLine("El metodo While se encarga de repetir cierta cantidad de digitos" +
                                    "desde el numero iniciar de forma ascendente hasta llegar al numero ingresado");
                                Console.WriteLine(" ");
                                Console.Write("Introducir el número a operar: ");
                                n = int.Parse(Console.ReadLine());
                                int resultado = Factorizar.FactorialWhile(n);
                                Console.WriteLine(" ");
                                Console.Write($"Factorial {n}: ");
                                int i = 1;
                                while (i <= n)
                                {
                                    factorial *= i;
                                    Console.Write($"{i} x ");
                                    i++;
                                }
                                Console.WriteLine(" ");
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
                    Console.WriteLine("---- Menu Secundario Fibonacci----");
                    Console.WriteLine(" ");
                    Console.WriteLine("Existen diversos metodos para conseguir el Fibonacci " +
                        "de un numero, por lo tanto, presentamos algunos metodos que pueda utilizar");
                    Console.WriteLine(" ");
                    Console.WriteLine("1) For");
                    Console.WriteLine("2) Do While");
                    Console.WriteLine("3) While");
                    Console.Write("Introducir una de los metodos para operar Fibonacci: ");
                    elegir = Convert.ToString(Console.ReadLine());
                    switch (elegir)
                    {
                        case "1":
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("---------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Ha elegido el metodo For");
                                Console.WriteLine(" ");
                                Console.WriteLine("El metodo For se encarga de repetir la cantidad de digitos desde el numero ingresado");
                                Console.WriteLine(" ");
                                Console.Write("Introducir el número a operar: ");
                                n = int.Parse(Console.ReadLine());
                                int resultado = Fibonacci.FiboFor(n);
                                int a = 0;
                                int b = 1;
                                int resul = 0;
                                Console.WriteLine(" ");
                                for (int i = 2; i <= n; i++)
                                {
                                    resul = a + b;
                                    Console.WriteLine($"{a}+{b}={resul}");
                                    a = b;
                                    b = resul;
                                }
                                Console.WriteLine(" ");
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
                                Console.WriteLine("Ha elegido el metodo Do while");
                                Console.WriteLine(" ");
                                Console.WriteLine("El metodo Do While se encarga de repetir cierta cantidad de digitos" +
                                    "desde el numero iniciar");
                                Console.WriteLine(" ");
                                Console.Write("Introducir el número a operar: ");
                                n = int.Parse(Console.ReadLine());
                                int resultado = Fibonacci.FiboDoWhile(n);
                                int x = 2;
                                int a = 0;
                                int b = 1;
                                int result = 0;
                                Console.WriteLine(" ");
                                do
                                {
                                    result = a + b;
                                    Console.WriteLine($"{a}+{b}={result}");
                                    a = b;
                                    b = result;
                                    x++;
                                }
                                while (x <= n);
                                Console.WriteLine(" ");
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
                                Console.WriteLine("Ha elegido el metodo While");
                                Console.WriteLine(" ");
                                Console.WriteLine("El metodo While se encarga de repetir cierta cantidad de digitos" +
                                    "desde el numero iniciar de forma ascendente hasta llegar al numero ingresado");
                                Console.WriteLine(" ");
                                Console.Write("Introducir el número a operar: ");
                                n = int.Parse(Console.ReadLine());
                                int resultado = Fibonacci.FiboWhile(n);
                                int x = 2;
                                int a = 0;
                                int b = 1;
                                int result = 0;
                                Console.WriteLine(" ");
                                while (x <= n)
                                {
                                    result = a + b;
                                    Console.WriteLine($"{a}+{b}={result}");
                                    a = b;
                                    b = result;
                                    x++;
                                }
                                Console.WriteLine(" ");
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