using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio56
    {
        public void OperDW()
        {
            int N;
            double resta, suma, multip, divis;
                        
            do
            {
                Console.WriteLine("a continuacion ingrese dos numeros");
                double Val1 = double.Parse(Console.ReadLine());
                double Val2 = double.Parse(Console.ReadLine());

                suma = Val1 + Val2;
                resta = Val1 - Val2;
                multip = Val1 * Val2;
                divis = Val1 / Val2;
                

                Console.WriteLine("La suma de estos numeros es: " + suma);
                Console.WriteLine("La resta de estos numeros es: " + resta);
                Console.WriteLine("La multiplicacion de estos numeros es: " + multip);
                Console.WriteLine("La division de estos numeros es es: " + divis);

                Console.WriteLine("Presione 1 para continuar y 0 para salir");
                N = int.Parse(Console.ReadLine());

            } while (N > 0);
            
        }
    }
}
