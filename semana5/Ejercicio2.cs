public class Ejercicio2
{
    public static void Run()
    {
        List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
        foreach (var asignatura in asignaturas)
        {
            Console.WriteLine($"Yo estudio {asignatura}");
        }
    }
}
