namespace Teste_Arduino
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
            btnLigaLed = new System.Windows.Forms.Button();
            btnDesligaLed = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnLigaLed
            // 
            btnLigaLed.Location = new System.Drawing.Point(176, 141);
            btnLigaLed.Name = "btnLigaLed";
            btnLigaLed.Size = new System.Drawing.Size(132, 79);
            btnLigaLed.TabIndex = 0;
            btnLigaLed.Text = "Acende LED";
            btnLigaLed.UseVisualStyleBackColor = true;
            // 
            // btnDesligaLed
            // 
            btnDesligaLed.Location = new System.Drawing.Point(478, 141);
            btnDesligaLed.Name = "btnDesligaLed";
            btnDesligaLed.Size = new System.Drawing.Size(132, 79);
            btnDesligaLed.TabIndex = 1;
            btnDesligaLed.Text = "Apaga LED";
            btnDesligaLed.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(34, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(741, 29);
            label1.TabIndex = 2;
            label1.Text = "Clique nos botões abaixo para acender ou apagar o LED no Arduino";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnDesligaLed);
            Controls.Add(btnLigaLed);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnLigaLed;
        private System.Windows.Forms.Button btnDesligaLed;
        private System.Windows.Forms.Label label1;
    }
}
