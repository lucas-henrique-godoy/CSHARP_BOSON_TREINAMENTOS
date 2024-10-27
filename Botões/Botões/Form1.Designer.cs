namespace Botões
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
            btnCliqueMe = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnCliqueMe
            // 
            btnCliqueMe.Location = new System.Drawing.Point(227, 75);
            btnCliqueMe.Name = "btnCliqueMe";
            btnCliqueMe.Size = new System.Drawing.Size(94, 52);
            btnCliqueMe.TabIndex = 0;
            btnCliqueMe.Text = "Clique Aqui";
            btnCliqueMe.UseVisualStyleBackColor = true;
            btnCliqueMe.Click += btnCliqueMe_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(541, 233);
            Controls.Add(btnCliqueMe);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnCliqueMe;
    }
}
