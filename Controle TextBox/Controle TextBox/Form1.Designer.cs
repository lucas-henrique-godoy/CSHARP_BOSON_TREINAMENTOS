namespace Controle_TextBox
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
            txtEntrada = new System.Windows.Forms.TextBox();
            btnTeste = new System.Windows.Forms.Button();
            txtSaida = new System.Windows.Forms.TextBox();
            btnColar = new System.Windows.Forms.Button();
            btnOculta = new System.Windows.Forms.Button();
            btnMostrar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtEntrada
            // 
            txtEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            txtEntrada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtEntrada.ForeColor = System.Drawing.Color.Red;
            txtEntrada.Location = new System.Drawing.Point(43, 23);
            txtEntrada.MaxLength = 10;
            txtEntrada.Multiline = true;
            txtEntrada.Name = "txtEntrada";
            txtEntrada.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtEntrada.Size = new System.Drawing.Size(177, 56);
            txtEntrada.TabIndex = 0;
            txtEntrada.Click += txtEntrada_Click;
            txtEntrada.TextChanged += txtEntrada_TextChanged;
            txtEntrada.MouseHover += txtEntrada_MouseHover;
            // 
            // btnTeste
            // 
            btnTeste.Location = new System.Drawing.Point(267, 23);
            btnTeste.Name = "btnTeste";
            btnTeste.Size = new System.Drawing.Size(95, 56);
            btnTeste.TabIndex = 1;
            btnTeste.Text = "Clique Aqui";
            btnTeste.UseVisualStyleBackColor = true;
            btnTeste.Click += btnTeste_Click;
            // 
            // txtSaida
            // 
            txtSaida.Location = new System.Drawing.Point(43, 118);
            txtSaida.Multiline = true;
            txtSaida.Name = "txtSaida";
            txtSaida.Size = new System.Drawing.Size(177, 58);
            txtSaida.TabIndex = 2;
            // 
            // btnColar
            // 
            btnColar.Location = new System.Drawing.Point(267, 120);
            btnColar.Name = "btnColar";
            btnColar.Size = new System.Drawing.Size(95, 56);
            btnColar.TabIndex = 3;
            btnColar.Text = "Colar";
            btnColar.UseVisualStyleBackColor = true;
            btnColar.Click += btnColar_Click;
            // 
            // btnOculta
            // 
            btnOculta.Location = new System.Drawing.Point(404, 23);
            btnOculta.Name = "btnOculta";
            btnOculta.Size = new System.Drawing.Size(95, 56);
            btnOculta.TabIndex = 4;
            btnOculta.Text = "Ocultar";
            btnOculta.UseVisualStyleBackColor = true;
            btnOculta.Click += btnOculta_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new System.Drawing.Point(404, 118);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new System.Drawing.Size(95, 56);
            btnMostrar.TabIndex = 5;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(613, 213);
            Controls.Add(btnMostrar);
            Controls.Add(btnOculta);
            Controls.Add(btnColar);
            Controls.Add(txtSaida);
            Controls.Add(btnTeste);
            Controls.Add(txtEntrada);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.TextBox txtSaida;
        private System.Windows.Forms.Button btnColar;
        private System.Windows.Forms.Button btnOculta;
        private System.Windows.Forms.Button btnMostrar;
    }
}
