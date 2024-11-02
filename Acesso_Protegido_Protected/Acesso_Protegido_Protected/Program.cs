using System;

namespace Acesso_Protegido_Protected
{
    internal class Program
    {
        // Método principal onde a execução do programa começa
        static void Main(string[] args)
        {
            // Cria uma instância da classe Automovel
            Automovel meucarro = new Automovel();

            // Chama o método DadosAutomovel para exibir a placa
            meucarro.DadosAutomovel();

            // Chama o método para mostrar o chassis do carro
            meucarro.MostraChassis();

            // Imprime o número de portas do carro
            Console.WriteLine(meucarro.portas.ToString());

            // Cria uma instância da classe Veiculo (não utilizada posteriormente)
            Veiculo veiculo = new Veiculo();
        }
    }


    // Classe Base: Veiculo
    class Veiculo
    {
        // Campo Protegido: acessível nas classes derivadas
        protected string _placa;

        // Campo Privado: acessível apenas dentro da própria classe Veiculo
        private string _chassis;

        // Campo Público: acessível de qualquer lugar
        public int portas;

        // Método Construtor da classe Veiculo
        public Veiculo()
        {
            // Inicializa os campos com valores padrão
            this._placa = "AAA-0000"; // A placa do veículo
            this._chassis = "00000000000000000"; // O chassis do veículo
            this.portas = 4; // Número de portas do veículo
        }

        // Método que exibe o chassis do veículo
        public void MostraChassis()
        {
            // O chassis é privado, então só pode ser acessado aqui
            Console.WriteLine("O chassis é {0}", this._chassis);
        }
    }

    // Classe Derivada: Automovel
    class Automovel : Veiculo
    {
        // Método que exibe informações do automóvel
        public void DadosAutomovel()
        {
            // Acessa o campo protegido _placa, que é visível aqui
            Console.WriteLine("A placa do auto é {0}", this._placa); // A placa é acessível, mas o chassis não é
        }
    }
}
