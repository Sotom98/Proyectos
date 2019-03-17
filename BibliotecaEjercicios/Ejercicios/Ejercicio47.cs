using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio47
    {
        public void ejer47()
        {
            int a, b;


            while (true)
            {

                Console.WriteLine("ingres base: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("ingres exponete: ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("resultado: " + (Math.Pow(a, b)));
            }
        }
    }
}
