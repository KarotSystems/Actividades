using System;
class Nodo
{
    public int valor;
    public Nodo siguiente;

    public Nodo(int val)
    {
        valor = val;
        siguiente = null;
    }
}

class Cola
{
    private Nodo cima;
    private Nodo final;

    public Cola()
    {
        cima = null;
        final = null;
    }
    public void Encolar(int valor)
    {
        Nodo nuevoNodo = new Nodo(valor);
        if (final == null) 
        {
            cima = nuevoNodo;
            final = nuevoNodo;
        }
        else
        {
            final.siguiente = nuevoNodo;
            final = nuevoNodo;
        }
        Console.WriteLine($"Encolado: {valor}");
    }
    public void Desencolar()
    {
        if (cima == null)
        {
            Console.WriteLine("La cola está vacía.");
            return;
        }
        Console.WriteLine($"Desencolado: {cima.valor}");
        cima = cima.siguiente;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cola cola = new Cola();

        cola.Encolar(70);
        cola.Encolar(80);
        cola.Encolar(50);
        Console.WriteLine(" ");
        cola.Desencolar();
        cola.Desencolar();
        cola.Desencolar();
        cola.Desencolar(); 
    }
}
