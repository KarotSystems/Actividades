string op;
do
{
    string elegir;
    Console.WriteLine("Menu");
    Console.WriteLine("1) Calculadora Simple");
    Console.WriteLine("2) Conversor de Temperatura");
    Console.WriteLine("3) Verificador de Número Primo");
    Console.WriteLine("4) Generador de Secuencia Fibonacci");
    Console.WriteLine("5) Validador de Palíndromos");
    Console.WriteLine("6) Contador de Vocales y Consonantes");
    Console.WriteLine("7) Suma de Dígitos");
    Console.WriteLine("8) Generador de Tablas de Multiplicar");
    Console.WriteLine("9) Ordenamiento de Números");
    Console.WriteLine("10) Calculadora de Área y Perímetro");
    elegir = Convert.ToString(Console.ReadLine());
    switch(elegir)
    {
        case "1":
            {
                Console.WriteLine("Ha elegido Calculadora simple");
                Console.Write("Ingrese el primer número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double suma = num1 + num2;
                double resta = num1 - num2;
                double multiplicacion = num1 * num2;
                double division = num1 / num2;

                Console.WriteLine($"Suma: {suma}");
                Console.WriteLine($"Resta: {resta}");
                Console.WriteLine($"Multiplicación: {multiplicacion}");
                Console.WriteLine($"División: {division}");
                break;
            }
        case "2":
            {
                Console.WriteLine("Ha elegido Conversor de Temperatura");
                Console.Write("Ingrese la temperatura en grados Celsius: ");
                double celsius = Convert.ToDouble(Console.ReadLine());

                double fahrenheit = (celsius * 9 / 5) + 32;

                Console.WriteLine($"La temperatura en Fahrenheit es: {fahrenheit}");
                break;
            }
        case "3":
            {
                Console.WriteLine("Ha elegido Verificador de Número Primo");
                int nun;
                int cont = 0;
                Console.WriteLine("Ingrese un dato");
                nun = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                for (int i = 1; i <= nun; i++)
                {
                    if (nun % i == 0)
                    {
                        cont++;
                        Console.WriteLine(i);
                    }
                }
                if (cont == 2)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Es primo");
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("no es primo");
                }
                break;
            }
        case "4":
            {
                Console.WriteLine("Ha elegido Generador de Secuencia Fibonacci");
                
                break;
            }
        case "5":
            {
                Console.WriteLine("Ha elegido Validador de Palíndromos");
                Console.Write("Ingrese una palabra: ");
                string palabra = Console.ReadLine();
                int longitud = palabra.Length;
                for (int i = 0; i < longitud / 2; i++)
                {
                    if (palabra[i] != palabra[longitud - 1 - i])
                    {
                        Console.WriteLine($"{palabra} es un palíndromo.");
                    }
                    else
                    {
                        Console.WriteLine($"{palabra} no es un palíndromo.");
                    }
                }
                break;
            }
        case "6":
            {
                Console.WriteLine("Ha elegido Contador de Vocales y Consonantes");
                Console.Write("Ingrese una frase: ");
                string frase = Console.ReadLine();
                int vocales = 0, consonantes = 0;
                foreach (char c in frase.ToLower())
                {
                    if (char.IsLetter(c))
                    {
                        if ("aeiou".Contains(c))
                        {
                            vocales++;
                        }
                        else
                        {
                            consonantes++;
                        }
                    }
                }
                Console.WriteLine($"Número de vocales: {vocales}");
                Console.WriteLine($"Número de consonantes: {consonantes}");
                break;
            }
        case "7":
            {
                Console.WriteLine("Ha elegido Suma de Dígitos");
                Console.Write("Ingrese un número entero positivo: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                int suma = 0;
                while (numero != 0)
                {
                    suma += numero % 10;
                    numero /= 10;
                }
                suma = numero;
                Console.WriteLine($"La suma de los dígitos es: {suma}");
                break;
            }
        case "8":
            {
                Console.WriteLine("Ha elegido Generador de Tablas de Multiplicar");
                Console.Write("Ingrese un número: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{numero} x {i} = {numero * i}");
                }
                break;
            }
        case "9":
            {
                Console.WriteLine("Ha elegido Ordenamiento de Números");
                Console.Write("Ingrese el primer número: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el tercer número: ");
                int num3 = Convert.ToInt32(Console.ReadLine());

                int temp;
                if (num1 > num2)
                {
                    temp = num1;
                    num1 = num2;
                    num2 = temp;
                }
                if (num1 > num3)
                {
                    temp = num1;
                    num1 = num3;
                    num3 = temp;
                }
                if (num2 > num3)
                {
                    temp = num2;
                    num2 = num3;
                    num3 = temp;
                }
                Console.WriteLine($"Los números ordenados son: {num1}, {num2}, {num3}");
                break;
            }
        case "10":
            {
                Console.WriteLine("Ha elegido Calculadora de Área y Perímetro");
                Console.WriteLine("Elija una opción:");
                Console.WriteLine("1. Área y perímetro de un círculo");
                Console.WriteLine("2. Área y perímetro de un rectángulo");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        {
                            Console.Write("Ingrese el radio del círculo: ");
                            double radio = Convert.ToDouble(Console.ReadLine());

                            double area = Math.PI * Math.Pow(radio, 2);
                            double perimetro = 2 * Math.PI * radio;

                            Console.WriteLine($"Área del círculo: {area}");
                            Console.WriteLine($"Perímetro del círculo: {perimetro}");
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Ingrese la longitud del rectángulo: ");
                            double longitud = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Ingrese el ancho del rectángulo: ");
                            double ancho = Convert.ToDouble(Console.ReadLine());

                            double area = longitud * ancho;
                            double perimetro = 2 * (longitud + ancho);

                            Console.WriteLine($"Área del rectángulo: {area}");
                            Console.WriteLine($"Perímetro del rectángulo: {perimetro}");
                            break;
                        }
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                break;
            }
        default:
            {
                break;
            }
    }
    Console.WriteLine("Desea regresar al menu? Si|No");
    op = Convert.ToString(Console.ReadLine().ToUpper());
}
while (op == "SI" || op == "S");