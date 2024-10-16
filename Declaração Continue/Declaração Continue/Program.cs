using System; // Importa o namespace System, que contém classes fundamentais

namespace Declaração_Continue // Define um namespace chamado Declaração_Continue
{
    internal class Program // Declara a classe Program
    {
        static void Main(string[] args) // Método principal do programa
        {
            int numero; // Declara uma variável do tipo inteiro chamada 'numero'
            while (true) // Inicia um loop infinito
            {
                Console.WriteLine("Digite um número: "); // Solicita que o usuário digite um número
                numero = int.Parse(Console.ReadLine()); // Lê a entrada do usuário e a converte para um inteiro

                if (numero < 10 || numero > 20) // Verifica se o número está fora do intervalo de 10 a 20
                {
                    continue; // Interrompe a iteração - Se o número estiver fora do intervalo, volta ao início do loop
                }
                else // Se o número estiver dentro do intervalo (10 a 20)
                {
                    if (numero == 15) // Verifica se o número é exatamente 15
                    {
                        break; // Interrompe o loop compeltamente - Se for 15, sai do loop
                    }
                    Console.WriteLine("Número: {0}", numero); // Exibe o número se estiver entre 10 e 20
                }
            }
            Console.WriteLine("Saindo!..."); // Mensagem que é exibida ao sair do loop
        }
    }
}
