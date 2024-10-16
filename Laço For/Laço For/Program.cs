using System;

namespace Laço_For
{
    /*Neste caso, a variável contador terá como escopo o próprio lãço for, ou seja só é válida
    dentro do loop, ao encrrarmos o loop, a variável contador é desalocada.*/
    internal class Program
    {
        static void Main(string[] args)
        {            
            for (int contador = 1; contador <= 50; contador++)
            {
                Console.WriteLine(contador);
            }
            
        }
    }
}
