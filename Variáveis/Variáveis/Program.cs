using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variáveis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            int x = 90;
            bool a = false;
            int y;
            y = x;
            Console.WriteLine("O número é: " + x.ToString());
            Console.WriteLine("E o valor lógico é: " + a.ToString());
            Console.WriteLine("O número é: " + y.ToString());
            */

            double a = 5.0;
            double b = 0.0;

            Console.WriteLine("Valor dividido por zero: " + (a / b));
            Console.WriteLine("Zero dividido por um valor qualquer: " + (b / a));
            Console.WriteLine("Zero dividido por zero: " + (b / b));
            Console.WriteLine("Soma de NaN com um valor qualquer, como 15: " + (15 + (b / b)));
            Console.WriteLine("Soma de Infinito com um valor qualquer, como 15: " + (15 + (a / b)));
            Console.WriteLine("Zero vezes Infinito: " + (0 * (a / b)));
            Console.WriteLine("Zero vezes NaN: " + (0 * (b / b)));

           
            Console.ReadLine();
        }
    }
}
