using System;

namespace Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, fatorial, cont;
            num = 0;
            fatorial = 1;

            Console.WriteLine("Entre com um número para o cálculo do fatorial: ");
            num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("Número inválido, apenas números maiores que 0!");
            }
            else if((num == 0) || (num == 1))
            {
                Console.WriteLine("O fatorial de {0} é 1.", num);
            }
            else
            {
                for (cont = num; cont >= 1; cont--)
                {
                    fatorial *= cont;
                }
                Console.WriteLine("Fatorial de {0} é {1}", num, fatorial);
            }
            Console.ReadLine(); 
        }
    }
}
