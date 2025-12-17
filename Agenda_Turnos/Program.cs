using System;

namespace Agenda_Turnos
{
    // Clase Paciente (vector de pacientes)
    public class Paciente
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
    }

    // Struct Turno (matriz de turnos)
    public struct Turno
    {
        public string CedulaPaciente { get; set; }
        public string Motivo { get; set; }
    }

    // Clase Clinica (gestiona pacientes y turnos)
    public class Clinica
    {
        private Paciente[] pacientes = new Paciente[50];       // vector de pacientes
        private Turno?[,] agenda = new Turno?[5, 4];           // matriz de turnos (5 días, 4 slots)

        // Registrar paciente
        public bool RegistrarPaciente(Paciente p)
        {
            for (int i = 0; i < pacientes.Length; i++)
            {
                if (pacientes[i] == null)
                {
                    pacientes[i] = p;
                    return true;
                }
            }
            return false; // lleno
        }

        // Asignar turno
        public bool AsignarTurno(string cedula, int dia, int slot, string motivo)
        {
            if (agenda[dia, slot].HasValue) return false; // ocupado
            agenda[dia, slot] = new Turno { CedulaPaciente = cedula, Motivo = motivo };
            return true;
        }

        // Mostrar pacientes
        public void MostrarPacientes()
        {
            Console.WriteLine("Pacientes registrados:");
            foreach (var p in pacientes)
            {
                if (p != null)
                    Console.WriteLine($"{p.Cedula} - {p.Nombre} - {p.Telefono}");
            }
        }

        // Mostrar agenda de un día
        public void MostrarAgendaDia(int dia)
        {
            Console.WriteLine($"Agenda del día {dia}:");
            for (int s = 0; s < 4; s++)
            {
                if (agenda[dia, s].HasValue)
                    Console.WriteLine($"Slot {s}: {agenda[dia, s]?.CedulaPaciente} ({agenda[dia, s]?.Motivo})");
                else
                    Console.WriteLine($"Slot {s}: LIBRE");
            }
        }
    }

    // Programa principal con menú
    class Program
    {
        static void Main()
        {
            Clinica clinica = new Clinica();

            while (true)
            {
                Console.WriteLine("\n=== Agenda de turnos de pacientes de una clínica ===");
                Console.WriteLine("1. Registrar paciente");
                Console.WriteLine("2. Asignar turno");
                Console.WriteLine("3. Ver pacientes");
                Console.WriteLine("4. Ver agenda de un día");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.Write("Cédula: ");
                        string ced = Console.ReadLine();
                        Console.Write("Nombre: ");
                        string nom = Console.ReadLine();
                        Console.Write("Teléfono: ");
                        string tel = Console.ReadLine();
                        clinica.RegistrarPaciente(new Paciente { Cedula = ced, Nombre = nom, Telefono = tel });
                        break;

                    case "2":
                        Console.Write("Cédula paciente: ");
                        string c = Console.ReadLine();
                        Console.Write("Día (0-4): ");
                        int d = int.Parse(Console.ReadLine());
                        Console.Write("Slot (0-3): ");
                        int s = int.Parse(Console.ReadLine());
                        Console.Write("Motivo: ");
                        string m = Console.ReadLine();
                        if (clinica.AsignarTurno(c, d, s, m))
                            Console.WriteLine("Turno asignado.");
                        else
                            Console.WriteLine("Slot ocupado.");
                        break;

                    case "3":
                        clinica.MostrarPacientes();
                        break;

                    case "4":
                        Console.Write("Día (0-4): ");
                        int dia = int.Parse(Console.ReadLine());
                        clinica.MostrarAgendaDia(dia);
                        break;

                    case "0":
                        return;
                }
            }
        }
    }
}
