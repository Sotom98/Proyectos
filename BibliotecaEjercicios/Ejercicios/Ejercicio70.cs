using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio70
    {

        private int[,] mat;

        public void Cargar()
        {
            Console.WriteLine("Cuantas Filas Tiene la Matriz:  ");
            string linea;
            linea = Console.ReadLine();
            int filas = int.Parse(linea);
            Console.WriteLine("Cuantas Columnas Tiene la Matriz :");
            linea = Console.ReadLine();
            int columnas = int.Parse(linea);
            mat = new int[filas, columnas];

            for (int f = 0; f < mat.GetLength(0) ; f++)
            {
                for(int c= 0; c< mat.GetLength(1) ; c++)
                {
                    Console.WriteLine("Ingrese Miembro de la Matriz");
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);

                }
            }
        }


        public void Imprimir()
        {
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write(mat[f,c]+" ");
                }
                Console.WriteLine();
            }

        }

        public void ImprimirUltimaFila()
        {
            Console.WriteLine("Ultima Fila");
            for (int c = 0; c < mat.GetLength(1); c++)
            {
                Console.Write(mat[mat.GetLength(0)-1,c] + " ");
            }

        }
        public void llamar()
        {
            
            Cargar();
            Imprimir();
            ImprimirUltimaFila();
            Console.ReadKey();
        }
    }
}
