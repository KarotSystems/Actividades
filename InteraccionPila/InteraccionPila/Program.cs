using System.Linq;
int numero;
string opcion;
int eleccion;
string texto;
string archivo;
do
{
    Console.WriteLine("----------Menu Principal---------");
    Console.WriteLine("1) Pop");
    Console.WriteLine("2) Peek");
    Console.WriteLine("3) Contains");
    Console.WriteLine("4) Count");
    Console.WriteLine("5) ToArray");
    Console.Write("Elija la opcion a realizar: ");
    eleccion = Convert.ToInt32(Console.ReadLine());
    switch(eleccion)
    {
        case 1:
            {
                Console.WriteLine("-------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Ha elegido pop");
                Console.WriteLine("Ingrese la cantidad de datos deseados: ");
                numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                Stack<string> pila = new Stack<string>();
                for (int i = 0; i < numero; i++)
                {
                    Console.Write("Ingrese los datos deseados: ");
                    texto = Convert.ToString(Console.ReadLine());
                    pila.Push(texto);
                }
                Console.WriteLine("Elementos actuales en la pila:");
                foreach (string item in pila)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Removiendo el elemento en la cima: " + pila.Pop());
                break;
            }
        case 2:
            {
                Console.WriteLine("-------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Ha elegido Peek");
                Console.WriteLine("Ingrese la cantidad de datos deseados: ");
                numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                Stack<string> pila = new Stack<string>();
                for (int i = 0; i < numero; i++)
                {
                    Console.Write("Ingrese los datos deseados: ");
                    texto = Convert.ToString(Console.ReadLine());
                    pila.Push(texto);
                }
                Console.WriteLine("Elementos actuales en la pila:");
                foreach (string item in pila)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Elemento en la cima: " + pila.Peek());
                break;
            }
        case 3:
            {
                Console.WriteLine("-------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Ha elegido Contains");
                Console.WriteLine("Ingrese la cantidad de datos deseados: ");
                numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                Stack<string> pila = new Stack<string>();
                for (int i = 0; i < numero; i++)
                {
                    Console.Write("Ingrese los datos deseados: ");
                    texto = Convert.ToString(Console.ReadLine());
                    pila.Push(texto);
                }
                Console.Write("Ingrese texto a localizar: ");
                archivo = Convert.ToString(Console.ReadLine());
                bool existe = pila.Contains(archivo);
                Console.WriteLine($"¿La pila contiene {archivo}?: " + (existe ? "Sí" : "No")); 
                break;
            }
        case 4:
            {
                Console.WriteLine("-------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Ha elegido Count");
                Console.WriteLine("Ingrese la cantidad de datos deseados: ");
                numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                Stack<string> pila = new Stack<string>();
                for (int i = 0; i < numero; i++)
                {
                    Console.Write("Ingrese los datos deseados: ");
                    texto = Convert.ToString(Console.ReadLine());
                    pila.Push(texto);
                }
                Console.WriteLine("Elementos actuales en la pila:");
                foreach (string item in pila)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Elementos en la pila: " + pila.Count);
                break;
            }
        case 5:
            {
                Console.WriteLine("-------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Ha elegido ToArray");
                Console.WriteLine("Ingrese la cantidad de datos deseados: ");
                numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                Stack<string> pila = new Stack<string>();
                for (int i = 0; i < numero; i++)
                {
                    Console.Write("Ingrese los datos deseados: ");
                    texto = Convert.ToString(Console.ReadLine());
                    pila.Push(texto);
                }
                string[] arreglo = pila.ToArray();
                Console.WriteLine("Elementos de la pila en el arreglo:");
                foreach (string item in arreglo)
                {
                    Console.WriteLine(item);
                }
                break;
            }
    }
    Console.WriteLine("-------------------");
    Console.WriteLine(" ");
    Console.WriteLine("Desea volver al menu principal? S/N");
    opcion = Convert.ToString(Console.ReadLine().ToUpper());
    Console.Clear();
}
while(opcion == "S" ||  opcion == "SI");
