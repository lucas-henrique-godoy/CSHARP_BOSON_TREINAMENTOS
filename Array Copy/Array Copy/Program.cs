using System;

namespace Array_Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[] { 3, 6, 9, 12, 15 };
            int[] copia = new int[numeros.Length];

            // Copiando os elementos com a classe Array, método Copy:
            Array.Copy(numeros, copia, copia.Length);

            for (int i = 0; i < copia.Length; i++)
            {
                Console.WriteLine(copia[i]);
            }
        }
    }
}
