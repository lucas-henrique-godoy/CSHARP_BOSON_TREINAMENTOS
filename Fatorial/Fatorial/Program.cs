using System;

namespace Fatorial
{
    // A classe Program contém o método Main, que é o ponto de entrada do programa
    internal class Program
    {
        // Método principal do programa onde a execução começa
        static void Main(string[] args)
        {
            // Declaração de variáveis:
            // 'num' será o número inserido pelo usuário para calcular o fatorial
            // 'fatorial' guarda o valor do fatorial (inicializado com 1)
            // 'cont' é utilizado como contador no loop 'for'
            int num, fatorial, cont;

            // Inicializa 'num' com 0 e 'fatorial' com 1
            num = 0;
            fatorial = 1;

            // Solicita que o usuário insira um número para calcular o fatorial
            Console.WriteLine("Entre com um número para o cálculo do fatorial: ");

            // Converte a entrada do usuário (string) para um número inteiro
            num = int.Parse(Console.ReadLine());

            // Verifica se o número inserido é negativo
            if (num < 0)
            {
                // Se o número for negativo, imprime uma mensagem de erro
                Console.WriteLine("Número inválido, apenas números maiores que 0!");
            }
            // Verifica se o número inserido é 0 ou 1, pois o fatorial de 0 e 1 é 1
            else if ((num == 0) || (num == 1))
            {
                // Se o número for 0 ou 1, o fatorial é 1
                Console.WriteLine("O fatorial de {0} é 1.", num);
            }
            else
            {
                // Se o número for maior que 1, calcula o fatorial com um loop 'for'
                // O loop começa de 'num' e vai até 1 (decrementando de 1 em 1)
                for (cont = num; cont >= 1; cont--)
                {
                    // O fatorial é multiplicado pelo valor de 'cont' em cada iteração
                    fatorial *= cont;
                }

                // Exibe o resultado do cálculo do fatorial
                Console.WriteLine("Fatorial de {0} é {1}", num, fatorial);
            }

            // Aguarda o usuário pressionar Enter para fechar o programa
            Console.ReadLine();
        }
    }
}
