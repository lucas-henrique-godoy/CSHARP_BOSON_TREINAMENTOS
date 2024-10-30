using System;

namespace Enumerações
{
    internal class Program
    {
        // OUTRO EXEMPLO: 
        // enum PontoCardeal { Norte = 10, Sul, Leste, Este = Leste, Oeste }; 
        // Definindo uma enumeração chamada PontoCardeal com valores Norte (10), Sul, Leste, Este (igual a Leste, ou seja, tanto faz chamar Este ou Leste) e Oeste, onde os valores são incrementais a partir de 10.

        // enum PontoCardeal { Norte, Sul, Leste, Oeste };
        enum PontoCardeal : byte { Norte, Sul, Leste, Este = Leste, Oeste };

        static void Main(string[] args)
        {
            ListaPontos();
            
            
            
            
            
            /*
            PontoCardeal direcao = PontoCardeal.Norte;            
            Console.WriteLine("Ponto cardeal: " + direcao);

            // Mostrando o índice da posição do valor Norte dentro da enumeração PontoCardeal
            PontoCardeal direcao1 = PontoCardeal.Norte;
            Console.WriteLine("Ponto cardeal: " + (int)direcao1); 
            */
        }

        static void ListaPontos() // Traz todo o conteúdo da enumeração
        { 
           PontoCardeal ponto = PontoCardeal.Norte;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(ponto);
                ponto++; // incrementando o índice de ponto
            }
            Console.WriteLine(ponto);

        }

    }
}
