using System;

namespace Loop_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* CONTANDO DE 1 A 50 E EXIBINDOS OS NÚMEROS DE 1 A 50
            int contador = 1;
            while (contador <= 50)
            {
                Console.WriteLine(contador);
                contador++;
            }
            */


            // LOOP PSEUDO-INFINITO- Criando um loop que continua solicitando ao usuário que digite uma letra até que ele digite a letra "a"
            
            string letra;
            Console.WriteLine("Digite uma letra; a para encerrar ");
            letra = Console.ReadLine();

            while (letra != "a")
            {
                Console.WriteLine("Digite uma letra: [a para encerrar!] ");
                letra = Console.ReadLine();
                Console.WriteLine(letra);                
            }
            Console.WriteLine("Fim do loop!");
        }
    }
}
