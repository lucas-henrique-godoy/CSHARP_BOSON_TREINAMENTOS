using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores_de_Acesso
{
    internal class Animal
    {
        private int idade = 10;
        private double peso = 50.4;

        public int obterIdade()
        {
            return idade;
        }

        public double obterPeso
        {
            get { return peso; }
        }
    }
}
