public class Ejercicio10
{
    public static void Run()
    {
        List<int> precios = new List<int> { 50, 75, 46, 22, 80, 65, 8 };
        int menor = precios.Min();
        int mayor = precios.Max();
        Console.WriteLine($"El menor precio es: {menor}");
        Console.WriteLine($"El mayor precio es: {mayor}");
    }
}
