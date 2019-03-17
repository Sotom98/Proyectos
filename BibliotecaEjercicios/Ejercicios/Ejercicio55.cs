using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio55
    {
        public void Emayor()
        {
            Console.WriteLine("Ingrese el numero de estudiantes en su aula");
            int n_estud = int.Parse(Console.ReadLine());
            double may = 0;
            
                for (int i = 0; i < n_estud; i++)
                {
                    Console.WriteLine("Ingrese la estatura del estudiante");
                    double Esta = double.Parse(Console.ReadLine());

                    if (i == 0)
                    {
                        may = Esta;
                    }
                    else if (i != 0)
                    {
                        if (Esta > may)
                        {
                            may = Esta;
                        }
                    }

                }
             
            Console.WriteLine("La estatura mayor es: " + may);
        }
    }
}
