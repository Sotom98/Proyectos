using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio44
    {
        public void ejer44() {
            int I, desde;
            Console.WriteLine("desde");
            desde = int.Parse(Console.ReadLine());



            Console.WriteLine("los multiplos de 3 con limite 99");
            for (I = 1; I <= 10; I++)
            {

                Console.WriteLine(I + "*" + desde + "=" + (I * desde));


            }


        }
    }
}
