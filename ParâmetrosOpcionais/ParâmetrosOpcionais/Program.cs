using System;

namespace ParâmetrosOpcionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int parametro01;
            string parametro02;

            Console.WriteLine("Sem passar o parâmetro opcional: ");
            Console.WriteLine("Digite o parâmetro obrigatório (número): ");
            parametro01 = int.Parse(Console.ReadLine());
            paramOpcional(parametro01);

            Console.WriteLine();


            Console.WriteLine("Passando o parâmetro opcional: ");
            Console.WriteLine("Digite o parâmetro obrigatório (número): ");
            parametro01 = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora digite o parâmetro opcional: (texto) ");
            parametro02 = Console.ReadLine();
            paramOpcional(parametro01, parametro02);

            Console.ReadLine();
        }

        static void paramOpcional(int par1, string par2 = "Inserido pelo método")
        {
            string resultado = "Parâmetro obrigatório: " + par1.ToString() + " Parâmetro opcional: " + par2;
            Console.WriteLine(resultado);
        }
    }
}
