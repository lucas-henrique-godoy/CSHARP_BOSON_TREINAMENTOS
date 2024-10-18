using System;

namespace Copiando_E_Clonando_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 4,8,12,16,20 };
            int[] copiaNumeros = new int[numeros.Length];


            // copiando os elementos com o laço for:
            for (int i = 0; i < numeros.Length; i++)
            {
                copiaNumeros[i] = numeros[i];
            }

            for (int i = 0; i < copiaNumeros.Length; i++)
            {
                Console.WriteLine(copiaNumeros[i]);
            }
        }
    }
}
