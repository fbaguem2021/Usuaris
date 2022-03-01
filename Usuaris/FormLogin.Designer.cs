
namespace Usuaris
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_correu = new System.Windows.Forms.TextBox();
            this.textBox_contrasenya = new System.Windows.Forms.TextBox();
            this.button_acceptar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contrasenya";
            // 
            // textBox_correu
            // 
            this.textBox_correu.Location = new System.Drawing.Point(129, 12);
            this.textBox_correu.Name = "textBox_correu";
            this.textBox_correu.Size = new System.Drawing.Size(349, 20);
            this.textBox_correu.TabIndex = 2;
            // 
            // textBox_contrasenya
            // 
            this.textBox_contrasenya.Location = new System.Drawing.Point(129, 38);
            this.textBox_contrasenya.Name = "textBox_contrasenya";
            this.textBox_contrasenya.Size = new System.Drawing.Size(349, 20);
            this.textBox_contrasenya.TabIndex = 3;
            // 
            // button_acceptar
            // 
            this.button_acceptar.Location = new System.Drawing.Point(403, 64);
            this.button_acceptar.Name = "button_acceptar";
            this.button_acceptar.Size = new System.Drawing.Size(75, 23);
            this.button_acceptar.TabIndex = 4;
            this.button_acceptar.Text = "Acceptar";
            this.button_acceptar.UseVisualStyleBackColor = true;
            this.button_acceptar.Click += new System.EventHandler(this.button_acceptar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(322, 64);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 5;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 92);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_acceptar);
            this.Controls.Add(this.textBox_contrasenya);
            this.Controls.Add(this.textBox_correu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_correu;
        private System.Windows.Forms.TextBox textBox_contrasenya;
        private System.Windows.Forms.Button button_acceptar;
        private System.Windows.Forms.Button button_cancelar;
    }
}

