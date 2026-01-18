
using System;

public class ListaEnlazada
{
    public Nodo? Cabeza; // primer nodo

    // Agregar al final
    public void Agregar(Vehiculo v)
    {
        Nodo nuevo = new Nodo(v);

        if (Cabeza == null)
        {
            Cabeza = nuevo;
            return;
        }

        Nodo actual = Cabeza;
        while (actual.Siguiente != null)
            actual = actual.Siguiente;

        actual.Siguiente = nuevo;
    }

    // Buscar por placa (devuelve Vehiculo o null)
    public Vehiculo? BuscarPorPlaca(string placa)
    {
        Nodo? actual = Cabeza;
        while (actual != null)
        {
            if (actual.Valor.Placa == placa) return actual.Valor;
            actual = actual.Siguiente;
        }
        return null;
    }

    // Ver por año (imprime coincidencias)
    public void VerPorAnio(int anio)
    {
        Console.WriteLine($"Vehículos del año {anio}:");
        Nodo? actual = Cabeza;
        bool hay = false;
        while (actual != null)
        {
            if (actual.Valor.Anio == anio)
            {
                Console.WriteLine("  " + actual.Valor);
                hay = true;
            }
            actual = actual.Siguiente;
        }
        if (!hay) Console.WriteLine("  (no hay vehículos de ese año)");
    }

    // Ver todos
    public void VerTodos()
    {
        Console.WriteLine("Vehículos registrados:");
        if (Cabeza == null)
        {
            Console.WriteLine("  (lista vacía)");
            return;
        }

        Nodo? actual = Cabeza;
        while (actual != null)
        {
            Console.WriteLine("  " + actual.Valor);
            actual = actual.Siguiente;
        }
    }

    // Eliminar por placa (true si eliminó)
    public bool EliminarPorPlaca(string placa)
    {
        if (Cabeza == null) return false;

        // Si el primero coincide
        if (Cabeza.Valor.Placa == placa)
        {
            Cabeza = Cabeza.Siguiente;
            return true;
        }

        // Buscar el anterior al que se eliminará
        Nodo actual = Cabeza;
        while (actual.Siguiente != null && actual.Siguiente.Valor.Placa != placa)
            actual = actual.Siguiente;

        if (actual.Siguiente == null) return false; // no encontrado

        // Saltar el nodo
        actual.Siguiente = actual.Siguiente.Siguiente;
        return true;
    }
}
