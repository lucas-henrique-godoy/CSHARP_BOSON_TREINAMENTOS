using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Parte_01
{
    internal class Caixa
    {
        private double lado;

        public Caixa() /// Método construtor padrão (inicializa lado com 10)
        {
            lado = 10;
        }

        public Caixa(double qualquerLado) // Método construtor sobrecarregado (inicializa lado com o valor fornecido pelo usuário)
        {
            lado = qualquerLado;
        }

        public double Volume() // Calcula o volume da caixa (lado^3)
        {
            return lado * lado * lado;
        }

        public static int CaixaLdoDois() // Criei um méodo estático(não precisa instanciar)
        {
            int lat = 2;
            int vol = lat * lat * lat;
            return vol;
        }
    }
}
