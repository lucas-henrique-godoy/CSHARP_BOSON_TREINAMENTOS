using System;

namespace Enumerações
{
    internal class Program
    {
        //OUTRO EXEMPLO: enum PontoCardeal { Norte = 10, Sul, Leste, Este = Leste, Oeste }; // Definindo uma enumeração chamada PontoCardeal com valores Norte (10), Sul, Leste, Este (igual a Leste, ou seja tano faz chamar Este ou Leste) e Oeste, onde os valores são incrementais a partir de 10.
        enum PontoCardeal { Norte, Sul, Leste, Oeste };
        static void Main(string[] args)
        {
            PontoCardeal direcao = PontoCardeal.Norte;            
            Console.WriteLine("Ponto cardeal: " + direcao );

            // Mostrando o índice da posição do valor Norte dentro da enumeração PontoCardeal
            PontoCardeal direcao1 = PontoCardeal.Norte;
            Console.WriteLine("Ponto cardeal: " + (int)direcao1);            
        }
    }
}
