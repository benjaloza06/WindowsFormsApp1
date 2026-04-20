namespace WindowsFormsApp1
{
    partial class FrmAlumnos
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
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblCarrera = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.CmbCarrera = new System.Windows.Forms.ComboBox();
            this.DgvAlumnos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnGrabar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(32, 31);
            this.LblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(63, 20);
            this.LblCodigo.TabIndex = 0;
            this.LblCodigo.Text = "Codigo:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(32, 87);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(72, 20);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblCarrera
            // 
            this.LblCarrera.AutoSize = true;
            this.LblCarrera.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCarrera.Location = new System.Drawing.Point(32, 139);
            this.LblCarrera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCarrera.Name = "LblCarrera";
            this.LblCarrera.Size = new System.Drawing.Size(68, 20);
            this.LblCarrera.TabIndex = 2;
            this.LblCarrera.Text = "Carrera:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(395, 31);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(132, 22);
            this.TxtCodigo.TabIndex = 3;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(395, 79);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(132, 22);
            this.TxtNombre.TabIndex = 4;
            // 
            // CmbCarrera
            // 
            this.CmbCarrera.FormattingEnabled = true;
            this.CmbCarrera.Location = new System.Drawing.Point(200, 129);
            this.CmbCarrera.Margin = new System.Windows.Forms.Padding(4);
            this.CmbCarrera.Name = "CmbCarrera";
            this.CmbCarrera.Size = new System.Drawing.Size(327, 24);
            this.CmbCarrera.TabIndex = 5;
            // 
            // DgvAlumnos
            // 
            this.DgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvAlumnos.Location = new System.Drawing.Point(36, 186);
            this.DgvAlumnos.Margin = new System.Windows.Forms.Padding(4);
            this.DgvAlumnos.Name = "DgvAlumnos";
            this.DgvAlumnos.RowHeadersWidth = 51;
            this.DgvAlumnos.Size = new System.Drawing.Size(492, 223);
            this.DgvAlumnos.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Carrera";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGrabar.Location = new System.Drawing.Point(423, 427);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(103, 41);
            this.BtnGrabar.TabIndex = 7;
            this.BtnGrabar.Text = "Grabar";
            this.BtnGrabar.UseVisualStyleBackColor = true;
            // 
            // FrmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(567, 474);
            this.Controls.Add(this.BtnGrabar);
            this.Controls.Add(this.DgvAlumnos);
            this.Controls.Add(this.CmbCarrera);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.LblCarrera);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblCodigo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAlumnos";
            this.Text = "frmAlumnos";
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblCarrera;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.ComboBox CmbCarrera;
        private System.Windows.Forms.DataGridView DgvAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button BtnGrabar;
    }
}