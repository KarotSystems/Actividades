using System;
class program()
{
    static void Main(String[] args)
    {
        LinkedList<int> Lista = new LinkedList<int>();
        Lista.AddLast(9);
        Lista.AddLast(7);
        Lista.AddLast(5);
        Lista.AddLast(6);
        Lista.AddLast(14);
        Lista.AddLast(15);
        Lista.AddLast(3);
        Lista.AddLast(10);
        Lista.AddLast(1);

        Console.WriteLine("Lista Original:");
        ImprimirLista(Lista);

        Lista = QuickSort(Lista);
        Console.WriteLine(" ");

        Console.WriteLine("Lista Ordenada:");
        ImprimirLista(Lista);
        Console.ReadKey();
    } 
    static void ImprimirLista(LinkedList<int>Lista)
    {
        foreach(var elemento in Lista)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();
    }
    static LinkedList<int> QuickSort(LinkedList<int>Lista)
    {
        if (Lista.Count <=1)
        {
            return Lista;
        }

        //seleccionando el primer elemento de la lista como pivote
        int pivote = Lista.First.Value;
        
        //Crear 2 listas enlazadas vacias
        LinkedList<int> izquierda = new LinkedList<int>();
        LinkedList<int> derecha = new LinkedList<int>();

        //Clasificar los elementos de la lista para izquierda o derecha
        foreach(var elemento in Lista)
        {
            //excluir el pivote
            if (elemento != pivote)
            {
                if (elemento<pivote)
                {
                    izquierda.AddLast(elemento);
                }
                else
                {
                    derecha.AddLast(elemento);
                }
            }
        }

        //llamada recursiva a QuickSort en la lista izquierda
        var resultado = new LinkedList<int>(QuickSort(izquierda));
        
        //Agregar resultado
        resultado.AddLast(pivote);

        //lamada recursiva a QuickSort en la lista derecha
        foreach(var elemento in QuickSort(derecha))
        {
            resultado.AddLast(elemento);
        }

        //retorna el resultado
        return resultado;
    }
}