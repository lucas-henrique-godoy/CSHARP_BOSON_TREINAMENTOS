using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Modificador_Static
{
    internal class Animal
    {
        private int idade = 18;
        public double peso = 50.4;

        public int ObterIdade()
        {
            return idade;
        }

        public double ObterPeso
        {
            get { return peso;}
        }
    }
}
