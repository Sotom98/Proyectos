using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio49
    {
        public void ejer49()
        {
            int N, I = 1, may = 0, men = 9999, num = 0;

            Console.WriteLine("ingrese la cantidad de numeros");
            N = int.Parse(Console.ReadLine());

            while (I <= N)
            {
                Console.WriteLine("ingrese numeros ");
                num = int.Parse(Console.ReadLine());

                if (men >= num)
                {
                    men = num;
                }

                if (may <= num)
                {
                    may = num;
                }



                I++;
            }

            Console.WriteLine("numero mayor es : " + may);
            Console.WriteLine("numero menor es : " + men);
        }
    }
}
