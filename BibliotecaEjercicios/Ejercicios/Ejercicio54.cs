using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio54
    {
        public void Caja()
        {
            Console.WriteLine("¿Cuantos productos desea pagar?");
            int cant = int.Parse(Console.ReadLine());
            int a = 1;
            double total = 0;
            while (a <= cant)
            {
                Console.WriteLine("Ingrese el precio del producto");
                double Producto = double.Parse(Console.ReadLine());
                total = total + Producto;
                a++;
            }
            Console.WriteLine("Su total a pagar es de: $" + total);
            
        }
    }
}
