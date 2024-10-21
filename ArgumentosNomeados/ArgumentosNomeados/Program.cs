using System;

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
            
            paramOpcional(par2: parametro02, par1: parametro01); // Passamos o parâmetro02 antes de 

            Console.ReadLine();           
        }

        static void paramOpcional(int par1, string par2 = "Inserido pelo método")
        {
            string resultado = "Parâmetro obrigatório: " + par1.ToString() + " Parâmetro opcional: " + par2;
            Console.WriteLine(resultado);
        }
    }
}
