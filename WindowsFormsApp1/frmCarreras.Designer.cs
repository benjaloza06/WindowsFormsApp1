namespace WindowsFormsApp1
{
    partial class FrmCarreras
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
            this.LblCarreras = new System.Windows.Forms.Label();
            this.TxtCarreras = new System.Windows.Forms.TextBox();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.LstCarreras = new System.Windows.Forms.ListBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblCarreras
            // 
            this.LblCarreras.AutoSize = true;
            this.LblCarreras.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCarreras.Location = new System.Drawing.Point(26, 27);
            this.LblCarreras.Name = "LblCarreras";
            this.LblCarreras.Size = new System.Drawing.Size(56, 15);
            this.LblCarreras.TabIndex = 0;
            this.LblCarreras.Text = "Carreras:";
            // 
            // TxtCarreras
            // 
            this.TxtCarreras.Location = new System.Drawing.Point(133, 22);
            this.TxtCarreras.Name = "TxtCarreras";
            this.TxtCarreras.Size = new System.Drawing.Size(100, 20);
            this.TxtCarreras.TabIndex = 1;
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGrabar.Location = new System.Drawing.Point(133, 76);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(100, 24);
            this.BtnGrabar.TabIndex = 2;
            this.BtnGrabar.Text = "Grabar";
            this.BtnGrabar.UseVisualStyleBackColor = true;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // LstCarreras
            // 
            this.LstCarreras.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstCarreras.FormattingEnabled = true;
            this.LstCarreras.ItemHeight = 15;
            this.LstCarreras.Location = new System.Drawing.Point(29, 106);
            this.LstCarreras.Name = "LstCarreras";
            this.LstCarreras.Size = new System.Drawing.Size(204, 154);
            this.LstCarreras.TabIndex = 3;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(29, 76);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(84, 23);
            this.BtnLimpiar.TabIndex = 4;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            // 
            // frmCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(254, 272);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.LstCarreras);
            this.Controls.Add(this.BtnGrabar);
            this.Controls.Add(this.TxtCarreras);
            this.Controls.Add(this.LblCarreras);
            this.Name = "frmCarreras";
            this.Text = "frmCarreras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCarreras;
        private System.Windows.Forms.TextBox TxtCarreras;
        private System.Windows.Forms.Button BtnGrabar;
        private System.Windows.Forms.ListBox LstCarreras;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}