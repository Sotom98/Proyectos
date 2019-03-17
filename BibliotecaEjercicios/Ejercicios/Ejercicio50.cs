using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio50
    {
        public void ejer50()
        {
            int I = 0, N;
            double acumulador = 0, num;

            Console.WriteLine("ingrese cantidad de numeros: ");
            N = int.Parse(Console.ReadLine());

            while (I <= N)
            {

                Console.WriteLine("ingres numero: ");
                num = int.Parse(Console.ReadLine());

                acumulador = acumulador + num;
                I++;
            }
            Console.WriteLine("EL cubo: " + (Math.Pow(acumulador, 3)));
            Console.WriteLine("La cuarta: " + (Math.Pow(acumulador, 4)));
            Console.WriteLine("La quinta: " + (Math.Pow(acumulador, 5)));


        }
    }
}
