using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios {
    public class Ejercicio29 {
        public void Temper() {
            Console.WriteLine("----------------------------------------");
            double temp = 0;
            double prom = 0;

            for (int i = 0; i < 7; i++) {
                Console.Write("Ingrese temperatura de " + (i + 1) + ": ");
                temp = double.Parse(Console.ReadLine());
                prom = prom + temp;
            }

            Console.WriteLine("----------------------------------------");
            prom = prom / 7;
            Console.WriteLine(prom);

            if (prom < 15) {
                Console.WriteLine("Que semana tan fría");
            }
            else if (prom >= 15 && prom <= 35) {
                Console.WriteLine("Que clima tan delicioso");
            }
            else {
                Console.WriteLine("Que semana tan calurosa");
            }
        }
    }
}
