﻿using System;

namespace Enumerações
{
    internal class Program
    {
        enum PontoCardeal { Norte, Sul, Leste, Oeste };
        static void Main(string[] args)
        {
            PontoCardeal direcao = PontoCardeal.Norte;            
            Console.WriteLine("Ponto cardeal: " + direcao );

            // Mostrando o índice da posição do valor Oeste dentro na enumeração PontoCardeal
            PontoCardeal direcao1 = PontoCardeal.Oeste;
            Console.WriteLine("Ponto cardeal: " + (int)direcao1);
        }
    }
}
