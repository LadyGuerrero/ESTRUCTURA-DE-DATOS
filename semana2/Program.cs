using System;

namespace FigurasGeometricas
{
    // Clase Circulo
    public class Circulo
    {
        // Atributo privado que almacena el radio del círculo
        private double radio;

        // Constructor que inicializa el radio
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // CalcularArea es una función que devuelve un valor double
        // Se utiliza para calcular el área de un círculo
        // Fórmula: π * radio^2
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        // CalcularPerimetro es una función que devuelve un valor double
        // Se utiliza para calcular el perímetro (circunferencia) de un círculo
        // Fórmula: 2 * π * radio
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    // Clase Rectangulo
    public class Rectangulo
    {
        // Atributos privados que almacenan la base y la altura del rectángulo
        private double baseRectangulo;
        private double altura;

        // Constructor que inicializa la base y la altura
        public Rectangulo(double baseRectangulo, double altura)
        {
            this.baseRectangulo = baseRectangulo;
            this.altura = altura;
        }

        // CalcularArea es una función que devuelve un valor double
        // Se utiliza para calcular el área de un rectángulo
        // Fórmula: base * altura
        public double CalcularArea()
        {
            return baseRectangulo * altura;
        }

        // CalcularPerimetro es una función que devuelve un valor double
        // Se utiliza para calcular el perímetro de un rectángulo
        // Fórmula: 2 * (base + altura)
        public double CalcularPerimetro()
        {
            return 2 * (baseRectangulo + altura);
        }
    }

    // Clase principal para probar las figuras
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto de la clase Circulo con radio = 5
            Circulo c = new Circulo(5);
            Console.WriteLine("Área del círculo: " + c.CalcularArea());
            Console.WriteLine("Perímetro del círculo: " + c.CalcularPerimetro());

            // Crear un objeto de la clase Rectangulo con base = 4 y altura = 6
            Rectangulo r = new Rectangulo(4, 6);
            Console.WriteLine("Área del rectángulo: " + r.CalcularArea());
            Console.WriteLine("Perímetro del rectángulo: " + r.CalcularPerimetro());
        }
    }
}
