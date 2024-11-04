namespace Projeto_Menus
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            item1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            item2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            item3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            item1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { arquivoToolStripMenuItem, ajudaToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(584, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { item1ToolStripMenuItem, item2ToolStripMenuItem, item3ToolStripMenuItem, toolStripSeparator1, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // item1ToolStripMenuItem
            // 
            item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
            item1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            item1ToolStripMenuItem.Text = "Item 1";
            // 
            // item2ToolStripMenuItem
            // 
            item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
            item2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            item2ToolStripMenuItem.Text = "Item 2";
            // 
            // item3ToolStripMenuItem
            // 
            item3ToolStripMenuItem.Name = "item3ToolStripMenuItem";
            item3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            item3ToolStripMenuItem.Text = "Item 3";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { item1ToolStripMenuItem1, sobreToolStripMenuItem });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // item1ToolStripMenuItem1
            // 
            item1ToolStripMenuItem1.Name = "item1ToolStripMenuItem1";
            item1ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            item1ToolStripMenuItem1.Text = "Item 1";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(584, 348);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}
