using System;

namespace Operadores_Aritméticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define a codificação de saída para UTF-8 e possibilita mostrar o símbolo de infinity:  ∞
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double a = 5.0;
            double b = 0.0;

            Console.WriteLine("Valor dividido por zero: " + (a / b)); // Infinito
            Console.WriteLine("Zero dividido por um valor qualquer: " + (b / a)); // 0
            Console.WriteLine("Zero dividido por zero: " + (b / b)); // NaN
            Console.WriteLine("Soma de NaN com um valor qualquer, como 15: " + (15 + (b / b))); // NaN
            Console.WriteLine("Soma de Infinito com um valor qualquer, como 15: " + (15 + (a / b))); // Infinito
            Console.WriteLine("Zero vezes Infinito: " + (0 * (a / b))); // NaN
            Console.WriteLine("Zero vezes NaN: " + (0 * (b / b))); // NaN

            Console.ReadLine();
        }
    }
}
