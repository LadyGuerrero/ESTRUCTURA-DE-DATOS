class Program
{
    static void Main(string[] args)
    {
        BST tree = new BST();
        int option;

        do
        {
            Console.WriteLine("\n--- MENÚ BST ---");
            Console.WriteLine("1. Insertar");
            Console.WriteLine("2. Buscar");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Recorridos");
            Console.WriteLine("5. Mínimo y Máximo");
            Console.WriteLine("6. Altura");
            Console.WriteLine("7. Limpiar árbol");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Ingrese valor: ");
                    int val = int.Parse(Console.ReadLine());
                    tree.Insert(val);
                    break;
                case 2:
                    Console.Write("Valor a buscar: ");
                    val = int.Parse(Console.ReadLine());
                    var found = tree.Search(tree.Root, val);
                    Console.WriteLine(found != null ? "Encontrado" : "No encontrado");
                    break;
                case 3:
                    Console.Write("Valor a eliminar: ");
                    val = int.Parse(Console.ReadLine());
                    tree.Root = tree.Delete(tree.Root, val);
                    break;
                case 4:
                    Console.WriteLine("InOrden:");
                    tree.InOrder(tree.Root);
                    Console.WriteLine("\nPreOrden:");
                    tree.PreOrder(tree.Root);
                    Console.WriteLine("\nPostOrden:");
                    tree.PostOrder(tree.Root);
                    break;
                case 5:
                    Console.WriteLine("Mínimo: " + tree.FindMin(tree.Root));
                    Console.WriteLine("Máximo: " + tree.FindMax(tree.Root));
                    break;
                case 6:
                    Console.WriteLine("Altura: " + tree.Height(tree.Root));
                    break;
                case 7:
                    tree.Clear();
                    Console.WriteLine("Árbol limpiado.");
                    break;
            }
        } while (option != 0);
    }
}

