using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio40
    {
        public void Dre()
        {
            int val11;
            double val12;
            Console.Clear();
            for (int x = 1; x <= 15; x++)
            {
                Console.WriteLine("Ingrese su edad");
                val11 = int.Parse(Console.ReadLine());
                val12 = val11 / x;
                Console.WriteLine("La edad promedio en este momento es: " + val12);
            }
        }
    }
}
