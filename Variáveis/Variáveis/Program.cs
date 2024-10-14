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

            /* Convertendo int para string
            int x = 90;
            bool a = false;
            int y;
            y = x;
            Console.WriteLine("O número é: " + x.ToString());
            Console.WriteLine("E o valor lógico é: " + a.ToString());
            Console.WriteLine("O número é: " + y.ToString());
            */

            // Fzendo as 2 conversões: string para int e int para string
            string valor01 = "25"; // variável declarada como string
            int num1 = Int32.Parse(valor01);
            int resultado = num1 * 2;
            Console.WriteLine("Resultado: " + resultado.ToString());

            Console.ReadLine();
        }
    }
}
