class Program
{
    static void Main(string[] args)
    {
        //string figuras = "({[()]})";
        string figuras;
        string opcion;
        do
        {
            Console.WriteLine("Balancear una pila");
            Stack<char> pila = new Stack<char>();
            Console.Write("Porfavor ingresar la cadena: ");
            figuras = Console.ReadLine();
            bool balanceado = true;
            foreach (char simbolo in figuras)
            {
                if (simbolo == '(' || simbolo == '{' || simbolo == '[')
                {
                    pila.Push(simbolo);
                }
                else if (simbolo == ')' || simbolo == '}' || simbolo == ']')
                {
                    if (pila.Count == 0)
                    {
                        balanceado = false;
                        break;
                    }
                    char top = pila.Pop();
                    if ((simbolo == ')' && top != '(') || (simbolo == '}' && top != '{') || (simbolo == ']' && top != '['))
                    {
                        balanceado = false;
                        break;
                    }
                }
            }

            if (balanceado && pila.Count == 0)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine(" ");
                Console.WriteLine("La cadena está balanceada.");
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine("-------------------");
                Console.WriteLine(" ");
                Console.WriteLine("La cadena no está balanceada.");
                Console.WriteLine(" ");
            }

            Console.WriteLine("-------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Desea volver al menu principal? S/N");
            opcion = Convert.ToString(Console.ReadLine().ToUpper());
            Console.Clear();
        }
        while (opcion == "S" || opcion == "SI");
    }
}