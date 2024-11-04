namespace NumAleat_Teste
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
            btnGeraNumero = new System.Windows.Forms.Button();
            lblNumeroIntGerado = new System.Windows.Forms.Label();
            lblNumeroDoubleGerado = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnGeraNumero
            // 
            btnGeraNumero.Location = new System.Drawing.Point(44, 59);
            btnGeraNumero.Name = "btnGeraNumero";
            btnGeraNumero.Size = new System.Drawing.Size(140, 82);
            btnGeraNumero.TabIndex = 0;
            btnGeraNumero.Text = "Gerar Número";
            btnGeraNumero.UseVisualStyleBackColor = true;
            btnGeraNumero.Click += btnGeraNumero_Click;
            // 
            // lblNumeroIntGerado
            // 
            lblNumeroIntGerado.AutoSize = true;
            lblNumeroIntGerado.Location = new System.Drawing.Point(391, 59);
            lblNumeroIntGerado.Name = "lblNumeroIntGerado";
            lblNumeroIntGerado.Size = new System.Drawing.Size(38, 15);
            lblNumeroIntGerado.TabIndex = 1;
            lblNumeroIntGerado.Text = "label1";
            // 
            // lblNumeroDoubleGerado
            // 
            lblNumeroDoubleGerado.AutoSize = true;
            lblNumeroDoubleGerado.Location = new System.Drawing.Point(391, 126);
            lblNumeroDoubleGerado.Name = "lblNumeroDoubleGerado";
            lblNumeroDoubleGerado.Size = new System.Drawing.Size(38, 15);
            lblNumeroDoubleGerado.TabIndex = 2;
            lblNumeroDoubleGerado.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(lblNumeroDoubleGerado);
            Controls.Add(lblNumeroIntGerado);
            Controls.Add(btnGeraNumero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnGeraNumero;
        private System.Windows.Forms.Label lblNumeroIntGerado;
        private System.Windows.Forms.Label lblNumeroDoubleGerado;
    }
}
