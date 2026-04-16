namespace WindowsFormsApp1
{
    partial class frmAlumnos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(24, 25);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(48, 15);
            this.LblCodigo.TabIndex = 0;
            this.LblCodigo.Text = "Codigo:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(24, 71);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(55, 15);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblCarrera
            // 
            this.LblCarrera.AutoSize = true;
            this.LblCarrera.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCarrera.Location = new System.Drawing.Point(24, 113);
            this.LblCarrera.Name = "LblCarrera";
            this.LblCarrera.Size = new System.Drawing.Size(50, 15);
            this.LblCarrera.TabIndex = 2;
            this.LblCarrera.Text = "Carrera:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(296, 25);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(100, 20);
            this.TxtCodigo.TabIndex = 3;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(296, 64);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 4;
            // 
            // CmbCarrera
            // 
            this.CmbCarrera.FormattingEnabled = true;
            this.CmbCarrera.Location = new System.Drawing.Point(150, 105);
            this.CmbCarrera.Name = "CmbCarrera";
            this.CmbCarrera.Size = new System.Drawing.Size(246, 21);
            this.CmbCarrera.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(27, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(369, 181);
            this.dataGridView1.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre ";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Carrera";
            this.Column3.Name = "Column3";
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(425, 353);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CmbCarrera);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.LblCarrera);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblCodigo);
            this.Name = "frmAlumnos";
            this.Text = "frmAlumnos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}