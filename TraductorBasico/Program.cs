using System;
using System.Collections.Generic;

class TraductorBasico
{
    static void Main()
    {
        // Diccionario inicial con al menos 10 palabras
        Dictionary<string, string> diccionario = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            {"time", "tiempo"},
            {"person", "persona"},
            {"year", "año"},
            {"way", "camino"},
            {"day", "día"},
            {"thing", "cosa"},
            {"man", "hombre"},
            {"world", "mundo"},
            {"life", "vida"},
            {"hand", "mano"},
            {"part", "parte"},
            {"child", "niño"},
            {"eye", "ojo"},
            {"woman", "mujer"},
            {"place", "lugar"},
            {"work", "trabajo"},
            {"week", "semana"},
            {"case", "caso"},
            {"point", "punto"},
            {"government", "gobierno"},
            {"company", "empresa"}
        };

        int opcion;
        do
        {
            Console.WriteLine("==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Por favor ingrese un número válido.\n");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    TraducirFrase(diccionario);
                    break;
                case 2:
                    AgregarPalabra(diccionario);
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.\n");
                    break;
            }

        } while (opcion != 0);
    }

    static void TraducirFrase(Dictionary<string, string> diccionario)
    {
        Console.Write("Ingrese la frase a traducir: ");
        string frase = Console.ReadLine();

        string[] palabras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < palabras.Length; i++)
        {
            string palabraLimpia = palabras[i].Trim(new char[] { '.', ',', ';', ':', '!', '?' });
            if (diccionario.ContainsKey(palabraLimpia.ToLower()))
            {
                palabras[i] = palabras[i].Replace(palabraLimpia, diccionario[palabraLimpia.ToLower()]);
            }
        }

        Console.WriteLine("Traducción: " + string.Join(" ", palabras) + "\n");
    }

    static void AgregarPalabra(Dictionary<string, string> diccionario)
    {
        Console.Write("Ingrese la palabra en inglés: ");
        string ingles = Console.ReadLine().Trim().ToLower();

        Console.Write("Ingrese la traducción en español: ");
        string espanol = Console.ReadLine().Trim().ToLower();

        if (!diccionario.ContainsKey(ingles))
        {
            diccionario.Add(ingles, espanol);
            Console.WriteLine("Palabra agregada exitosamente.\n");
        }
        else
        {
            Console.WriteLine("La palabra ya existe en el diccionario.\n");
        }
    }
}
