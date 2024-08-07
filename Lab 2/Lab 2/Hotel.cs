using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Hotel
    {
        private List<Habitacion> habitaciones;
        public Hotel()
        {
            habitaciones = new List<Habitacion>();
        }
        public void AgregarHabitacion(Habitacion habitacion)
        {
            habitaciones.Add(habitacion);
        }
        public void EliminarHabitacion(int numero)
        {
            var habitacion = habitaciones.Find(h => h.Numero == numero);
            if (habitacion != null)
            {
                habitaciones.Remove(habitacion);
                Console.WriteLine($"Habitación {numero} eliminada.");
            }
            else
            {
                Console.WriteLine($"Habitación {numero} no encontrada.");
            }
        }

        public void MostrarHabitaciones()
        {
            foreach (var habitacion in habitaciones)
            {
                habitacion.MostrarInformacion();
                Console.WriteLine("------------------------");
            }
        }
        public void AsignarHabitacion(int numero, string nombreCliente)
        {
            var habitacion = habitaciones.Find(h => h.Numero == numero);
            if (habitacion != null && habitacion.Disponible)
            {
                habitacion.AsignarCliente(nombreCliente);
                Console.WriteLine($"Habitación {numero} asignada a {nombreCliente}.");
            }
            else
            {
                Console.WriteLine($"Habitación {numero} no disponible.");
            }
        }

        public void LiberarHabitacion(int numero)
        {
            var habitacion = habitaciones.Find(h => h.Numero == numero);
            if (habitacion != null && !habitacion.Disponible)
            {
                habitacion.LiberarHabitacion();
                Console.WriteLine($"Habitación {numero} liberada.");
            }
            else
            {
                Console.WriteLine($"Habitación {numero} no está ocupada.");
            }
        }
    }
}
