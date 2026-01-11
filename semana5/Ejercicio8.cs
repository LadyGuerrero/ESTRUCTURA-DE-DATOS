public class Ejercicio8
{
    public static void Run()
    {
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine();
        string invertida = new string(palabra.Reverse().ToArray());

        if (palabra.Equals(invertida, StringComparison.OrdinalIgnoreCase))
            Console.WriteLine("Es un palíndromo.");
        else
            Console.WriteLine("No es un palíndromo.");
    }
}
