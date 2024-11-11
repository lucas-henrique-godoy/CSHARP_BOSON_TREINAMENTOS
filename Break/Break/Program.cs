using System;

namespace Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;  // Declara uma variável inteira chamada 'numero'

            while (true)  // Inicia um laço infinito, que continuará até ser interrompido por um comando 'break'
            {
                Console.WriteLine("Entre com um número; 15 para sair: ");  // Exibe uma mensagem pedindo para o usuário digitar um número
                numero = int.Parse(Console.ReadLine());  // Lê a entrada do usuário, converte de string para inteiro e armazena na variável 'numero'

                if (numero == 15)  // Verifica se o número digitado é 15
                {
                    break;  // Se o número for 15, sai do laço 'while' com o comando 'break'
                }
                else  // Se o número não for 15
                {
                    Console.WriteLine("Número digitado foi: {0}", numero);  // Exibe o número que o usuário digitou
                }
            }

            Console.WriteLine("Laço while foi encerrado! ");  // Após sair do laço, exibe uma mensagem indicando que o laço foi encerrado

        }
    }
}
