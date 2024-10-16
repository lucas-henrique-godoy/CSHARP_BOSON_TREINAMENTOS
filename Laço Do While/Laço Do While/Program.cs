using System;

namespace Laço_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            do
            {
                Console.WriteLine(contador);
                contador++;
            }
            while (contador <= 50);
        }
    }
}
