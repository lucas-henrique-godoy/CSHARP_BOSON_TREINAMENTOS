using System;
using System.Collections.Generic;

namespace Listas_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criação de uma lista de inteiros chamada 'valores'.
            List<int> valores = new List<int>();

            // Adicionando elementos individuais à lista 'valores' usando o método Add.
            valores.Add(16); // Adiciona o valor 16 no final da lista
            valores.Add(18); // Adiciona o valor 18 no final da lista
            valores.Add(23); // Adiciona o valor 23 no final da lista
            valores.Add(12); // Adiciona o valor 12 no final da lista

            // Criação de um array de inteiros 'numeros' com alguns valores.
            int[] numeros = new int[] { 32, 12, 7, 20 };

            // Usando o método AddRange para adicionar múltiplos elementos de um array à lista.
            valores.AddRange(numeros); // Adiciona todos os valores do array 'numeros' ao final da lista 'valores'

            // Abaixo estão alguns exemplos de operações que você pode realizar na lista. Estão comentadas para não executar durante o código.

            // Exemplo de como obter o número de elementos na lista e acessar o primeiro elemento.
            // Console.WriteLine("A lista possui " + valores.Count + " elementos ");
            // Console.WriteLine("O primeiro item é " + valores[0]);

            // Inserindo um novo valor na lista em uma posição específica (índice 1).
            valores.Insert(1, 13); // Insere o valor 13 no índice 1, deslocando os outros elementos.

            // Removendo a primeira ocorrência do valor 12 da lista.
            valores.Remove(12); // Remove a primeira ocorrência do valor 12

            // Removendo o elemento que está na posição de índice 2.
            valores.RemoveAt(2); // Remove o item que está no índice 2 (na nossa lista atual)

            // Ordenando os elementos da lista em ordem crescente.
            valores.Sort(); // Organiza a lista em ordem crescente.

            // Procurando um valor específico (16) na lista.
            int valorProcurado = 16;
            bool valorExiste;

            // Usando o método Contains para verificar se o valor procurado existe na lista.
            valorExiste = valores.Contains(valorProcurado); // Retorna 'true' se o valor existe, 'false' caso contrário.

            // Exibindo mensagem dependendo se o valor foi encontrado ou não.
            if (valorExiste)
            {
                Console.WriteLine("Valor encontrado!"); // Exibe se o valor foi encontrado na lista.
            }
            else
            {
                Console.WriteLine("Valor não encontrado!"); // Exibe se o valor não foi encontrado na lista.
            }

            // Usando o loop foreach para percorrer e imprimir todos os valores da lista.
            foreach (int item in valores)
            {
                Console.WriteLine(item.ToString()); // Converte cada item da lista em string e imprime na tela.
            }

            // Aguarda o usuário pressionar Enter para fechar o programa.
            Console.ReadLine();
        }
    }
}
