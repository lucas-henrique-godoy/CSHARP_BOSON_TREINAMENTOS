﻿using System;
using System.Collections.Generic;

namespace Listas_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> valores = new List<int>();

            valores.Add(16);// Add insere valores ao final da lista
            valores.Add(18);
            valores.Add(23);
            valores.Add(12);

            int[] numeros = new int[] { 32, 12, 7, 20 };
            valores.AddRange(numeros);// Adiconando outros elementos dentro da lista valores.

            //Console.WriteLine("A lista possui " + valores.Count + " elementos ");
            //Console.WriteLine("O primeiro item é " + valores[0]);

            
            
            foreach (int item in valores)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
}
