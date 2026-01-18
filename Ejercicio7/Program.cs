
using System;

class Program
{
    static void Main()
    {
        var lista = new ListaEnlazada();

        while (true)
        {
            Console.WriteLine("\n=== Estacionamiento - Ing. de Sistemas ===");
            Console.WriteLine("a) Agregar vehículo");
            Console.WriteLine("b) Buscar vehículo por placa");
            Console.WriteLine("c) Ver vehículos por año");
            Console.WriteLine("d) Ver todos los vehículos");
            Console.WriteLine("e) Eliminar por placa");
            Console.WriteLine("s) Salir");
            Console.Write("Opción: ");
            string? op = Console.ReadLine();

            if (op == null) continue;
            op = op.Trim().ToLower();
            if (op == "s") break;

            switch (op)
            {
                case "a":
                    Console.Write("Placa: ");   string placa = Console.ReadLine()!;
                    Console.Write("Marca: ");   string marca = Console.ReadLine()!;
                    Console.Write("Modelo: ");  string modelo = Console.ReadLine()!;
                    Console.Write("Año: ");     int anio = int.Parse(Console.ReadLine()!);
                    Console.Write("Precio: ");  double precio = double.Parse(Console.ReadLine()!);
                    lista.Agregar(new Vehiculo(placa, marca, modelo, anio, precio));
                    Console.WriteLine("Vehículo agregado.");
                    break;

                case "b":
                    Console.Write("Placa a buscar: ");
                    var v = lista.BuscarPorPlaca(Console.ReadLine()!);
                    Console.WriteLine(v != null ? v.ToString() : "No existe un vehículo con esa placa.");
                    break;

                case "c":
                    Console.Write("Año: ");
                    lista.VerPorAnio(int.Parse(Console.ReadLine()!));
                    break;

                case "d":
                    lista.VerTodos();
                    break;

                case "e":
                    Console.Write("Placa a eliminar: ");
                    bool ok = lista.EliminarPorPlaca(Console.ReadLine()!);
                    Console.WriteLine(ok ? "Vehículo eliminado." : "No se encontró esa placa.");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        Console.WriteLine("Programa finalizado.");
    }
}
