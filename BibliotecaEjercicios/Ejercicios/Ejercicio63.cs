using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio63
    {
        public int[] numeros;

        public void cargar() {

            numeros = new int[20];

            for (int i=0; i<20; i++) {
                Console.WriteLine("Ingrese los numeros: ");
                String nu;
                nu = Console.ReadLine();
                numeros[i] = int.Parse(nu);
            }
        }

        public void mostrar() {
            int posicion;
            do
            {
                Console.WriteLine("¿Que posicion desea mostrar?");
                posicion = int.Parse(Console.ReadLine());
                Console.WriteLine(numeros[posicion]);
            } while (posicion < 20);

            Console.ReadKey();

        }
            //for (int i=0; i<20; i++) {
                //Console.WriteLine("Que posicion desea mostrar en pantalla: ");
                //Console.WriteLine(numeros[i]);
            //}
            
        }
    }

