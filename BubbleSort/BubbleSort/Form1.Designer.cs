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
            lblArrayOriginal = new System.Windows.Forms.Label();
            lblOrdenado = new System.Windows.Forms.Label();
            lblArraySort = new System.Windows.Forms.Label();
            lblArrayOriginal2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnCriaArray
            // 
            btnCriaArray.Location = new System.Drawing.Point(68, 46);
            btnCriaArray.Name = "btnCriaArray";
            btnCriaArray.Size = new System.Drawing.Size(126, 66);
            btnCriaArray.TabIndex = 0;
            btnCriaArray.Text = "Criar Array";
            btnCriaArray.UseVisualStyleBackColor = true;
            btnCriaArray.Click += btnCriaArray_Click;
            // 
            // btnOrdenaArray
            // 
            btnOrdenaArray.Location = new System.Drawing.Point(68, 149);
            btnOrdenaArray.Name = "btnOrdenaArray";
            btnOrdenaArray.Size = new System.Drawing.Size(126, 62);
            btnOrdenaArray.TabIndex = 1;
            btnOrdenaArray.Text = "Ordenar Array";
            btnOrdenaArray.UseVisualStyleBackColor = true;
            btnOrdenaArray.Click += btnOrdenaArray_Click;
            // 
            // btnMetodoSort
            // 
            btnMetodoSort.Location = new System.Drawing.Point(68, 256);
            btnMetodoSort.Name = "btnMetodoSort";
            btnMetodoSort.Size = new System.Drawing.Size(126, 55);
            btnMetodoSort.TabIndex = 2;
            btnMetodoSort.Text = "Ordena Método Sort";
            btnMetodoSort.UseVisualStyleBackColor = true;
            btnMetodoSort.Click += btnMetodoSort_Click;
            // 
            // lblArrayOriginal
            // 
            lblArrayOriginal.AutoSize = true;
            lblArrayOriginal.Location = new System.Drawing.Point(343, 68);
            lblArrayOriginal.Name = "lblArrayOriginal";
            lblArrayOriginal.Size = new System.Drawing.Size(124, 15);
            lblArrayOriginal.TabIndex = 3;
            lblArrayOriginal.Text = "Array 1, não ordenado";
            // 
            // lblOrdenado
            // 
            lblOrdenado.AutoSize = true;
            lblOrdenado.Location = new System.Drawing.Point(343, 171);
            lblOrdenado.Name = "lblOrdenado";
            lblOrdenado.Size = new System.Drawing.Size(124, 15);
            lblOrdenado.TabIndex = 4;
            lblOrdenado.Text = "Array 1 ordenado aqui";
            // 
            // lblArraySort
            // 
            lblArraySort.AutoSize = true;
            lblArraySort.Location = new System.Drawing.Point(343, 278);
            lblArraySort.Name = "lblArraySort";
            lblArraySort.Size = new System.Drawing.Size(124, 15);
            lblArraySort.TabIndex = 5;
            lblArraySort.Text = "Array 2 ordenado aqui";
            // 
            // lblArrayOriginal2
            // 
            lblArrayOriginal2.AutoSize = true;
            lblArrayOriginal2.Location = new System.Drawing.Point(567, 68);
            lblArrayOriginal2.Name = "lblArrayOriginal2";
            lblArrayOriginal2.Size = new System.Drawing.Size(124, 15);
            lblArrayOriginal2.TabIndex = 6;
            lblArrayOriginal2.Text = "Array 2, não ordenado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(776, 379);
            Controls.Add(lblArrayOriginal2);
            Controls.Add(lblArraySort);
            Controls.Add(lblOrdenado);
            Controls.Add(lblArrayOriginal);
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
        private System.Windows.Forms.Label lblArrayOriginal;
        private System.Windows.Forms.Label lblOrdenado;
        private System.Windows.Forms.Label lblArraySort;
        private System.Windows.Forms.Label lblArrayOriginal2;
    }
}
