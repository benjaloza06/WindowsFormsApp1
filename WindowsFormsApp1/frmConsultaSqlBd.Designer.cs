namespace WindowsFormsApp1
{
    partial class frmConsultaSqlBd
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
            this.LblConsulta = new System.Windows.Forms.Label();
            this.TxtConsulta = new System.Windows.Forms.TextBox();
            this.DgvConsulta = new System.Windows.Forms.DataGridView();
            this.BtnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // LblConsulta
            // 
            this.LblConsulta.AutoSize = true;
            this.LblConsulta.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConsulta.Location = new System.Drawing.Point(5, 25);
            this.LblConsulta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblConsulta.Name = "LblConsulta";
            this.LblConsulta.Size = new System.Drawing.Size(153, 22);
            this.LblConsulta.TabIndex = 0;
            this.LblConsulta.Text = "Consulta en SQL:";
            // 
            // TxtConsulta
            // 
            this.TxtConsulta.Location = new System.Drawing.Point(9, 50);
            this.TxtConsulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtConsulta.Multiline = true;
            this.TxtConsulta.Name = "TxtConsulta";
            this.TxtConsulta.Size = new System.Drawing.Size(707, 194);
            this.TxtConsulta.TabIndex = 1;
            // 
            // DgvConsulta
            // 
            this.DgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsulta.Location = new System.Drawing.Point(9, 282);
            this.DgvConsulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvConsulta.Name = "DgvConsulta";
            this.DgvConsulta.RowHeadersWidth = 51;
            this.DgvConsulta.RowTemplate.Height = 24;
            this.DgvConsulta.Size = new System.Drawing.Size(706, 278);
            this.DgvConsulta.TabIndex = 2;
            // 
            // BtnListar
            // 
            this.BtnListar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListar.Location = new System.Drawing.Point(616, 248);
            this.BtnListar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(98, 29);
            this.BtnListar.TabIndex = 3;
            this.BtnListar.Text = "Listar";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // frmConsultaSqlBd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 570);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.DgvConsulta);
            this.Controls.Add(this.TxtConsulta);
            this.Controls.Add(this.LblConsulta);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmConsultaSqlBd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaSqlBd";
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblConsulta;
        private System.Windows.Forms.TextBox TxtConsulta;
        private System.Windows.Forms.DataGridView DgvConsulta;
        private System.Windows.Forms.Button BtnListar;
    }
}