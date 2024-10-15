using System;

namespace Condicional_Aninhado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int diaSemana;
            string nome;            
            Console.WriteLine("Digite o dia da semana de 1 a 7: ");
            diaSemana = int.Parse(Console.ReadLine());

            if (diaSemana == 1)
            {
                nome = "Domingo";
                Console.WriteLine(nome);
            }
            else if (diaSemana == 2)
            {
                nome = "Segunda-feira";
                Console.WriteLine(nome);
            }
            else if (diaSemana == 3)
            {
                nome = "Terça-feira";
                Console.WriteLine(nome);
            }
            else if (diaSemana == 4)
            {
                nome = "Quarta-feira";
                Console.WriteLine(nome);
            }
            else if (diaSemana == 5)
            {
                nome = "Quinta-feira";
                Console.WriteLine(nome);
            }
            else if (diaSemana == 6)
            {
                nome = "Sexta-feira";
                Console.WriteLine(nome);
            }
            else if (diaSemana == 7)
            {
                nome = "Sábado";
                Console.WriteLine(nome);
            }
            else
            {
                Console.WriteLine("Dia inválido!");
            }
        }
    }
}
