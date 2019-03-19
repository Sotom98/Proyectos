using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio68
    {
        public int[] vector1;
        int mayor=0, menor=0;

        public void capturar() {
            vector1 = new int[20];
            for (int i=0; i<20; i++) {
                Console.WriteLine("Cuantos estudiantes tiene el salon "+i+"?");
                String nu;
                nu = Console.ReadLine();
                vector1[i]= int.Parse(nu);
            }
        }

        public void totalestudiantes() {
            int totalest = 0;
            //vector1 = new int[20];
            for (int i=0; i<20; i++) {
                totalest = totalest + vector1[i];
            }
            Console.WriteLine("El total de estudiantes es: "+totalest);
            Console.ReadKey();
        }

        public void mayormenor() {
            vector1 = new int[20];
            for (int i = 0; i < 20; i++)
            {
                if (vector1[i] > vector1[i])
                {
                    mayor=vector1[i];
                } else if(vector1[i]<vector1[i]){
                    menor=vector1[i];
                }
            }
        }

        public void imprimir() {
            Console.WriteLine("El curso con mayor estudiantes es: "+mayor);
            Console.WriteLine("El curso con menor estudiantes es: " + menor);
        }

        public void llamar()
        {
            capturar();
            totalestudiantes();
            mayormenor();
            imprimir();
            
        }
    }
}
