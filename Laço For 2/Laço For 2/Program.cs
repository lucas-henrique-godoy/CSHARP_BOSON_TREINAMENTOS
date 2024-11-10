using System;

namespace Laço_For_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declara a variável inteira 'i' que será usada como contador no laço.
            int i;

            // Inicia um laço 'for' que vai se repetir enquanto 'i' for menor ou igual a 150.
            for (i = 0; i <= 150; i++) // 1ª parte: inicializa 'i' com 0, 2ª parte: a condição para o loop continuar, 3ª parte: incrementa 'i' a cada iteração.
            {
                // A cada iteração do laço, calcula o valor de '500 + i * 2' e exibe esse valor no console.
                Console.WriteLine(500 + i * 2);
                // '500 + i * 2' gera uma sequência de números, começando em 500 e aumentando de 2 em 2.
            }

        }
    }
}
