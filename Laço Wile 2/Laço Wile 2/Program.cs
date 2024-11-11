using System;

namespace Laço_Wile_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int contador = 1;
            while (contador <= 50)
            {
                Console.WriteLine(contador.ToString()); 
                contador++;
            } 
            */

            Console.WriteLine("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            if ((num == 0) || (num < 0))
            {
                Console.WriteLine("Erro, número negativo ou igual a zero");
            }
            else
            {
                int i = 1;
                while (i <= num)
                {
                    Console.WriteLine(i.ToString());
                    i++;
                }
            }

            
        }
    }
}
