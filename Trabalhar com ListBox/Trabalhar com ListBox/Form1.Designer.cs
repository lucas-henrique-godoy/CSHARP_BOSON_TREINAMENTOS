﻿namespace Trabalhar_com_ListBox
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
            btnAdicionaItens = new System.Windows.Forms.Button();
            txtItem = new System.Windows.Forms.TextBox();
            lstAnimais = new System.Windows.Forms.ListBox();
            btnMaisItem = new System.Windows.Forms.Button();
            btnRemoveItens = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnAdicionaItens
            // 
            btnAdicionaItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAdicionaItens.Location = new System.Drawing.Point(39, 151);
            btnAdicionaItens.Name = "btnAdicionaItens";
            btnAdicionaItens.Size = new System.Drawing.Size(176, 64);
            btnAdicionaItens.TabIndex = 0;
            btnAdicionaItens.Text = "Adicionar Itens";
            btnAdicionaItens.UseVisualStyleBackColor = true;
            btnAdicionaItens.Click += btnAdicionaItens_Click;
            // 
            // txtItem
            // 
            txtItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtItem.Location = new System.Drawing.Point(39, 82);
            txtItem.Name = "txtItem";
            txtItem.Size = new System.Drawing.Size(176, 29);
            txtItem.TabIndex = 1;
            // 
            // lstAnimais
            // 
            lstAnimais.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lstAnimais.FormattingEnabled = true;
            lstAnimais.ItemHeight = 24;
            lstAnimais.Location = new System.Drawing.Point(327, 82);
            lstAnimais.Name = "lstAnimais";
            lstAnimais.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            lstAnimais.Size = new System.Drawing.Size(120, 244);
            lstAnimais.TabIndex = 2;
            // 
            // btnMaisItem
            // 
            btnMaisItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnMaisItem.Location = new System.Drawing.Point(39, 251);
            btnMaisItem.Name = "btnMaisItem";
            btnMaisItem.Size = new System.Drawing.Size(176, 64);
            btnMaisItem.TabIndex = 3;
            btnMaisItem.Text = "Adicionar mais intens";
            btnMaisItem.UseVisualStyleBackColor = true;
            btnMaisItem.Click += btnMaisItem_Click;
            // 
            // btnRemoveItens
            // 
            btnRemoveItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRemoveItens.Location = new System.Drawing.Point(39, 358);
            btnRemoveItens.Name = "btnRemoveItens";
            btnRemoveItens.Size = new System.Drawing.Size(176, 64);
            btnRemoveItens.TabIndex = 4;
            btnRemoveItens.Text = "Remover Itens";
            btnRemoveItens.UseVisualStyleBackColor = true;
            btnRemoveItens.Click += btnRemoveItens_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(482, 490);
            Controls.Add(btnRemoveItens);
            Controls.Add(btnMaisItem);
            Controls.Add(lstAnimais);
            Controls.Add(txtItem);
            Controls.Add(btnAdicionaItens);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAdicionaItens;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.ListBox lstAnimais;
        private System.Windows.Forms.Button btnMaisItem;
        private System.Windows.Forms.Button btnRemoveItens;
    }
}