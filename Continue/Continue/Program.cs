using System;

namespace Continue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero;  // Declara uma variável 'numero' do tipo inteiro

            while (true)  // Inicia um laço infinito que continuará até ser explicitamente interrompido
            {
                Console.WriteLine("Digite um número entre 10 e 20: ");  // Exibe uma mensagem pedindo ao usuário que digite um número
                numero = int.Parse(Console.ReadLine());  // Lê a entrada do usuário, converte para inteiro e armazena na variável 'numero'

                if ((numero < 10) || (numero > 20))  // Verifica se o número digitado está fora do intervalo 10-20
                {
                    continue;  // Se o número estiver fora do intervalo, o laço volta ao início, pedindo novamente a entrada
                }
                else  // Se o número estiver dentro do intervalo 10-20
                {
                    Console.WriteLine("Número digitado: {0}", numero);  // Exibe o número que foi digitado
                }

                Console.WriteLine("Vamos ao próximo valor!");  // Exibe uma mensagem indicando que o próximo valor será solicitado
            }


        }
    }
}
