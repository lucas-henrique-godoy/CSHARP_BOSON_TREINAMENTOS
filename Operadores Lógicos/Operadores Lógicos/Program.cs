using System;

namespace Operadores_Lógicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // AND
            int idade;
            bool idadeValida;
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            idadeValida = (idade > 0) && (idade <= 120); // Retorna true se a idade estiver entre 0 e 120 
            Console.WriteLine(idadeValida.ToString());
            

            //OR
            int temperatura;
            bool temperaturaInvalida;
            Console.WriteLine("Digite a Temperatura em graus Celsius para verificar se a água está nos estado sólido ou gasoso:  ");
            temperatura = int.Parse(Console.ReadLine());
            temperaturaInvalida = (temperatura < 0) || (temperatura > 100); //Verifica se a temperatura é inválida (água não está no estado líquido)
            Console.WriteLine(temperaturaInvalida.ToString());


            //NOT
            bool valorLogico;
            valorLogico = true; // Mude para false para ver o resultado
            valorLogico = !valorLogico; //Invertendo o valor lógico
            Console.WriteLine(valorLogico.ToString()); //Resultado impresso é inverso ao fornecido à variável
            

            Console.ReadLine();
        }
    }
}
