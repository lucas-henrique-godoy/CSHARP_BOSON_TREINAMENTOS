using System;

namespace Laço_Wile_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            while (contador <= 10)
            {
                Console.WriteLine(contador.ToString()); 
                contador++;
            }

            int contador2 = 10;
            while (contador2 >= 0)
            {
                Console.WriteLine(contador2.ToString());
                contador2--;
            }
        }
    }
}
