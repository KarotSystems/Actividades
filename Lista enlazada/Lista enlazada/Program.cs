public class Nodo
{
    public int dato;
    public Nodo siguiente;
}
public class program
{
    public static void Main()
    {
        Nodo cabeza = null;
        string opcion;
        int eleccion;
        do
        {
            Console.WriteLine("Bienvenido al prorgama de listas enlazadas: ");
            Console.WriteLine("1) Ingresa informacion");
            Console.WriteLine("2) mirar los datos");
            Console.Write("Selecciona una opcion: ");
            eleccion = Convert.ToInt32(Console.ReadLine());
            switch (eleccion)
            {
                case 1:
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Ingrese la informacion deseada");
                        Console.Write("Cuántos nodos deseas ingresar?: ");
                        int cantidad = Convert.ToInt32(Console.ReadLine());
                        Nodo ultimoNodo = null;
                        for (int i = 1; i <= cantidad; i++)
                        {
                            Console.Write($"Ingresa el valor del nodo {i}: ");
                            int valor = Convert.ToInt32(Console.ReadLine());
                            Nodo nuevoNodo = new Nodo { dato = valor, siguiente = null };

                            if (cabeza == null)
                            {
                                cabeza = nuevoNodo;
                            }
                            else
                            {
                                ultimoNodo.siguiente = nuevoNodo;
                            }
                            ultimoNodo = nuevoNodo;
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Mostrando Informacion");
                        Nodo actual = cabeza;
                        while (actual != null)
                        {
                            Console.WriteLine(actual.dato);
                            actual = actual.siguiente;
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Opción no válida.");
                        break;
                    }
            }
            Console.WriteLine("Desea volver al menu principal? S/N");
            opcion = Convert.ToString(Console.ReadLine().ToUpper());
            Console.Clear();
        }while (opcion == "S" || opcion  == "SI");
    }
}
