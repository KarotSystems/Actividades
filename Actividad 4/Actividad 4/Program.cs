using System;

class Program
{
    static void Main()
    {
        MenuPrincipal menuPrincipal = new MenuPrincipal();
        menuPrincipal.Mostrar();
    }
}

public class MenuPrincipal
{
    public void Mostrar()
    {
        while (true)
        {
            try
            {
                MostrarOpciones();
                int opcionPrincipal = Convert.ToInt32(Console.ReadLine());

                switch (opcionPrincipal)
                {
                    case 1:
                        CalculadoraSimple calculadora = new CalculadoraSimple();
                        calculadora.MostrarMenu();
                        break;
                    case 2:
                        ConversorTemperatura conversor = new ConversorTemperatura();
                        conversor.MostrarMenu();
                        break;
                    case 3:
                        VerificadorNumeroPrimo verificador = new VerificadorNumeroPrimo();
                        verificador.MostrarMenu();
                        break;
                    case 4:
                        GeneradorSecuenciaFibonacci generador = new GeneradorSecuenciaFibonacci();
                        generador.MostrarMenu();
                        break;
                    case 5:
                        ValidadorPalindromos validador = new ValidadorPalindromos();
                        validador.MostrarMenu();
                        break;
                    case 6:
                        ContadorVocalesConsonantes contador = new ContadorVocalesConsonantes();
                        contador.MostrarMenu();
                        break;
                    case 7:
                        SumaDigitos sumaDigitos = new SumaDigitos();
                        sumaDigitos.MostrarMenu();
                        break;
                    case 8:
                        GeneradorTablasMultiplicar generadorTablas = new GeneradorTablasMultiplicar();
                        generadorTablas.MostrarMenu();
                        break;
                    case 9:
                        OrdenamientoNumeros ordenamiento = new OrdenamientoNumeros();
                        ordenamiento.MostrarMenu();
                        break;
                    case 10:
                        CalculadoraAreaPerimetro calculadoraArea = new CalculadoraAreaPerimetro();
                        calculadoraArea.MostrarMenu();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}. Ingrese un valor numérico válido.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }
        }
    }

    private void MostrarOpciones()
    {
        Console.WriteLine("Menú Principal:");
        Console.WriteLine("1. Calculadora Simple");
        Console.WriteLine("2. Conversor de Temperatura");
        Console.WriteLine("3. Verificador de Número Primo");
        Console.WriteLine("4. Generador de Secuencia Fibonacci");
        Console.WriteLine("5. Validador de Palíndromos");
        Console.WriteLine("6. Contador de Vocales y Consonantes");
        Console.WriteLine("7. Suma de Dígitos");
        Console.WriteLine("8. Generador de Tablas de Multiplicar");
        Console.WriteLine("9. Ordenamiento de Números");
        Console.WriteLine("10. Calculadora de Área y Perímetro");
        Console.WriteLine("0. Salir");
        Console.Write("Seleccione una opción: ");
    }
}

public class CalculadoraSimple
{
    public void MostrarMenu()
    {
        try
        {
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
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Error: {ex.Message}. Ingrese un valor numérico válido.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Error: {ex.Message}. No se puede dividir por cero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error inesperado: {ex.Message}");
        }
    }
}

public class ConversorTemperatura
{
    public void MostrarMenu()
    {
        try
        {
            Console.Write("Ingrese la temperatura en grados Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"La temperatura en Fahrenheit es: {fahrenheit}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Error: {ex.Message}. Ingrese un valor numérico válido.");
        }
    }
}

public class VerificadorNumeroPrimo
{
    public void MostrarMenu()
    {
        try
        {
            Console.Write("Ingrese un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            bool esPrimo = EsPrimo(numero);
            if (esPrimo)
            {
                Console.WriteLine($"{numero} es un número primo.");
            }
            else
            {
                Console.WriteLine($"{numero} no es un número primo.");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Error: {ex.Message}. Ingrese un valor numérico válido.");
        }
    }

    private bool EsPrimo(int numero)
    {
        if (numero <= 1) return false;
        for (int i = 2; i < numero; i++)
        {
            if (numero % i == 0) return false;
        }
        return true;
    }
}

public class GeneradorSecuenciaFibonacci
{
    public void MostrarMenu()
    {
        try
        {
            Console.Write("Ingrese la cantidad de números en la secuencia Fibonacci: ");
            int n = Convert.ToInt32(Console.ReadLine());

            GenerarFibonacci(n);
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Error: {ex.Message}. Ingrese un valor numérico válido.");
        }
    }

    private void GenerarFibonacci(int n)
    {
        int a = 0, b = 1, c;
        Console.Write($"{a} {b}");

        for (int i = 2; i < n; i++)
        {
            c = a + b;
            Console.Write($" {c}");
            a = b;
            b = c;
        }
        Console.WriteLine();
    }
}

public class ValidadorPalindromos
{
    public void MostrarMenu()
    {
        try
        {
            Console.Write("Ingrese una palabra: ");
            string palabra = Console.ReadLine();

            if (EsPalindromo(palabra))
            {
                Console.WriteLine($"{palabra} es un palíndromo.");
            }
            else
            {
                Console.WriteLine($"{palabra} no es un palíndromo.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error inesperado: {ex.Message}");
        }
    }

    private bool EsPalindromo(string palabra)
    {
        int longitud = palabra.Length;
        for (int i = 0; i < longitud / 2; i++)
        {
            if (palabra[i] != palabra[longitud - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}

public class ContadorVocalesConsonantes
{
    public void MostrarMenu()
    {
        try
        {
            Console.Write("Ingrese una frase: ");
            string frase = Console.ReadLine();

            int vocales = 0, consonantes = 0;
            ContarVocalesConsonantes(frase, ref vocales, ref consonantes);

            Console.WriteLine($"Número de vocales: {vocales}");
            Console.WriteLine($"Número de consonantes: {consonantes}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error inesperado: {ex.Message}");
        }
    }

    private void ContarVocalesConsonantes(string frase, ref int vocales, ref int consonantes)
    {
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
    }
}

public class SumaDigitos
{
    public void MostrarMenu()
    {
        try
        {
            Console.Write("Ingrese un número entero positivo: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int suma = SumarDigitos(numero);
            Console.WriteLine($"La suma de los dígitos es: {suma}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Error: {ex.Message}. Ingrese un valor numérico válido.");
        }
    }

    private int SumarDigitos(int numero)
    {
        int suma = 0;
        while (numero != 0)
        {
            suma += numero % 10;
            numero /= 10;
        }
        return suma;
    }
}

public class GeneradorTablasMultiplicar
{
    public void MostrarMenu()
    {
        try
        {
            Console.Write("Ingrese un número para generar su tabla de multiplicar: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            GenerarTablaMultiplicar(numero);
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Error: {ex.Message}. Ingrese un valor numérico válido.");
        }
    }

    private void GenerarTablaMultiplicar(int numero)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}

public class OrdenamientoNumeros
{
    public void MostrarMenu()
    {
        try
        {
            Console.Write("Ingrese el primer número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Ordenar(ref num1, ref num2, ref num3);

            Console.WriteLine($"Los números ordenados son: {num1}, {num2}, {num3}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Error: {ex.Message}. Ingrese un valor numérico válido.");
        }
    }

    private void Ordenar(ref int num1, ref int num2, ref int num3)
    {
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
    }
}

public class CalculadoraAreaPerimetro
{
    public void MostrarMenu()
    {
        try
        {
            Console.WriteLine("Elija una opción:");
            Console.WriteLine("1. Área y perímetro de un círculo");
            Console.WriteLine("2. Área y perímetro de un rectángulo");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CalcularCirculo();
                    break;
                case 2:
                    CalcularRectangulo();
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Error: {ex.Message}. Ingrese un valor numérico válido.");
        }
    }

    private void CalcularCirculo()
    {
        try
        {
            Console.Write("Ingrese el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * Math.Pow(radio, 2);
            double perimetro = 2 * Math.PI * radio;

            Console.WriteLine($"Área del círculo: {area}");
            Console.WriteLine($"Perímetro del círculo: {perimetro}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Error: {ex.Message}. Ingrese un valor numérico válido.");
        }
    }

    private void CalcularRectangulo()
    {
        try
        {
            Console.Write("Ingrese la longitud del rectángulo: ");
            double longitud = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el ancho del rectángulo: ");
            double ancho = Convert.ToDouble(Console.ReadLine());

            double area = longitud * ancho;
            double perimetro = 2 * (longitud + ancho);

            Console.WriteLine($"Área del rectángulo: {area}");
            Console.WriteLine($"Perímetro del rectángulo: {perimetro}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Error: {ex.Message}. Ingrese un valor numérico válido.");
        }
    }
}
