﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicios;

namespace BibliotecaEjercicios {
    class Biblioteca {
        public static void Main(string[] args) {
            int a;
            
            Console.WriteLine("Bienvenido a la biblioteca de ejercicios\nIngrese ejercicio (1 - 78)");
            Console.WriteLine("----------------------------------------");
            Console.Write("Ejercicio: ");
            a = int.Parse(Console.ReadLine());

            switch (a) {
                case 1:
                    Ejercicio1 ej1 = new Ejercicio1();
                    ej1.Suma();
                    break;
                case 2:
                    Ejercicio2 ej2 = new Ejercicio2();
                    ej2.Multi();
                    break;
                case 3:
                    Ejercicio3 ej3 = new Ejercicio3();
                    ej3.Divi();
                    break;
                case 4:
                    Ejercicio4 ej4 = new Ejercicio4();
                    ej4.Distan();
                    break;
                case 5:
                    Ejercicio5 ej5 = new Ejercicio5();
                    ej5.Edad();
                    break;
                case 6:
                    Ejercicio6 ej6 = new Ejercicio6();
                    ej6.Porcen();
                    break;
                case 7:
                    Ejercicio7 ej7 = new Ejercicio7();
                    ej7.Porcen();
                    break;
                case 8:
                    Ejercicio8 ej8 = new Ejercicio8();
                    ej8.Area();
                    break;
                case 9:
                    Ejercicio9 ej9 = new Ejercicio9();
                    ej9.Prom();
                    break;
                case 10:
                    Ejercicio10 ej10 = new Ejercicio10();
                    ej10.Fact();
                    break;
                case 11:
                    Ejercicio11 ej11 = new Ejercicio11();
                    ej11.Salario();
                    break;
                case 12:
                    Ejercicio12 ej12 = new Ejercicio12();
                    ej12.Perim();
                    break;
                case 13:
                    Ejercicio13 ej13 = new Ejercicio13();
                    ej13.Opers();
                    break;
                case 14:
                    Ejercicio14 ej14 = new Ejercicio14();
                    ej14.Opers();
                    break;
                case 15:
                    Ejercicio15 ej15 = new Ejercicio15();
                    ej15.Cred();
                    break;
                case 16:
                    Ejercicio16 ej16 = new Ejercicio16();
                    ej16.Edad();
                    break;
                case 17:
                    Ejercicio17 ej17 = new Ejercicio17();
                    ej17.Num();
                    break;
                case 18:
                    Ejercicio18 ej18 = new Ejercicio18();
                    ej18.MayMen();
                    break;
                case 19:
                    Ejercicio19 ej19 = new Ejercicio19();
                    ej19.Refri();
                    break;
                case 20:
                    Ejercicio20 ej20 = new Ejercicio20();
                    ej20.Midtad();
                    break;
                case 21:
                    Ejercicio21 ej21 = new Ejercicio21();
                    ej21.Opers();
                    break;
                case 22:
                    Ejercicio22 ej22 = new Ejercicio22();
                    ej22.Nota();
                    break;
                case 23:
                    Ejercicio23 ej23 = new Ejercicio23();
                    ej23.Pagar();
                    break;
                case 24:
                    Ejercicio24 ej24 = new Ejercicio24();
                    ej24.Opers();
                    break;
                case 25:
                    Ejercicio25 ej25 = new Ejercicio25();
                    ej25.Promo();
                    break;
                case 26:
                    Ejercicio26 ej26 = new Ejercicio26();
                    ej26.Cifras();
                    break;
                case 27:
                    Ejercicio27 ej27 = new Ejercicio27();
                    ej27.Pagar();
                    break;
                case 28:
                    Ejercicio28 ej28 = new Ejercicio28();
                    ej28.Par();
                    break;
                case 29:
                    Ejercicio29 ej29 = new Ejercicio29();
                    ej29.Temper();
                    break;
                case 30:
                    Ejercicio30 ej30 = new Ejercicio30();
                    ej30.Total();
                    break;
                case 31:
                    Ejercicio31 E31 = new Ejercicio31();
                    E31.Voca();
                    break;
                case 32:
                    Ejercicio32 E32 = new Ejercicio32();
                    E32.Duca();
                    break;
                case 33:
                    Ejercicio33 E33 = new Ejercicio33();
                    E33.Numi();
                    break;
                case 34:
                    Ejercicio34 E34 = new Ejercicio34();
                    E34.Edi_Eda_Edo_Edito();
                    break;
                case 35:
                    Ejercicio35 E35 = new Ejercicio35();
                    E35.Debi();
                    break;
                case 36:
                    Ejercicio36 E36 = new Ejercicio36();
                    E36.Cero();
                    break;
                case 37:
                    Ejercicio37 E37 = new Ejercicio37();
                    E37.Impa();
                    break;
                case 38:
                    Ejercicio38 E38 = new Ejercicio38();
                    E38.Dab();
                    break;
                case 39:
                    Ejercicio39 E39 = new Ejercicio39();
                    E39.Esss();
                    break;
                case 40:
                    Ejercicio40 E40 = new Ejercicio40();
                    E40.Dre();
                    break;
                case 41:
                    Ejercicio41 ej41 = new Ejercicio41();
                    ej41.ejer41();
                    break;
                case 42:
                    Ejercicio42 ej42 = new Ejercicio42();
                    ej42.ejer42();
                    break;
                case 43:
                    Ejercicio43 ej43 = new Ejercicio43();
                    ej43.ejer43();
                    break;
                case 44:
                    Ejercicio44 ej44 = new Ejercicio44();
                    ej44.ejer44();
                    break;
                case 45:
                    Ejercicio45 ej45 = new Ejercicio45();
                    ej45.ejer45();
                    break;
                case 46:
                    Ejercicio46 ej46 = new Ejercicio46();
                    ej46.ejer46();
                    break;
                case 47:
                    Ejercicio47 ej47 = new Ejercicio47();
                    ej47.ejer47();
                    break;
                case 48:
                    Ejercicio48 ej48 = new Ejercicio48();
                    ej48.ejer48();
                    break;
                case 49:
                    Ejercicio49 ej49 = new Ejercicio49();
                    ej49.ejer49();
                    break;
                case 50:
                    Ejercicio50 ej50 = new Ejercicio50();
                    ej50.ejer50();
                    break;
                case 51:
                    Ejercicio51 E51 = new Ejercicio51();
                    E51.Rep();
                    Console.ReadKey();
                    break;
                case 52:
                    Ejercicio52 E52 = new Ejercicio52();
                    E52.Deaf();
                    Console.ReadKey();
                    break;
                case 53:
                    Ejercicio53 E53 = new Ejercicio53();
                    E53.Fact();
                    Console.ReadKey();
                    break;
                case 54:
                    Ejercicio54 E54 = new Ejercicio54();
                    E54.Caja();
                    Console.ReadKey();
                    break;
                case 55:
                    Ejercicio55 E55 = new Ejercicio55();
                    E55.Emayor();
                    Console.ReadKey();
                    break;
                case 56:
                    Ejercicio56 E56 = new Ejercicio56();
                    E56.OperDW();
                    Console.ReadKey();
                    break;
                case 57:
                    Ejercicio57 E57 = new Ejercicio57();
                    E57.for_whil();
                    Console.ReadKey();
                    break;
                case 58:
                    Ejercicio58 E58 = new Ejercicio58();
                    E58.Man();
                    Console.ReadKey();
                    break;
                case 59:
                    Ejercicio59 E59 = new Ejercicio59();
                    E59.EdadesMatr();
                    Console.ReadKey();
                    break;
                case 60:
                    Ejercicio60 E60 = new Ejercicio60();
                    E60.NombMatr();
                    Console.ReadKey();
                    break;
                case 76:
                    Ejercicio76 obj = new Ejercicio76();
                    obj.llamar();
                    break;

                case 77:
                    Ejercicio77 obj77 = new Ejercicio77();
                    obj77.llamar();
                    break;

                case 78:
                    Ejercicio78 obj78 = new Ejercicio78();
                    obj78.llamar();
                    break;

                case 75:
                    Ejercicio75 obj75 = new Ejercicio75();
                    obj75.llamar();
                    break;


                case 72:
                    Ejercicio72 obj72 = new Ejercicio72();
                    obj72.llamar();
                    break;

                case 70:
                    Ejercicio70 obj70 = new Ejercicio70();
                    obj70.llamar();
                    break;

                case 71:
                    Ejercicio71 obj71 = new Ejercicio71();
                    obj71.llamar();
                    break;

                case 73:
                    Ejercicio73 obj73 = new Ejercicio73();
                    obj73.llamar();
                    break;

                case 74:
                    Ejercicio74 obj74 = new Ejercicio74();
                    obj74.llamar();
                    break;


                default:
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Valor no correcto, fin programa");
                    break;
            }

            Console.WriteLine("----------------------------------------");
            Console.ReadKey();
        }
    }
}
