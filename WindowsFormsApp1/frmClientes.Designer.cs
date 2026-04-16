namespace WindowsFormsApp1
{
    partial class frmClientes
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
            this.LblDeuda = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtDeuda = new System.Windows.Forms.TextBox();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(31, 55);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(48, 15);
            this.LblCodigo.TabIndex = 0;
            this.LblCodigo.Text = "Codigo:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(31, 99);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(55, 15);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblDeuda
            // 
            this.LblDeuda.AutoSize = true;
            this.LblDeuda.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDeuda.Location = new System.Drawing.Point(31, 141);
            this.LblDeuda.Name = "LblDeuda";
            this.LblDeuda.Size = new System.Drawing.Size(45, 15);
            this.LblDeuda.TabIndex = 2;
            this.LblDeuda.Text = "Deuda:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(348, 50);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(100, 20);
            this.TxtCodigo.TabIndex = 3;
            // 
            // TxtDeuda
            // 
            this.TxtDeuda.Location = new System.Drawing.Point(348, 133);
            this.TxtDeuda.Name = "TxtDeuda";
            this.TxtDeuda.Size = new System.Drawing.Size(100, 20);
            this.TxtDeuda.TabIndex = 5;
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGrabar.Location = new System.Drawing.Point(348, 195);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(100, 23);
            this.BtnGrabar.TabIndex = 6;
            this.BtnGrabar.Text = "Grabar";
            this.BtnGrabar.UseVisualStyleBackColor = true;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(95, 99);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(353, 20);
            this.TxtNombre.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(34, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(414, 202);
            this.dataGridView1.TabIndex = 9;
            // 
            // Codigo
            // 
            this.Codigo.Frozen = true;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 150;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Nombre ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Carrera";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(459, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.BtnGrabar);
            this.Controls.Add(this.TxtDeuda);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.LblDeuda);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblCodigo);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblDeuda;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtDeuda;
        private System.Windows.Forms.Button BtnGrabar;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}