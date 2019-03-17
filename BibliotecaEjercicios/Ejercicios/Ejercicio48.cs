using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio48
    {
        public void ejer48() {
            int N, I = 1, acumulador = 0;
            Console.WriteLine("ingrese la cantidad de numeros a sumar:  ");
            N = int.Parse(Console.ReadLine());

            while (I <= N)
            {
                acumulador = acumulador + I;

                I++;
            }
            Console.WriteLine("Su suma es: " + acumulador);
        }
    }
}
