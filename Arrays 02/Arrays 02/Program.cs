using System;

namespace Arrays_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* EXEMPLO 1
            int[] meuarray = { 2, 4, 6, 3, 5, 9 };
            for (int i = 0; i < meuarray.Length; i++) // Length - Obtém o total de elementos do array
            {
                Console.WriteLine(meuarray[i]);
            }
            */

            // Declarando um array de 5 posições
            int[] meuarray = new int[5];

            // Preenchendo o array
            for (int i = 0; i < meuarray.Length; i++)
            {
                // Pedindo ao usuário que informe os valores para serem armazenados em cada posição do array
                Console.WriteLine("Digite um número: ");
                meuarray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            // Mostrando os valores do array
            for (int i = 0; i < meuarray.Length; i++)
            {
                Console.WriteLine("Posição {0}: {1}", i, meuarray[i]);
            }
        }
    }
}
