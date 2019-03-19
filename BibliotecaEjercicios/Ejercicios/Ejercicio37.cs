using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio37
    {
        public void Impa()
        {
            Console.Clear();
            Console.WriteLine("****Realizar un Programa que permita ver los números impares comprendidos entre 1 y 499****");
            for (int x = 1; x <= 499; x++)
            {
                if (x == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
