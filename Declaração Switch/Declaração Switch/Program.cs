using System;

namespace Declaração_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int diaSemana;
            string nome;
            Console.WriteLine("Digite o dia da semana de 1 a 7: ");
            diaSemana = int.Parse(Console.ReadLine());
            /*
            switch (diaSemana)
            {
                case 1 :
                    nome = "Domingo";
                    break;
                case 2 :
                    nome = "Segunda-feira";
                    break;
                case 3 :
                    nome = "Terça-feira";
                    break;
                case 4 :
                    nome = "Quarta-feira";
                    break;
                case 5 :
                    nome = "Quinta-feira";
                    break;
                case 6 :
                    nome = "Sexta-feira";
                    break;
                case 7 :
                    nome = "Sábado";
                    break;
                default :
                    nome = "Dia Inválido!";
                    break;
            }
            Console.WriteLine("O dia escolhido foi: {0}", nome);
            */


            
            
            
            // Outro formato, usando um mesmo código para dois labels case diferentes - "Switch

            switch (diaSemana)
            {
                case 7: // mesmo código sendo executado para 2 labels case diferentes.
                case 1: // mesmo código sendo executado para 2 labels case diferentes.
                    nome = "Finalde Semana"; // Se forem escolhidos os valores 1 ou 7, será apresentado "Final de Semana" onde deveria estar Sábado e Domingo.
                    break;
                case 2:
                    nome = "Segunda-feira";
                    break;
                case 3:
                    nome = "Terça-feira";
                    break;
                case 4:
                    nome = "Quarta-feira";
                    break;
                case 5:
                    nome = "Quinta-feira";
                    break;
                case 6:
                    nome = "Sexta-feira";
                    break;
                default :
                    nome = "Dia Inválido";
                    break;
            }
            Console.WriteLine("O dia escolhido foi: {0}", nome);
            Console.ReadLine();
        }
    }
}


