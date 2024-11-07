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
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
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
            // button1
            // 
            button1.Location = new System.Drawing.Point(55, 149);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(129, 55);
            button1.TabIndex = 1;
            button1.Text = "Adicionar Item";
            button1.UseVisualStyleBackColor = true;
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
            // button2
            // 
            button2.Location = new System.Drawing.Point(104, 283);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(129, 67);
            button2.TabIndex = 3;
            button2.Text = "Preencher Lista Automaticamente";
            button2.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(33, 101);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(200, 30);
            textBox1.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(633, 74);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(97, 57);
            button3.TabIndex = 6;
            button3.Text = "Limpar Lista";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(633, 160);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(97, 57);
            button4.TabIndex = 7;
            button4.Text = "Remover Selecionado";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(633, 251);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(97, 57);
            button5.TabIndex = 8;
            button5.Text = "Ler Item da Lista";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(633, 336);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(97, 57);
            button6.TabIndex = 9;
            button6.Text = "Classificar Lista";
            button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(763, 437);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(lstAnimais);
            Name = "Form1";
            Text = "ListBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lstAnimais;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}
