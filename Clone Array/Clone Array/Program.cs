using System;

namespace Clone_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 4, 7, 13, 19, 15 };

            // Clonando uma array:
            int[] copia = (int[])numeros.Clone(); // O método Clone retorna um object porque é definido na classe base Array, e para atribuí-lo a um array de int, é necessário fazer um casting(conversão) explícito para int[].

            for (int i = 0; i < copia.Length; i++)
            {
                Console.WriteLine(copia[i]);
            }
        }
    }
}
