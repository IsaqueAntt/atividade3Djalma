using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade3Djalma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b, h, result = 0, B;
            int cod;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" 1  Triangulo;");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" 2  hexágono ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" 3  Trapecio.");
           
            Console.ForegroundColor= ConsoleColor.White;
            Console.Write(" escolha o numero correspondente a forma geometrica acima:");
            cod = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Digite a base da forma geométrica:");
            b = Double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Digite a altura da forma geométrica:");
            h = Double.Parse(Console.ReadLine());
           

            switch (cod)
            {
                case 1:

                    result = (b * h) / 2;
                    break;
                case 2:

                    result =  (b * h) / 2;
                    break;
                case 3:
                   
                    Console.Write("Digite o outro lado da base do Trapecio:");
                    B = Double.Parse(Console.ReadLine());
                    result = (B + b) / 2;
                    result = result * h;
                    break;
            }
            
            
            
            Console.WriteLine(" A área dessa forma geométrica é:" + result);
            Console.ReadKey();
        }
    }
}
