﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Aritméticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20;
            int num2 = 11;

            Console.WriteLine("Soma: " + (num1 + num2));
            Console.WriteLine("Subtração: " + (num1 - num2));
            Console.WriteLine("Multiplicação: " + (num1 * num2));
            Console.WriteLine("Divisão: " + (num1 / num2));
            Console.WriteLine("Módulo: " + (num1 % num2));

            Console.ReadLine();

        }
    }
}
