using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_5
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Carnet { get; set; }
        public int Nota { get; set; }
    }

    public class EstudianteManager
    {
        private List<Persona> personas = new List<Persona>();

        public void AgregarEstudiantes(int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"Usuario numero: {i + 1}");
                Console.Write("Ingrese el carnet: ");
                int carnet = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el Nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese la nota: ");
                int nota = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                personas.Add(new Persona { Carnet = carnet, Nombre = nombre, Nota = nota });
            }
        }
        public void ListarEstudiantes()
        {
            if (personas.Count == 0)
            {
                Console.WriteLine("No hay estudiantes agregados.");
            }
            else
            {
                Console.WriteLine("Lista de todos los estudiantes:");
                foreach (var persona in personas)
                {
                    Console.WriteLine($"Carnet: {persona.Carnet}");
                    Console.WriteLine($"Nombre: {persona.Nombre}");
                    Console.WriteLine($"Nota: {persona.Nota}");
                }
            }
        }
        public void OrdenarPorNombre()
        {
            personas.Sort((p1, p2) => string.Compare(p1.Nombre, p2.Nombre, StringComparison.OrdinalIgnoreCase));
            ListarEstudiantes();
        }
        public void BuscarPorCarnet(int carnet)
        {
            var persona = personas.Find(p => p.Carnet == carnet);
            if (persona != null)
            {
                Console.WriteLine($"Estudiante encontrado:");
                Console.WriteLine($"Carnet: {persona.Carnet}");
                Console.WriteLine($"Nombre: {persona.Nombre}");
                Console.WriteLine($"Nota: {persona.Nota}");
            }
            else
            {
                Console.WriteLine($"No se encontró el carnet {carnet}");
            }
        }
        public void EliminarPorCarnet(int carnet)
        {
            var persona = personas.Find(p => p.Carnet == carnet);
            if (persona != null)
            {
                personas.Remove(persona);
                Console.WriteLine("Estudiante eliminado.");
            }
            else
            {
                Console.WriteLine($"No se encontró el carnet {carnet}");
            }
        }
    }
}
