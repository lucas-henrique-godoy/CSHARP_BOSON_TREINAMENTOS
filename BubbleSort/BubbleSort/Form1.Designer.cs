namespace BubbleSort
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
            btnCriaArray = new System.Windows.Forms.Button();
            btnOrdenaArray = new System.Windows.Forms.Button();
            btnMetodoSort = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnCriaArray
            // 
            btnCriaArray.Location = new System.Drawing.Point(68, 46);
            btnCriaArray.Name = "btnCriaArray";
            btnCriaArray.Size = new System.Drawing.Size(100, 59);
            btnCriaArray.TabIndex = 0;
            btnCriaArray.Text = "button1";
            btnCriaArray.UseVisualStyleBackColor = true;
            // 
            // btnOrdenaArray
            // 
            btnOrdenaArray.Location = new System.Drawing.Point(68, 149);
            btnOrdenaArray.Name = "btnOrdenaArray";
            btnOrdenaArray.Size = new System.Drawing.Size(100, 59);
            btnOrdenaArray.TabIndex = 1;
            btnOrdenaArray.Text = "button2";
            btnOrdenaArray.UseVisualStyleBackColor = true;
            // 
            // btnMetodoSort
            // 
            btnMetodoSort.Location = new System.Drawing.Point(68, 256);
            btnMetodoSort.Name = "btnMetodoSort";
            btnMetodoSort.Size = new System.Drawing.Size(100, 59);
            btnMetodoSort.TabIndex = 2;
            btnMetodoSort.Text = "button3";
            btnMetodoSort.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(343, 68);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(343, 171);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(343, 278);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(582, 68);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(38, 15);
            label4.TabIndex = 6;
            label4.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(664, 372);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMetodoSort);
            Controls.Add(btnOrdenaArray);
            Controls.Add(btnCriaArray);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCriaArray;
        private System.Windows.Forms.Button btnOrdenaArray;
        private System.Windows.Forms.Button btnMetodoSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
