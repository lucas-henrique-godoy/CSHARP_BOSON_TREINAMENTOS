using System;

namespace Copy_To
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[] { 3,6,9,12,15 };
            int[] copiaNumeros = new int[numeros.Length];

            // Copiando os elementos com o método CpyTo
            numeros.CopyTo()
        }
    }
}
