using System;

namespace Ejercicios
{
    public class Ejercicio72
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

            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.WriteLine("Ingrese Miembro de la Matriz");
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);

                }
            }
        }

        public void Pos()
        {
            int mayor = mat[0, 0];
            int filamay = 0;
            int columnamay = 0;
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    if (mat[f, c] > mayor)
                    {
                        mayor = mat[f, c];
                        filamay = f;
                        columnamay = c;
                    }
                }
            }
            Console.WriteLine("El elemento mayor es:" + mayor);
            Console.WriteLine("Se encuentra en la fila:" + filamay + " y en la columna: " + columnamay);
            Console.ReadLine();

        }
        public void llamar()
        {
            
            Cargar();
            Pos();
            Console.ReadKey();
        }
    }
}
