namespace WindowsFormsApp1
{
    partial class frmConsultaTablaBd
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
            this.DgvDatos = new System.Windows.Forms.DataGridView();
            this.LblTabla = new System.Windows.Forms.Label();
            this.CmbTabla = new System.Windows.Forms.ComboBox();
            this.BtnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDatos
            // 
            this.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDatos.Location = new System.Drawing.Point(40, 33);
            this.DgvDatos.Margin = new System.Windows.Forms.Padding(4);
            this.DgvDatos.Name = "DgvDatos";
            this.DgvDatos.RowHeadersWidth = 51;
            this.DgvDatos.Size = new System.Drawing.Size(988, 593);
            this.DgvDatos.TabIndex = 0;
            // 
            // LblTabla
            // 
            this.LblTabla.AutoSize = true;
            this.LblTabla.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTabla.Location = new System.Drawing.Point(379, 660);
            this.LblTabla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTabla.Name = "LblTabla";
            this.LblTabla.Size = new System.Drawing.Size(198, 22);
            this.LblTabla.TabIndex = 1;
            this.LblTabla.Text = "Tabla de Base de Datos:";
            // 
            // CmbTabla
            // 
            this.CmbTabla.FormattingEnabled = true;
            this.CmbTabla.Items.AddRange(new object[] {
            "Autor",
            "Idioma ",
            "Libro ",
            "Pais"});
            this.CmbTabla.Location = new System.Drawing.Point(611, 655);
            this.CmbTabla.Margin = new System.Windows.Forms.Padding(4);
            this.CmbTabla.Name = "CmbTabla";
            this.CmbTabla.Size = new System.Drawing.Size(188, 24);
            this.CmbTabla.TabIndex = 2;
            // 
            // BtnListar
            // 
            this.BtnListar.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListar.Location = new System.Drawing.Point(928, 641);
            this.BtnListar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(100, 47);
            this.BtnListar.TabIndex = 3;
            this.BtnListar.Text = "Listar";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // frmConsultaTablaBd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 719);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.CmbTabla);
            this.Controls.Add(this.LblTabla);
            this.Controls.Add(this.DgvDatos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConsultaTablaBd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaTablaBd";
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDatos;
        private System.Windows.Forms.Label LblTabla;
        private System.Windows.Forms.ComboBox CmbTabla;
        private System.Windows.Forms.Button BtnListar;
    }
}