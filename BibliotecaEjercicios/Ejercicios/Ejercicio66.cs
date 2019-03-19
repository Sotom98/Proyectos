using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio66
    {
        public int[] numero1;
        public int[] numero2;
        public int[] suma;
        public int[] resta;

        public void captura1()
        {
            numero1 = new int[12];
            Console.WriteLine("VECTOR 1");
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Ingrese valor para la posicion " + i + ": ");
                String nu;
                nu = Console.ReadLine();
                numero1[i] = int.Parse(nu);
            }
        }

        public void captura2()
        {
            numero2 = new int[12];
            Console.WriteLine("VECTOR 2");
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Ingrese valor para la posicion " + i + ": ");
                String nu;
                nu = Console.ReadLine();
                numero2[i] = int.Parse(nu);
            }
        }

        public void calcularcapt1()
        {
            suma = new int[12];
            Console.WriteLine("SUMA DE POSICION DEL VECTOR 1 + VECTOR 2");
            for (int i = 0; i < 12; i++)
            {
                suma[i] = numero1[i] + numero2[i];
                Console.WriteLine(suma[i]);
            }
        }

        public void calcularcapt2()
        {
            resta = new int[12];
            Console.WriteLine("RESTA DE POSICION DEL VECTOR 1 - VECTOR 2");
            for (int i = 0; i < 12; i++)
            {
                resta[i] = numero1[i] - numero2[i];
                Console.WriteLine(resta[i]);
            }
        }

        public void llamar()
        {
            captura1();
            captura2();
            calcularcapt1();
            calcularcapt2();
        }
    }
}

