using System;

namespace Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] meuarray = { 2,4,6,8,10};
            foreach (int elemento in meuarray)
            {
                Console.WriteLine(elemento);
            }

           
        }
    }
}
