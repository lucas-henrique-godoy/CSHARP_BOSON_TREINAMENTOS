using System; // Importa o namespace System, que contém classes fundamentais.
using System.Collections.Generic; // Importa classes que fornecem funcionalidades de coleções.
using System.Linq; // Importa classes que facilitam consultas em coleções.
using System.Security.Cryptography; // Importa classes para criptografia.
using System.Text; // Importa classes para manipulação de strings.
using System.Threading.Tasks; // Importa classes para programação assíncrona.

namespace Campos_Compartilhados_em_Classes // Define um namespace para organizar o código.
{
    internal class Acumula // Declara a classe 'Acumula' como interna, visível apenas dentro do assembly.
    {
        public static int soma; // Declara um campo estático 'soma', que é compartilhado entre todas as instâncias da classe.

        // Construtor da classe Acumula
        public Acumula()
        {
            soma = 0; // Inicializa 'soma' com 0 quando uma nova instância é criada.
        }

        // Método que incrementa 'soma' em 1.
        public void incrementa()
        {
            soma++; // Incrementa o valor de 'soma' em 1.
        }

        // Sobrecarga do método 'incrementa' que aceita um parâmetro inteiro.
        public void incrementa(int valor)
        {
            soma += valor; // Adiciona o valor fornecido ao campo 'soma'.
        }
    }
}
