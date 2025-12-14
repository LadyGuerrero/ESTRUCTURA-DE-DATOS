using System;

namespace Semana3
{
    // CLASE que gestiona el registro de estudiante
    public class Estudiante
    {
        // ✅ ID del estudiante
        public long ID { get; set; }
        
        // ✅ Nombres del estudiante
        public string Nombres { get; set; } = "";
        
        // ✅ Apellidos del estudiante
        public string Apellidos { get; set; } = "";
        
        // ✅ Dirección del estudiante
        public string Direccion { get; set; } = "";
        
        // ✅ ARRAY para almacenar 3 teléfonos (REQUISITO CUMPLIDO)
        public string[] Telefonos { get; set; }

        // Constructor que inicializa el array de teléfonos
        public Estudiante()
        {
            // Creamos el array con capacidad para 3 teléfonos
            Telefonos = new string[3];
        }

        // Método para mostrar toda la información
        public void MostrarInformacion()
        {
            Console.WriteLine("\nINFORMACION DEL ESTUDIANTE");
            Console.WriteLine("==========================");
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Nombres: " + Nombres);
            Console.WriteLine("Apellidos: " + Apellidos);
            Console.WriteLine("Direccion: " + Direccion);
            Console.WriteLine("\nTelefonos:");
            
            // Mostramos los 3 teléfonos del array
            Console.WriteLine("  Telefono 1: " + Telefonos[0]);
            Console.WriteLine("  Telefono 2: " + Telefonos[1]);
            Console.WriteLine("  Telefono 3: " + Telefonos[2]);
            Console.WriteLine("==========================\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE REGISTRO DE ESTUDIANTES\n");

            // Creamos el objeto estudiante
            Estudiante estudiante = new Estudiante();
            
            // Registramos todos los datos
            estudiante.ID = 0956055131;
            estudiante.Nombres = "Lady Melida";  
            estudiante.Apellidos = "Guerrero Quiñonez";  
            estudiante.Direccion = "Callejon 17, calle i, calle J";  
            
            // ✅ Almacenamos los 3 teléfonos en el ARRAY
            estudiante.Telefonos[0] = "0995919427";  
            estudiante.Telefonos[1] = "0960745192";   
            estudiante.Telefonos[2] = "043911266";  

            // Mostramos toda la información registrada
            estudiante.MostrarInformacion();

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}