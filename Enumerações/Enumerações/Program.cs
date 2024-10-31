using System;

namespace Enumerações
{
    internal class Program
    {
        // OUTRO EXEMPLO: 
        // enum PontoCardeal { Norte = 10, Sul, Leste, Este = Leste, Oeste }; 
        // Definindo uma enumeração chamada PontoCardeal com valores Norte (10), Sul, Leste, Este (igual a Leste, ou seja, tanto faz chamar Este ou Leste) e Oeste, onde os valores são incrementais a partir de 10.
        // enum PontoCardeal { Norte, Sul, Leste, Oeste };


        //___________________________________________________________________________

        // Define um enum chamado PontoCardeal, que representa os pontos cardeais. O tipo de dados subjacente é byte, economizando espaço na memória.
        // Os valores possíveis são:  Norte (0), Sul (1), Leste (2), Este (também representa Leste, ou seja, 2), Oeste (3)
        enum PontoCardeal : byte { Norte, Sul, Leste, Este = Leste, Oeste };

        static void Main(string[] args)
        {
            ListaPontos(); // Chamando o método.
            
            
            
            
            
            /*
            PontoCardeal direcao = PontoCardeal.Norte;            
            Console.WriteLine("Ponto cardeal: " + direcao);

            // Mostrando o índice da posição do valor Norte dentro da enumeração PontoCardeal
            PontoCardeal direcao1 = PontoCardeal.Norte;
            Console.WriteLine("Ponto cardeal: " + (int)direcao1); 
            */
        }

        // Método que lista os valores da enumeração PontoCardeal.
        static void ListaPontos() // Traz todo o conteúdo da enumeração
        {
            // Inicializa a variável ponto com o primeiro valor da enumeração (Norte).
            PontoCardeal ponto = PontoCardeal.Norte;

            // Loop que executa 3 vezes.
            for (int i = 0; i < 3; i++)
            {
                // Imprime o valor atual de ponto (começa com Norte).
                Console.WriteLine(ponto);

                // Incrementa ponto para o próximo valor da enumeração.
                ponto++;
            }

            // Imprime o valor final de ponto após o loop (será Leste após 3 iterações).
            Console.WriteLine(ponto);
        }

    }
}
