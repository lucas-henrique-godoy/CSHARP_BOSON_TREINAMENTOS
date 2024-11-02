using System;

namespace Acesso_Protegido_Protected
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Automovel meucarro = new Automovel();
            meucarro.DadosAutomovel();
            meucarro.MostraChassis();
            Console.WriteLine(meucarro.portas.ToString());

            Veiculo veiculo = new Veiculo();
            
        }
    }

    
    // Classe Base:
    class Veiculo
    {
        // Campo  Protegido
        protected string _placa;

        // Campo Privado:
        private string _chassis;

        // Campo Público:
        public int portas;

        // Método Construtor:
        public Veiculo()
        {
            this._placa = "AAA-0000";
            this._chassis = "00000000000000000";
            this.portas = 4;
        }

        public void MostraChassis()
        {
            // O chassis só é acessível de dentro da próprira classe.
            Console.WriteLine("O chassis é {0}", this._chassis);
        }
    }

    // Classe Derivada:
    class Automovel : Veiculo
    {
        public void DadosAutomovel()
        {
            Console.WriteLine("A placa do auto é {0}", this._placa); // A placa aparece no intellicense, mas o chassis não 
        }
    }

}
