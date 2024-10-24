﻿using System;

namespace ArgumentosNomeados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int parametro01;
            string parametro02;

            Console.WriteLine("Digite o parâmetro número 02: (texto) ");
            parametro02 = Console.ReadLine();
            Console.WriteLine("Digite o parâmetro número 01: (número) ");
            parametro01 = int.Parse(Console.ReadLine());
            
            paramOpcional(par2: parametro02, par1: parametro01); // Passamos o parâmetro02 antes de parâmetro01 

            Console.ReadLine();           
        }

        static void paramOpcional(int par1, string par2 = "Inserido pelo método")
        {
            string resultado = "Parâmetro 01: " + par1.ToString() + " Parâmetro 02: " + par2;
            Console.WriteLine(resultado);
        }
    }
}
