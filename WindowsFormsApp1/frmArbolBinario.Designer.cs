namespace WindowsFormsApp1
{
    partial class frmArbolBinario
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
            this.BtnEquilibrar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtTramite = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.LblTramite = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.GpbNuevo = new System.Windows.Forms.GroupBox();
            this.GpbEliminar = new System.Windows.Forms.GroupBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.CmbCodigo = new System.Windows.Forms.ComboBox();
            this.LblCodigoo = new System.Windows.Forms.Label();
            this.GpbListadoGrilla = new System.Windows.Forms.GroupBox();
            this.RdbPostOr = new System.Windows.Forms.RadioButton();
            this.RdbPreOr = new System.Windows.Forms.RadioButton();
            this.RdbInOr = new System.Windows.Forms.RadioButton();
            this.DgvArbol = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TvwArbol = new System.Windows.Forms.TreeView();
            this.GpbNuevo.SuspendLayout();
            this.GpbEliminar.SuspendLayout();
            this.GpbListadoGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArbol)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEquilibrar
            // 
            this.BtnEquilibrar.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEquilibrar.Location = new System.Drawing.Point(459, 146);
            this.BtnEquilibrar.Name = "BtnEquilibrar";
            this.BtnEquilibrar.Size = new System.Drawing.Size(173, 31);
            this.BtnEquilibrar.TabIndex = 45;
            this.BtnEquilibrar.Text = "Equilibrar";
            this.BtnEquilibrar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(8, 124);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(162, 31);
            this.BtnAgregar.TabIndex = 44;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtTramite
            // 
            this.TxtTramite.Location = new System.Drawing.Point(70, 84);
            this.TxtTramite.Name = "TxtTramite";
            this.TxtTramite.Size = new System.Drawing.Size(100, 23);
            this.TxtTramite.TabIndex = 43;
            this.TxtTramite.TextChanged += new System.EventHandler(this.TxtTramite_TextChanged);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(70, 55);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 23);
            this.TxtNombre.TabIndex = 42;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(70, 25);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(100, 23);
            this.TxtCodigo.TabIndex = 41;
            this.TxtCodigo.TextChanged += new System.EventHandler(this.TxtCodigo_TextChanged);
            // 
            // LblTramite
            // 
            this.LblTramite.AutoSize = true;
            this.LblTramite.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTramite.Location = new System.Drawing.Point(4, 89);
            this.LblTramite.Name = "LblTramite";
            this.LblTramite.Size = new System.Drawing.Size(54, 15);
            this.LblTramite.TabIndex = 40;
            this.LblTramite.Text = "Tramite:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(6, 57);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(55, 15);
            this.LblNombre.TabIndex = 39;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(6, 27);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(48, 15);
            this.LblCodigo.TabIndex = 38;
            this.LblCodigo.Text = "Codigo:";
            // 
            // GpbNuevo
            // 
            this.GpbNuevo.Controls.Add(this.BtnAgregar);
            this.GpbNuevo.Controls.Add(this.TxtTramite);
            this.GpbNuevo.Controls.Add(this.TxtCodigo);
            this.GpbNuevo.Controls.Add(this.TxtNombre);
            this.GpbNuevo.Controls.Add(this.LblCodigo);
            this.GpbNuevo.Controls.Add(this.LblTramite);
            this.GpbNuevo.Controls.Add(this.LblNombre);
            this.GpbNuevo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbNuevo.Location = new System.Drawing.Point(226, 22);
            this.GpbNuevo.Name = "GpbNuevo";
            this.GpbNuevo.Size = new System.Drawing.Size(182, 170);
            this.GpbNuevo.TabIndex = 46;
            this.GpbNuevo.TabStop = false;
            this.GpbNuevo.Text = "Nuevo Elemento";
            // 
            // GpbEliminar
            // 
            this.GpbEliminar.Controls.Add(this.BtnEliminar);
            this.GpbEliminar.Controls.Add(this.CmbCodigo);
            this.GpbEliminar.Controls.Add(this.LblCodigoo);
            this.GpbEliminar.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbEliminar.Location = new System.Drawing.Point(442, 22);
            this.GpbEliminar.Name = "GpbEliminar";
            this.GpbEliminar.Size = new System.Drawing.Size(194, 106);
            this.GpbEliminar.TabIndex = 47;
            this.GpbEliminar.TabStop = false;
            this.GpbEliminar.Text = "Elemento a Eliminar";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(17, 58);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(160, 31);
            this.BtnEliminar.TabIndex = 28;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // CmbCodigo
            // 
            this.CmbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCodigo.FormattingEnabled = true;
            this.CmbCodigo.Location = new System.Drawing.Point(67, 24);
            this.CmbCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.CmbCodigo.Name = "CmbCodigo";
            this.CmbCodigo.Size = new System.Drawing.Size(104, 24);
            this.CmbCodigo.TabIndex = 27;
            this.CmbCodigo.SelectedIndexChanged += new System.EventHandler(this.CmbCodigo_SelectedIndexChanged);
            // 
            // LblCodigoo
            // 
            this.LblCodigoo.AutoSize = true;
            this.LblCodigoo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigoo.Location = new System.Drawing.Point(14, 28);
            this.LblCodigoo.Name = "LblCodigoo";
            this.LblCodigoo.Size = new System.Drawing.Size(48, 15);
            this.LblCodigoo.TabIndex = 26;
            this.LblCodigoo.Text = "Codigo:";
            // 
            // GpbListadoGrilla
            // 
            this.GpbListadoGrilla.Controls.Add(this.RdbPostOr);
            this.GpbListadoGrilla.Controls.Add(this.RdbPreOr);
            this.GpbListadoGrilla.Controls.Add(this.RdbInOr);
            this.GpbListadoGrilla.Controls.Add(this.DgvArbol);
            this.GpbListadoGrilla.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbListadoGrilla.Location = new System.Drawing.Point(10, 216);
            this.GpbListadoGrilla.Name = "GpbListadoGrilla";
            this.GpbListadoGrilla.Size = new System.Drawing.Size(683, 248);
            this.GpbListadoGrilla.TabIndex = 48;
            this.GpbListadoGrilla.TabStop = false;
            this.GpbListadoGrilla.Text = "Listado del árbol";
            // 
            // RdbPostOr
            // 
            this.RdbPostOr.AutoSize = true;
            this.RdbPostOr.Location = new System.Drawing.Point(23, 147);
            this.RdbPostOr.Margin = new System.Windows.Forms.Padding(2);
            this.RdbPostOr.Name = "RdbPostOr";
            this.RdbPostOr.Size = new System.Drawing.Size(93, 19);
            this.RdbPostOr.TabIndex = 15;
            this.RdbPostOr.TabStop = true;
            this.RdbPostOr.Text = "Post-Orden";
            this.RdbPostOr.UseVisualStyleBackColor = true;
            // 
            // RdbPreOr
            // 
            this.RdbPreOr.AutoSize = true;
            this.RdbPreOr.Location = new System.Drawing.Point(23, 84);
            this.RdbPreOr.Margin = new System.Windows.Forms.Padding(2);
            this.RdbPreOr.Name = "RdbPreOr";
            this.RdbPreOr.Size = new System.Drawing.Size(88, 19);
            this.RdbPreOr.TabIndex = 14;
            this.RdbPreOr.TabStop = true;
            this.RdbPreOr.Text = "Pre-Orden";
            this.RdbPreOr.UseVisualStyleBackColor = true;
            // 
            // RdbInOr
            // 
            this.RdbInOr.AutoSize = true;
            this.RdbInOr.Location = new System.Drawing.Point(23, 26);
            this.RdbInOr.Margin = new System.Windows.Forms.Padding(2);
            this.RdbInOr.Name = "RdbInOr";
            this.RdbInOr.Size = new System.Drawing.Size(80, 19);
            this.RdbInOr.TabIndex = 13;
            this.RdbInOr.TabStop = true;
            this.RdbInOr.Text = "In-Orden";
            this.RdbInOr.UseVisualStyleBackColor = true;
            // 
            // DgvArbol
            // 
            this.DgvArbol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvArbol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvArbol.Location = new System.Drawing.Point(217, 26);
            this.DgvArbol.Name = "DgvArbol";
            this.DgvArbol.RowHeadersVisible = false;
            this.DgvArbol.RowHeadersWidth = 51;
            this.DgvArbol.Size = new System.Drawing.Size(460, 199);
            this.DgvArbol.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tramite";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // TvwArbol
            // 
            this.TvwArbol.Location = new System.Drawing.Point(33, 29);
            this.TvwArbol.Name = "TvwArbol";
            this.TvwArbol.Size = new System.Drawing.Size(172, 163);
            this.TvwArbol.TabIndex = 49;
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 483);
            this.Controls.Add(this.TvwArbol);
            this.Controls.Add(this.BtnEquilibrar);
            this.Controls.Add(this.GpbNuevo);
            this.Controls.Add(this.GpbEliminar);
            this.Controls.Add(this.GpbListadoGrilla);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArbolBinario";
            this.Load += new System.EventHandler(this.frmArbolBinario_Load);
            this.GpbNuevo.ResumeLayout(false);
            this.GpbNuevo.PerformLayout();
            this.GpbEliminar.ResumeLayout(false);
            this.GpbEliminar.PerformLayout();
            this.GpbListadoGrilla.ResumeLayout(false);
            this.GpbListadoGrilla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArbol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnEquilibrar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox TxtTramite;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label LblTramite;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.GroupBox GpbNuevo;
        private System.Windows.Forms.GroupBox GpbEliminar;
        private System.Windows.Forms.ComboBox CmbCodigo;
        private System.Windows.Forms.Label LblCodigoo;
        private System.Windows.Forms.GroupBox GpbListadoGrilla;
        private System.Windows.Forms.DataGridView DgvArbol;
        private System.Windows.Forms.RadioButton RdbPostOr;
        private System.Windows.Forms.RadioButton RdbPreOr;
        private System.Windows.Forms.RadioButton RdbInOr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.TreeView TvwArbol;
    }
}