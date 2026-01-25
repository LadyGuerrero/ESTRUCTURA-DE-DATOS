using System;
using System.Collections.Generic;

class BalanceChecker
{
    // Método principal para verificar si la expresión está balanceada
    public static bool EstaBalanceada(string expresion)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char caracter in expresion)
        {
            // Si es un símbolo de apertura, lo empuja a la pila
            if (caracter == '(' || caracter == '{' || caracter == '[')
            {
                pila.Push(caracter);
            }
            // Si es un símbolo de cierre, verifica que coincida con el último abierto
            else if (caracter == ')' || caracter == '}' || caracter == ']')
            {
                if (pila.Count == 0)
                {
                    return false; // Hay un cierre sin apertura correspondiente
                }

                char tope = pila.Pop();

                if (!EsParCoincidente(tope, caracter))
                {
                    return false; // No coinciden los tipos de apertura y cierre
                }
            }
        }

        // Al final, la pila debe estar vacía si todo está balanceado
        return pila.Count == 0;
    }

    // Método auxiliar para verificar si los pares coinciden
    private static bool EsParCoincidente(char apertura, char cierre)
    {
        return (apertura == '(' && cierre == ')') ||
               (apertura == '{' && cierre == '}') ||
               (apertura == '[' && cierre == ']');
    }

    // Método Main para ejecutar el programa
    static void Main()
    {
        Console.WriteLine("INGRESE UNA FÓRMULA MATEMÁTICA:");
        string expresion = Console.ReadLine();

        // Fórmula válida esperada
        string formulaCorrecta = "{7 + (8 * 5) - [(9 - 7) + (4 + 1)]}";

        // Verifica si está balanceada y si coincide con la fórmula esperada
        if (EstaBalanceada(expresion) && expresion == formulaCorrecta)
            Console.WriteLine("FÓRMULA BALANCEADA.");
        else
            Console.WriteLine("FÓRMULA NO BALANCEADA.");
    }
}
