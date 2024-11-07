namespace ListBox_e_ComboBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstAnimais = new System.Windows.Forms.ListBox();
            btnAdiciona = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            btnPreenche = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            txtAdicionaItem = new System.Windows.Forms.TextBox();
            button3 = new System.Windows.Forms.Button();
            btnRemoveSelecionado = new System.Windows.Forms.Button();
            btnLerItemLista = new System.Windows.Forms.Button();
            btnClassifica = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lstAnimais
            // 
            lstAnimais.FormattingEnabled = true;
            lstAnimais.ItemHeight = 15;
            lstAnimais.Location = new System.Drawing.Point(373, 74);
            lstAnimais.Name = "lstAnimais";
            lstAnimais.Size = new System.Drawing.Size(177, 319);
            lstAnimais.TabIndex = 0;
            // 
            // btnAdiciona
            // 
            btnAdiciona.Location = new System.Drawing.Point(33, 147);
            btnAdiciona.Name = "btnAdiciona";
            btnAdiciona.Size = new System.Drawing.Size(129, 55);
            btnAdiciona.TabIndex = 1;
            btnAdiciona.Text = "Adicionar Item";
            btnAdiciona.UseVisualStyleBackColor = true;
            btnAdiciona.Click += btnAdiciona_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(197, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(353, 25);
            label1.TabIndex = 2;
            label1.Text = "Trabalhando com ListBox em C#";
            // 
            // btnPreenche
            // 
            btnPreenche.Location = new System.Drawing.Point(33, 226);
            btnPreenche.Name = "btnPreenche";
            btnPreenche.Size = new System.Drawing.Size(129, 67);
            btnPreenche.TabIndex = 3;
            btnPreenche.Text = "Preencher Lista Automaticamente";
            btnPreenche.UseVisualStyleBackColor = true;
            btnPreenche.Click += btnPreenche_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(12, 74);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(246, 16);
            label2.TabIndex = 4;
            label2.Text = "Digite um item para adicionar ao ListBox";
            // 
            // txtAdicionaItem
            // 
            txtAdicionaItem.Location = new System.Drawing.Point(33, 101);
            txtAdicionaItem.Multiline = true;
            txtAdicionaItem.Name = "txtAdicionaItem";
            txtAdicionaItem.Size = new System.Drawing.Size(200, 30);
            txtAdicionaItem.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(633, 74);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(97, 57);
            button3.TabIndex = 6;
            button3.Text = "Limpar Lista";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnRemoveSelecionado
            // 
            btnRemoveSelecionado.Location = new System.Drawing.Point(633, 160);
            btnRemoveSelecionado.Name = "btnRemoveSelecionado";
            btnRemoveSelecionado.Size = new System.Drawing.Size(97, 57);
            btnRemoveSelecionado.TabIndex = 7;
            btnRemoveSelecionado.Text = "Remover Selecionado";
            btnRemoveSelecionado.UseVisualStyleBackColor = true;
            btnRemoveSelecionado.Click += btnRemoveSelecionado_Click;
            // 
            // btnLerItemLista
            // 
            btnLerItemLista.Location = new System.Drawing.Point(633, 251);
            btnLerItemLista.Name = "btnLerItemLista";
            btnLerItemLista.Size = new System.Drawing.Size(97, 57);
            btnLerItemLista.TabIndex = 8;
            btnLerItemLista.Text = "Ler Item da Lista";
            btnLerItemLista.UseVisualStyleBackColor = true;
            btnLerItemLista.Click += btnLerItemLista_Click;
            // 
            // btnClassifica
            // 
            btnClassifica.Location = new System.Drawing.Point(633, 336);
            btnClassifica.Name = "btnClassifica";
            btnClassifica.Size = new System.Drawing.Size(97, 57);
            btnClassifica.TabIndex = 9;
            btnClassifica.Text = "Classificar Lista";
            btnClassifica.UseVisualStyleBackColor = true;
            btnClassifica.Click += btnClassifica_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(763, 437);
            Controls.Add(btnClassifica);
            Controls.Add(btnLerItemLista);
            Controls.Add(btnRemoveSelecionado);
            Controls.Add(button3);
            Controls.Add(txtAdicionaItem);
            Controls.Add(label2);
            Controls.Add(btnPreenche);
            Controls.Add(label1);
            Controls.Add(btnAdiciona);
            Controls.Add(lstAnimais);
            Name = "Form1";
            Text = "ListBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lstAnimais;
        private System.Windows.Forms.Button btnAdiciona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPreenche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdicionaItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnRemoveSelecionado;
        private System.Windows.Forms.Button btnLerItemLista;
        private System.Windows.Forms.Button btnClassifica;
    }
}
