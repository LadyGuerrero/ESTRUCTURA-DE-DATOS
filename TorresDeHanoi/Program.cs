using System;
using System.Collections.Generic;

class TorresDeHanoi
{
    static void MoverDiscos(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar, string nombreOrigen, string nombreDestino, string nombreAuxiliar)
    {
        if (n > 0)
        {
            // Mover n-1 discos a la torre auxiliar
            MoverDiscos(n - 1, origen, auxiliar, destino, nombreOrigen, nombreAuxiliar, nombreDestino);

            // Mover el disco restante
            int disco = origen.Pop();
            destino.Push(disco);
            Console.WriteLine($"Mover disco {disco} de {nombreOrigen} a {nombreDestino}");

            // Mover los n-1 discos desde auxiliar a destino
            MoverDiscos(n - 1, auxiliar, destino, origen, nombreAuxiliar, nombreDestino, nombreOrigen);
        }
    }

    static void Main()
    {
        int numDiscos = 3; // Puedes cambiar el número de discos
        Stack<int> torreA = new Stack<int>();
        Stack<int> torreB = new Stack<int>();
        Stack<int> torreC = new Stack<int>();

        // Inicializar torre A con discos (mayor número = disco más grande)
        for (int i = numDiscos; i >= 1; i--)
        {
            torreA.Push(i);
        }

        Console.WriteLine("Resolviendo Torres de Hanoi con " + numDiscos + " discos:\n");
        MoverDiscos(numDiscos, torreA, torreC, torreB, "A", "C", "B");
    }
}
