using System;

namespace Enumerações
{
    internal class Program
    {
        // Definindo uma enumeração chamada PontoCardeal com valores Norte (10), Sul, Leste, Este (igual a Leste, ouseja tanto faz chmar Leste ou Este) e Oeste, onde os valores são incrementais a partir de 10.
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
