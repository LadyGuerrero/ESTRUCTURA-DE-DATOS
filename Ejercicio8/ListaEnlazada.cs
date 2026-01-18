
using System;

public class ListaEnlazada
{
    public Nodo? Cabeza;

    // Agregar al final
    public void Agregar(double valor)
    {
        Nodo nuevo = new Nodo(valor);

        if (Cabeza == null)
        {
            Cabeza = nuevo;
            return;
        }

        Nodo actual = Cabeza;
        while (actual.Siguiente != null)
            actual = actual.Siguiente;

        actual.Siguiente = nuevo;
    }

    public void Mostrar(string titulo)
    {
        Console.WriteLine(titulo);
        if (Cabeza == null)
        {
            Console.WriteLine("  (vacía)");
            return;
        }
        Nodo? actual = Cabeza;
        Console.Write("  ");
        while (actual != null)
        {
            Console.Write(actual.Valor);
            if (actual.Siguiente != null) Console.Write(" -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine(" -> null");
    }

    public int Longitud()
    {
        int n = 0;
        Nodo? actual = Cabeza;
        while (actual != null) { n++; actual = actual.Siguiente; }
        return n;
    }

    public double Suma()
    {
        double s = 0;
        Nodo? actual = Cabeza;
        while (actual != null) { s += actual.Valor; actual = actual.Siguiente; }
        return s;
    }

    // Llena dos listas externas según umbral
    public void Particionar(double umbral, ListaEnlazada menoresOIguales, ListaEnlazada mayores)
    {
        Nodo? actual = Cabeza;
        while (actual != null)
        {
            if (actual.Valor <= umbral) menoresOIguales.Agregar(actual.Valor);
            else mayores.Agregar(actual.Valor);
            actual = actual.Siguiente;
        }
    }
}
