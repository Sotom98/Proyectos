using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio33
    {
        public void Numi()
        {
            int val11, val12;
            Console.Clear();
            Console.WriteLine("****Realizar un Programa que permita ingresar un número cualquiera****");
            Console.WriteLine("Ingrese un numero");
            val11 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Si desea determinar que " + val11 + " es par o impar presione 1");
            Console.WriteLine("Si desea determinar que " + val11 + " es positivo o negativo presione 2");
            val12 = int.Parse(Console.ReadLine());
            switch (val12)
            {
                case 1:
                    Console.WriteLine("El numero ingresado es: **" + val11 + "**");
                    if (val11 == 0)
                    {
                        Console.WriteLine("El numero par");
                    }
                    else
                    {
                        Console.WriteLine("El numero es impar");
                    }
                    break;

                case 2:
                    Console.WriteLine("El numero ingresado es: **" + val11 + "**");
                    if (val11 <= -1)
                    {
                        Console.WriteLine("El numero es negativo");
                    }
                    else
                    {
                        Console.WriteLine("El numero es positivo");
                    }
                    break;

                default:
                    Console.WriteLine("Ha ingresado una opcion incorrecta");
                    break;
            }
        }
    }
}
