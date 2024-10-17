using System;

namespace Arrays_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros_loteria = new int[6] { 2,23,34,12,29,44 }; // Declaração e instanciação do array.           
            int valor;
            valor = 40;
            numeros_loteria[4] = valor;
            Console.WriteLine("O elemento é {0}", numeros_loteria[4].ToString());
            
        }
    }
}
