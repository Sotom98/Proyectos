using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio58
    {

        public void Man()
        {
            int N;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Ingrese una de las siguientes opciones:");
                Console.WriteLine("Presione 1 para saber los numeros pares del 0 hasta 100");
                Console.WriteLine("Presione 2 si desea saber los multiplos de 4");
                Console.WriteLine("Presione 3 si desea saber la tabla del 10");
                Console.WriteLine("Presione 0 si desea salir del programa");
                N = int.Parse(Console.ReadLine());

                switch (N)
                {
                    case 1:

                        for (int i = 2; i <= 100; i += 2)
                        {
                            Console.WriteLine(i);
                        }

                        break;

                    case 2:

                        for (int i = 0; i < 100; i++)
                        {
                            if (i % 4 == 0)
                                Console.Write("{0}|", i);
                        }
                        break;

                    case 3:
                        for (int i = 1; i <= 10; i++)
                        {
                            int num = 10;
                            int resultado = num * i;
                            Console.WriteLine(num + " * " + i + " = " + resultado);
                        }

                        break;
                }

            } while (N > 0);
        }
    }

}
