using System;

namespace Arrays_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] meuarray = { 2, 4, 6, 3, 5, 9 };
            for (int i = 0; i < meuarray.Length; i++) // Length - Obtem total de elementos do array
            {
                Console.WriteLine(meuarray[i]);
            }

        }
    }
}
