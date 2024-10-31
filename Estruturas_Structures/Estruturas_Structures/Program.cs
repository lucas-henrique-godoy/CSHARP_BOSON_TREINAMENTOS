using System;

namespace Estruturas_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Horario agora; 
            agora.hora = 10;
            agora.minuto = 30;
            Console.WriteLine("Horário: {0}:{1}", agora.hora, agora.minuto);
        }

        struct Horario
        {
            public int hora, minuto, segundo;
        }

    }
}
