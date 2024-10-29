namespace Manipula_Exceções_01
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
            btnMultiplicar = new System.Windows.Forms.Button();
            txtSaida = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtEntrada1
            // 
            txtEntrada1.Location = new System.Drawing.Point(134, 78);
            txtEntrada1.Multiline = true;
            txtEntrada1.Name = "txtEntrada1";
            txtEntrada1.Size = new System.Drawing.Size(147, 33);
            txtEntrada1.TabIndex = 0;
            txtEntrada1.TextChanged += txtEntrada1_TextChanged;
            // 
            // txtEntrada2
            // 
            txtEntrada2.Location = new System.Drawing.Point(134, 137);
            txtEntrada2.Multiline = true;
            txtEntrada2.Name = "txtEntrada2";
            txtEntrada2.Size = new System.Drawing.Size(147, 33);
            txtEntrada2.TabIndex = 1;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.BackColor = System.Drawing.Color.Black;
            btnMultiplicar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnMultiplicar.ForeColor = System.Drawing.Color.White;
            btnMultiplicar.Location = new System.Drawing.Point(151, 199);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new System.Drawing.Size(105, 50);
            btnMultiplicar.TabIndex = 2;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = false;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // txtSaida
            // 
            txtSaida.Location = new System.Drawing.Point(134, 281);
            txtSaida.Multiline = true;
            txtSaida.Name = "txtSaida";
            txtSaida.Size = new System.Drawing.Size(147, 33);
            txtSaida.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtEntrada1);
            groupBox1.Controls.Add(txtSaida);
            groupBox1.Controls.Add(txtEntrada2);
            groupBox1.Controls.Add(btnMultiplicar);
            groupBox1.Location = new System.Drawing.Point(158, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(407, 343);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.Desktop;
            label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(125, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(167, 37);
            label1.TabIndex = 4;
            label1.Text = "Multiplicador";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            ClientSize = new System.Drawing.Size(707, 486);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox txtEntrada1;
        private System.Windows.Forms.TextBox txtEntrada2;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.TextBox txtSaida;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}
