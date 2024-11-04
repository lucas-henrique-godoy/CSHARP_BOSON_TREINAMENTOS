namespace Controle_ColorDialog
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
            btnCorFundo = new System.Windows.Forms.Button();
            btnCorTexto = new System.Windows.Forms.Button();
            txtCores = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btnCorFundo
            // 
            btnCorFundo.Location = new System.Drawing.Point(62, 62);
            btnCorFundo.Name = "btnCorFundo";
            btnCorFundo.Size = new System.Drawing.Size(114, 63);
            btnCorFundo.TabIndex = 0;
            btnCorFundo.Text = "Cor de Fundo";
            btnCorFundo.UseVisualStyleBackColor = true;
            // 
            // btnCorTexto
            // 
            btnCorTexto.Location = new System.Drawing.Point(62, 177);
            btnCorTexto.Name = "btnCorTexto";
            btnCorTexto.Size = new System.Drawing.Size(114, 63);
            btnCorTexto.TabIndex = 1;
            btnCorTexto.Text = "Cor do Texto";
            btnCorTexto.UseVisualStyleBackColor = true;
            // 
            // txtCores
            // 
            txtCores.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCores.Location = new System.Drawing.Point(219, 142);
            txtCores.Name = "txtCores";
            txtCores.Size = new System.Drawing.Size(364, 39);
            txtCores.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(txtCores);
            Controls.Add(btnCorTexto);
            Controls.Add(btnCorFundo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCorFundo;
        private System.Windows.Forms.Button btnCorTexto;
        private System.Windows.Forms.TextBox txtCores;
    }
}
