using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_10
{
    internal class Productos
    {
        public List<string> Nombre;
        public List<string> Tipo;
        public List<int> Año;
        public Productos()
        {
            Nombre = new List<string>();
            Tipo = new List<string>();
            Año = new List<int>();
        }
        public void AgregarProducto()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.Write("Ingrese el nombre del Producto: ");
            string nombre = Console.ReadLine();
            Console.Write("¿Que es? (Telefono, Ordenador, Tablet)");
            string tipo = Console.ReadLine();
            Console.Write("Ingrese el año del Modelo: ");
            int año = Convert.ToInt32(Console.ReadLine());
            if (nombre != "" && tipo != "" && año > 1000)
            {
                Nombre.Add(nombre);
                Tipo.Add(tipo);
                Año.Add(año);
                Console.WriteLine("Libro agregado exitosamente");
            }
            else
            {
                Console.WriteLine("Uno de sus parametros no es correcto...");
            }
        }
        public int BuscarProducto(string nombre)
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            int posicion = Nombre.IndexOf(nombre);
            Console.WriteLine("MOSTRANDO INFORMACION DEL PRODUCTO :");
            Console.WriteLine("          PRODUCTO REGISTRADO    ");
            Console.WriteLine("--------> " + posicion + " <--------");
            Console.WriteLine(Nombre[posicion]);
            Console.WriteLine(Tipo[posicion]);
            Console.WriteLine(Año[posicion]);
            Console.WriteLine("-----------------------------------------------");
            return posicion;
        }
        public void MostrarProducto()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            if (Año.Count > 0)
            {
                Console.WriteLine("MOSTRANDO DATOS EXISTENTES....");
                for (int i = 0; i < Año.Count; i++)
                {
                    Console.WriteLine("Nombre: " + Nombre[i]);
                    Console.WriteLine("Modelo: " + Tipo[i]);
                    Console.WriteLine("Año: " + Año[i]);
                    Console.WriteLine(" ");
                }
            }
            else { Console.WriteLine("NO HAY NINGUN REGISTRO"); }
        }
        public void EliminarProducto()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("MOSTRANDO DATOS EXISTENTES");
            MostrarProducto();
            Console.WriteLine("Ingrese el nombre del producto: ");
            string nombre = Console.ReadLine();
            int posicion = BuscarProducto(nombre);
            if (posicion >= 0)
            {
                Nombre.RemoveAt(posicion);
                Tipo.RemoveAt(posicion);
                Año.RemoveAt(posicion);
                Console.WriteLine("El Producto se ha eliminado de la biblioteca: ");
            }
            else
            {
                Console.WriteLine("El Producto no se ha encontrado...");
            }
        }
        public void EditarProducto()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Libros en la Biblioteca");
            MostrarProducto();
            Console.WriteLine("Ingrese el nombre del libro: ");
            string nombre = Console.ReadLine();
            int posicion = BuscarProducto(nombre);
            if (posicion >= 0)
            {
                Nombre.RemoveAt(posicion);
                Tipo.RemoveAt(posicion);
                Año.RemoveAt(posicion);
                Console.WriteLine("El libro se ha eliminado de la biblioteca: ");
                Console.WriteLine("Agregue el nuevo libro....");
                AgregarProducto();
            }
            else
            {
                Console.WriteLine("El libro no se ha encontrado...");
            }
        }
        public void LimpiarConsola()
        {
            Console.WriteLine("FIN DE LA OPERACION, PRESIONE UNA TECLA PARA CONTINUAR");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
