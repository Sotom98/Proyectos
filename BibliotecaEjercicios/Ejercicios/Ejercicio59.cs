using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio59
    {

        public void EdadesMatr()
        {

            int[] edad = new int[10];

            Console.WriteLine("Ingrese la edad de las 10 personas");

            for (int i = 0; i < edad.Length; i++)
            {
                edad[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 1; j < edad.Length; j++)
            {
                Console.WriteLine(j + "- " + edad[j]);

            }
            Console.ReadKey();
        }
    }
}
