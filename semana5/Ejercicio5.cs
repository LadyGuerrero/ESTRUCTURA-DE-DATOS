public class Ejercicio5
{
    public static void Run()
    {
        List<int> numeros = new List<int>();
        for (int i = 1; i <= 10; i++)
        {
            numeros.Add(i);
        }
        numeros.Reverse();
        Console.WriteLine(string.Join(", ", numeros));
    }
}
