using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio53
    {
        public void Fact()
        {
            int numero, resultado = 1;

            Console.WriteLine("Inserte el numero a factorizar:");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                resultado = resultado * numero;
                numero = numero - 1;
            }

            Console.WriteLine("El factorial del numero es:" + resultado);
            
        }
    }
}
