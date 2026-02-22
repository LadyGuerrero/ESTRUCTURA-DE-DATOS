using System;
using System.Collections.Generic;

class ProgramaVacunacion
{
    static void Main()
    {
        // Conjunto total de ciudadanos
        HashSet<string> ciudadanos = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add("Ciudadano " + i);
        }

        // Conjunto de vacunados con Pfizer (75 ficticios)
        HashSet<string> pfizer = new HashSet<string>();
        for (int i = 1; i <= 75; i++)
        {
            pfizer.Add("Ciudadano " + i);
        }

        // Conjunto de vacunados con AstraZeneca (75 ficticios)
        HashSet<string> astrazeneca = new HashSet<string>();
        for (int i = 76; i <= 150; i++)
        {
            astrazeneca.Add("Ciudadano " + i);
        }

        // Operaciones de teoría de conjuntos
        var vacunadosAmbas = new HashSet<string>(pfizer);
        vacunadosAmbas.IntersectWith(astrazeneca);

        var soloPfizer = new HashSet<string>(pfizer);
        soloPfizer.ExceptWith(astrazeneca);

        var soloAstrazeneca = new HashSet<string>(astrazeneca);
        soloAstrazeneca.ExceptWith(pfizer);

        var vacunados = new HashSet<string>(pfizer);
        vacunados.UnionWith(astrazeneca);

        var noVacunados = new HashSet<string>(ciudadanos);
        noVacunados.ExceptWith(vacunados);

        // Resultados
        Console.WriteLine("Ciudadanos no vacunados: " + noVacunados.Count);
        Console.WriteLine("Ciudadanos con ambas dosis: " + vacunadosAmbas.Count);
        Console.WriteLine("Ciudadanos solo Pfizer: " + soloPfizer.Count);
        Console.WriteLine("Ciudadanos solo AstraZeneca: " + soloAstrazeneca.Count);
    }
}
