
public class Vehiculo
{
    public string Placa;
    public string Marca;
    public string Modelo;
    public int Anio;
    public double Precio;

    public Vehiculo(string placa, string marca, string modelo, int anio, double precio)
    {
        Placa = placa;
        Marca = marca;
        Modelo = modelo;
        Anio = anio;
        Precio = precio;
    }

    public override string ToString()
    {
        return $"Placa: {Placa} | Marca: {Marca} | Modelo: {Modelo} | Año: {Anio} | Precio: {Precio}";
    }
}
