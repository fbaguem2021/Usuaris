
namespace Usuaris
{
    partial class FormUsuaris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuaris));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.dgUsuaris = new System.Windows.Forms.DataGridView();
            this.msiAfegir = new System.Windows.Forms.ToolStripMenuItem();
            this.msiEsboorrar = new System.Windows.Forms.ToolStripMenuItem();
            this.msiSortir = new System.Windows.Forms.ToolStripMenuItem();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCorreu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCognoms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnActiu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuaris)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiAfegir,
            this.msiEsboorrar,
            this.msiSortir});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // dgUsuaris
            // 
            this.dgUsuaris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuaris.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnCorreu,
            this.ColumnNom,
            this.ColumnCognoms,
            this.ColumnActiu,
            this.ColumnRol});
            this.dgUsuaris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgUsuaris.Location = new System.Drawing.Point(0, 24);
            this.dgUsuaris.Name = "dgUsuaris";
            this.dgUsuaris.Size = new System.Drawing.Size(800, 426);
            this.dgUsuaris.TabIndex = 1;
            // 
            // msiAfegir
            // 
            this.msiAfegir.Image = ((System.Drawing.Image)(resources.GetObject("msiAfegir.Image")));
            this.msiAfegir.Name = "msiAfegir";
            this.msiAfegir.Size = new System.Drawing.Size(67, 20);
            this.msiAfegir.Text = "Afegir";
            this.msiAfegir.Click += new System.EventHandler(this.msiAfegir_Click);
            // 
            // msiEsboorrar
            // 
            this.msiEsboorrar.Image = ((System.Drawing.Image)(resources.GetObject("msiEsboorrar.Image")));
            this.msiEsboorrar.Name = "msiEsboorrar";
            this.msiEsboorrar.Size = new System.Drawing.Size(78, 20);
            this.msiEsboorrar.Text = "Esborrar";
            this.msiEsboorrar.Click += new System.EventHandler(this.msiEsboorrar_Click);
            // 
            // msiSortir
            // 
            this.msiSortir.Image = ((System.Drawing.Image)(resources.GetObject("msiSortir.Image")));
            this.msiSortir.Name = "msiSortir";
            this.msiSortir.Size = new System.Drawing.Size(63, 20);
            this.msiSortir.Text = "Sortir";
            this.msiSortir.Click += new System.EventHandler(this.msiSortir_Click);
            // 
            // ColumnId
            // 
            this.ColumnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnId.DataPropertyName = "id";
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Visible = false;
            // 
            // ColumnCorreu
            // 
            this.ColumnCorreu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCorreu.DataPropertyName = "correu";
            this.ColumnCorreu.HeaderText = "Correu";
            this.ColumnCorreu.Name = "ColumnCorreu";
            // 
            // ColumnNom
            // 
            this.ColumnNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNom.DataPropertyName = "nom";
            this.ColumnNom.HeaderText = "Nom";
            this.ColumnNom.Name = "ColumnNom";
            // 
            // ColumnCognoms
            // 
            this.ColumnCognoms.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCognoms.DataPropertyName = "cognoms";
            this.ColumnCognoms.HeaderText = "Cognoms";
            this.ColumnCognoms.Name = "ColumnCognoms";
            // 
            // ColumnActiu
            // 
            this.ColumnActiu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnActiu.DataPropertyName = "actiu";
            this.ColumnActiu.HeaderText = "Actiu";
            this.ColumnActiu.Name = "ColumnActiu";
            // 
            // ColumnRol
            // 
            this.ColumnRol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnRol.DataPropertyName = "rol";
            this.ColumnRol.HeaderText = "Rol";
            this.ColumnRol.Name = "ColumnRol";
            // 
            // FormUsuaris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgUsuaris);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormUsuaris";
            this.Text = "Usuaris";
            this.Load += new System.EventHandler(this.FormUsuaris_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuaris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.DataGridView dgUsuaris;
        private System.Windows.Forms.ToolStripMenuItem msiAfegir;
        private System.Windows.Forms.ToolStripMenuItem msiEsboorrar;
        private System.Windows.Forms.ToolStripMenuItem msiSortir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCorreu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCognoms;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActiu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRol;
    }
}