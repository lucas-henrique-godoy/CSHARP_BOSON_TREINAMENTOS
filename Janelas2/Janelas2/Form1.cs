using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Janelas2
{
    public partial class Form1 : Form
    {
        Thread t1;
        
        
        public Form1()
        {
            InitializeComponent();
        }

        // Método que é executado quando o botão btnAbrir é clicado
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            // Fecha a janela atual (a janela que contém o botão)
            this.Close();

            // Cria um novo thread (linha de execução separada) para rodar o método abrirJanela
            t1 = new Thread(abrirJanela);

            // Define o estado do apartamento do thread para STA (Single-Threaded Apartment)
            // Isso é necessário quando você está lidando com componentes do Windows Forms que requerem uma única thread para interagir com a UI (por exemplo, abrir uma nova janela de forma independente)
            t1.SetApartmentState(ApartmentState.STA);

            // Inicia a execução do thread, que chamará o método abrirJanela
            t1.Start();            
        }

        // Método que será executado pelo novo thread
        private void abrirJanela(object obj)
        {
            // Abre uma nova janela, criando uma instância de 'NovaJanela' e iniciando o loop de mensagens dessa janela
            // Isso mantém a nova janela funcionando de forma independente da janela original
            Application.Run(new NovaJanela());
        }

    }
}
