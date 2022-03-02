
namespace Usuaris
{
    partial class FormInici
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInici));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripAdministrador = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRols = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUsuaris = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemSortir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAdministrador});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripAdministrador
            // 
            this.toolStripAdministrador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRols,
            this.menuItemUsuaris,
            this.toolStripMenuItem1,
            this.menuItemSortir});
            this.toolStripAdministrador.Name = "toolStripAdministrador";
            this.toolStripAdministrador.Size = new System.Drawing.Size(95, 20);
            this.toolStripAdministrador.Text = "Administrador";
            // 
            // menuItemRols
            // 
            this.menuItemRols.Name = "menuItemRols";
            this.menuItemRols.Size = new System.Drawing.Size(180, 22);
            this.menuItemRols.Text = "Rols";
            // 
            // menuItemUsuaris
            // 
            this.menuItemUsuaris.Name = "menuItemUsuaris";
            this.menuItemUsuaris.Size = new System.Drawing.Size(180, 22);
            this.menuItemUsuaris.Text = "Usuaris";
            this.menuItemUsuaris.Click += new System.EventHandler(this.menuItemUsuaris_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuItemSortir
            // 
            this.menuItemSortir.Image = ((System.Drawing.Image)(resources.GetObject("menuItemSortir.Image")));
            this.menuItemSortir.Name = "menuItemSortir";
            this.menuItemSortir.Size = new System.Drawing.Size(180, 22);
            this.menuItemSortir.Text = "Sortir";
            this.menuItemSortir.Click += new System.EventHandler(this.menuItemSortir_Click);
            // 
            // FormInici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormInici";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FormInici_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripAdministrador;
        private System.Windows.Forms.ToolStripMenuItem menuItemRols;
        private System.Windows.Forms.ToolStripMenuItem menuItemUsuaris;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuItemSortir;
    }
}