namespace WindowsFormsApp1
{
    partial class FrmMeses
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
            this.LblMeses = new System.Windows.Forms.Label();
            this.TxtMeses = new System.Windows.Forms.TextBox();
            this.BtnListar = new System.Windows.Forms.Button();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.LstMeses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LblMeses
            // 
            this.LblMeses.AutoSize = true;
            this.LblMeses.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMeses.Location = new System.Drawing.Point(23, 36);
            this.LblMeses.Name = "LblMeses";
            this.LblMeses.Size = new System.Drawing.Size(45, 15);
            this.LblMeses.TabIndex = 0;
            this.LblMeses.Text = "Meses:";
            // 
            // TxtMeses
            // 
            this.TxtMeses.Location = new System.Drawing.Point(134, 31);
            this.TxtMeses.Name = "TxtMeses";
            this.TxtMeses.Size = new System.Drawing.Size(105, 20);
            this.TxtMeses.TabIndex = 1;
            // 
            // BtnListar
            // 
            this.BtnListar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListar.Location = new System.Drawing.Point(26, 85);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(103, 23);
            this.BtnListar.TabIndex = 2;
            this.BtnListar.Text = "Listar";
            this.BtnListar.UseVisualStyleBackColor = true;
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGrabar.Location = new System.Drawing.Point(135, 85);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(104, 23);
            this.BtnGrabar.TabIndex = 3;
            this.BtnGrabar.Text = "Grabar";
            this.BtnGrabar.UseVisualStyleBackColor = true;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click_1);
            // 
            // LstMeses
            // 
            this.LstMeses.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstMeses.FormattingEnabled = true;
            this.LstMeses.ItemHeight = 15;
            this.LstMeses.Location = new System.Drawing.Point(26, 130);
            this.LstMeses.Name = "LstMeses";
            this.LstMeses.Size = new System.Drawing.Size(213, 124);
            this.LstMeses.TabIndex = 4;
            // 
            // FrmMeses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(257, 285);
            this.Controls.Add(this.LstMeses);
            this.Controls.Add(this.BtnGrabar);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.TxtMeses);
            this.Controls.Add(this.LblMeses);
            this.Name = "FrmMeses";
            this.Text = "FrmMeses";
            this.Load += new System.EventHandler(this.FrmMeses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMeses;
        private System.Windows.Forms.TextBox TxtMeses;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button BtnGrabar;
        private System.Windows.Forms.ListBox LstMeses;
    }
}