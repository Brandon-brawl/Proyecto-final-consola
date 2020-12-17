using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalConsola
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.WriteLine(n);
                n++;
            
           
            int resultado = 0;
            int dato = 0;
            Console.WriteLine("Elige una temperatura \n" +
                "\n1.-Celsius a Fahrenehit " +
                "\n2.-Celsius a Kelvin  " +
                "\n3.-Fahrenehit a Celsius" +
                "\n4.-Fahrenhiet a Kelvin" +
                "\n5.Kelvin a Celsius" +
                "\n6.Kelvin a Fahrenheit" +
                "\n7-Salir\n");
            Console.WriteLine("ingrsa dato de dato: ");
            dato = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Selecciona una de las opciones anteriores");

            resultado = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("n8.-Salir");
            double resultCaF = (dato * 1.8 + 32);
            double resultCaK = (dato + 273.25);
            double resultFaC = ((dato - 32) / 1.8);
            double resultFaK = (((dato - 32) / 1.8) + 173.15);
            double resultKaC = (dato - 273.15);
            double resultKaF = ((dato - 273.15) * 1.8 + 32);

           
            switch (resultado)
            {
                case 1:

                    Console.WriteLine((" El resultado de Celsius a Fahreneit es : ") + resultCaF);

                    break;
                case 2:
                    Console.WriteLine(" El resultado de Celsius a Kelvin es : " + resultCaK);
                    break;
                case 3:
                    Console.WriteLine(" El resultado de Fahrenehit a Celsius es : " + resultFaC);
                    break;
                case 4:
                    Console.WriteLine(" El resultado de Fahrenhiet a Kelvin : " + resultFaK);
                    break;
                case 5:
                    Console.WriteLine("  El resultado de Kelvin a Celsius : " + resultKaC);

                    break;
                case 6:
                    Console.WriteLine(" El resultado de Kelvin a Fahrenheit : " + resultKaF);
                    break;
                case 7:
                    Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("falta seleccionar la operacion, error");

                        break;
            }
            
             Console.WriteLine("Selecciona cualquier tecla para restear");
              
                Console.ReadKey();
            } while (n < 5) ;
           

        }
       
    }
}
