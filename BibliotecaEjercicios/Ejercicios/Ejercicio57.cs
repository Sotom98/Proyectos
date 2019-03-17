using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio57
    {
        public void for_whil()
        {
            int numero, expo, potencia = 1, resultado = 1;

            Console.WriteLine("Inserta el numero a factorizar:");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                resultado = resultado * i;
            }
            Console.WriteLine("El factorial de " + numero + " es:" + resultado);
            Console.WriteLine("");

            Console.WriteLine("Ingrese el exponente");
            expo = int.Parse(Console.ReadLine());

            while (0 < expo)
            {
                potencia = potencia * numero;
                expo--;
            }

            Console.WriteLine("La Potencia es: " + potencia);
        }
    }
}