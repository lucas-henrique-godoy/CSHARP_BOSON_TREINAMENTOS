using System;

namespace Estruturas_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* PRIMEIRO EXEMPLO
            Horario agora; 
            agora.hora = 10;
            agora.minuto = 30;
            Console.WriteLine("Horário: {0}:{1}", agora.hora, agora.minuto);
            */

            // SEGUNDO EXEMPLO
            Horario agora = new Horario(11, 25, 00);
            Console.WriteLine("Agora são: {0} horas", agora.Hora());

            //______________________________________________________________________________________________________________

            // Atribuindo uma nova instância da estrutura 'Horario' com os mesmos valores da instância 'agora'
            // Isso copia os valores de hora, minuto e segundo para a nova variável 'copia'
            Horario copia = agora;
            Console.WriteLine("Agora são: {0} horas", copia.Hora());
        }

        /* PRIMEIRO EXEMPLO
        struct Horario
        {
            public int hora, minuto, segundo;
        }
        */

        //____________________________________________________________________

        // SEGUNDO EXEMPLO
        struct Horario
        {
            private int hora, minuto, segundo;
            public Horario(int h, int m, int s)
            {
                this.hora = h % 24;
                this.minuto = m % 60;
                this.segundo = s % 60;
            }

            public int Hora()
            {
                return this.hora;                
            }
            
        }

    }
}
