namespace WindowsFormsApp1
{
    partial class frmColores
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
            this.LblColores = new System.Windows.Forms.Label();
            this.TxtColores = new System.Windows.Forms.TextBox();
            this.BtnListar = new System.Windows.Forms.Button();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.LstColores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LblColores
            // 
            this.LblColores.AutoSize = true;
            this.LblColores.Location = new System.Drawing.Point(31, 31);
            this.LblColores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblColores.Name = "LblColores";
            this.LblColores.Size = new System.Drawing.Size(57, 16);
            this.LblColores.TabIndex = 0;
            this.LblColores.Text = "Colores:";
            // 
            // TxtColores
            // 
            this.TxtColores.Location = new System.Drawing.Point(135, 22);
            this.TxtColores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtColores.Name = "TxtColores";
            this.TxtColores.Size = new System.Drawing.Size(132, 22);
            this.TxtColores.TabIndex = 1;
            // 
            // BtnListar
            // 
            this.BtnListar.Location = new System.Drawing.Point(35, 73);
            this.BtnListar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(100, 28);
            this.BtnListar.TabIndex = 2;
            this.BtnListar.Text = "Listar";
            this.BtnListar.UseVisualStyleBackColor = true;
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.Location = new System.Drawing.Point(155, 73);
            this.BtnGrabar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(113, 28);
            this.BtnGrabar.TabIndex = 3;
            this.BtnGrabar.Text = "Grabar";
            this.BtnGrabar.UseVisualStyleBackColor = true;
            // 
            // LstColores
            // 
            this.LstColores.FormattingEnabled = true;
            this.LstColores.ItemHeight = 16;
            this.LstColores.Location = new System.Drawing.Point(35, 139);
            this.LstColores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LstColores.Name = "LstColores";
            this.LstColores.Size = new System.Drawing.Size(232, 180);
            this.LstColores.TabIndex = 4;
            // 
            // frmColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(304, 331);
            this.Controls.Add(this.LstColores);
            this.Controls.Add(this.BtnGrabar);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.TxtColores);
            this.Controls.Add(this.LblColores);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmColores";
            this.Text = "frmColores";
            this.Load += new System.EventHandler(this.FrmColores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblColores;
        private System.Windows.Forms.TextBox TxtColores;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button BtnGrabar;
        private System.Windows.Forms.ListBox LstColores;
    }
}