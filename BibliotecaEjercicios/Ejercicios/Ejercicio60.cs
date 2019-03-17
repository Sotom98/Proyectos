using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio60
    {
        public void NombMatr()
        {

            String[] nombre = new String[15];

            Console.WriteLine("Ingrese el nombre de las 15 personas ");

            for (int i = 0; i < nombre.Length; i++)
            {
                nombre[i] = Console.ReadLine();
            }

            for (int j = 0; j < nombre.Length; j++)
            {
                Console.WriteLine(nombre[j]);
            }
        }
    }
}
