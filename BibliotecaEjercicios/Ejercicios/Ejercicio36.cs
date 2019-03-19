using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio36
    {
        public void Cero()
        {
            Console.Clear();
            Console.WriteLine("****Realizar un Programa que permita ver los números pares comprendidos entre 0 y 200****");
            for (int i = 2; i <= 200; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
