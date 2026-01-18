
using System;

class Program
{
    static void Main()
    {
        var listaPrincipal = new ListaEnlazada();
        var listaMenorIgual = new ListaEnlazada();
        var listaMayor = new ListaEnlazada();

        Console.Write("Ingrese la cantidad N de datos reales: ");
        int n = int.Parse(Console.ReadLine()!);

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Dato #{i}: ");
            double x = double.Parse(Console.ReadLine()!);
            listaPrincipal.Agregar(x);
        }

        // a) Lista principal
        listaPrincipal.Mostrar("a) Datos de la lista principal:");

        // b) Promedio
        int cant = listaPrincipal.Longitud();
        double prom = cant == 0 ? 0.0 : listaPrincipal.Suma() / cant;
        Console.WriteLine($"b) Promedio: {prom}");

        // c) y d) Partición
        listaPrincipal.Particionar(prom, listaMenorIgual, listaMayor);
        listaMenorIgual.Mostrar("c) Datos <= promedio:");
        listaMayor.Mostrar("d) Datos > promedio:");
    }
}
