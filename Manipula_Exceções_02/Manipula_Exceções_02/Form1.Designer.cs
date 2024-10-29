namespace Manipula_Exceções_02
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
            txtEntrada1 = new System.Windows.Forms.TextBox();
            txtEntrada2 = new System.Windows.Forms.TextBox();
            txtSaida = new System.Windows.Forms.TextBox();
            btnMultiplicar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtEntrada1
            // 
            txtEntrada1.Location = new System.Drawing.Point(309, 57);
            txtEntrada1.Name = "txtEntrada1";
            txtEntrada1.Size = new System.Drawing.Size(100, 23);
            txtEntrada1.TabIndex = 0;
            // 
            // txtEntrada2
            // 
            txtEntrada2.Location = new System.Drawing.Point(309, 118);
            txtEntrada2.Name = "txtEntrada2";
            txtEntrada2.Size = new System.Drawing.Size(100, 23);
            txtEntrada2.TabIndex = 1;
            // 
            // txtSaida
            // 
            txtSaida.Location = new System.Drawing.Point(309, 253);
            txtSaida.Name = "txtSaida";
            txtSaida.Size = new System.Drawing.Size(100, 23);
            txtSaida.TabIndex = 2;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new System.Drawing.Point(309, 179);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new System.Drawing.Size(100, 23);
            btnMultiplicar.TabIndex = 3;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnMultiplicar);
            Controls.Add(txtSaida);
            Controls.Add(txtEntrada2);
            Controls.Add(txtEntrada1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtEntrada1;
        private System.Windows.Forms.TextBox txtEntrada2;
        private System.Windows.Forms.TextBox txtSaida;
        private System.Windows.Forms.Button btnMultiplicar;
    }
}
