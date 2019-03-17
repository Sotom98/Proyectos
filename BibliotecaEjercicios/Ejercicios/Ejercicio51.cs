using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio51
    {
        public void Rep()
        {
            int n_veces, n_sab, numer;
            int n_rep = 0;
            Console.WriteLine("Digite la cantidad de numeros que desea ingresar");
            n_veces = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero, que desee saber cuantas veces se repite");
            n_sab = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los " + n_veces + " numeros a continuacion");

            for (int i = 0; i < n_veces; i++)
            {

                numer = int.Parse(Console.ReadLine());
                if (numer == n_sab)
                {
                    n_rep = n_rep + 1;
                }

            }
            Console.WriteLine("El numero " + n_sab + " Se repite " + n_rep + " veces");

        }
    }

}

