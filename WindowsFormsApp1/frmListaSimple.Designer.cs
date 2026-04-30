namespace WindowsFormsApp1
{
    partial class frmListaSimple
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
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.LblCodigoo = new System.Windows.Forms.Label();
            this.TxtTramite = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.LblTramite = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.GpbNuevo = new System.Windows.Forms.GroupBox();
            this.GpbEliminado = new System.Windows.Forms.GroupBox();
            this.CmbCodigo = new System.Windows.Forms.ComboBox();
            this.GpbListadoGrilla = new System.Windows.Forms.GroupBox();
            this.LstLista = new System.Windows.Forms.ListBox();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GpbEliminado.SuspendLayout();
            this.GpbListadoGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(590, 154);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(173, 31);
            this.BtnEliminar.TabIndex = 33;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(354, 154);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(162, 31);
            this.BtnAgregar.TabIndex = 32;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // LblCodigoo
            // 
            this.LblCodigoo.AutoSize = true;
            this.LblCodigoo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigoo.Location = new System.Drawing.Point(6, 70);
            this.LblCodigoo.Name = "LblCodigoo";
            this.LblCodigoo.Size = new System.Drawing.Size(48, 15);
            this.LblCodigoo.TabIndex = 26;
            this.LblCodigoo.Text = "Codigo:";
            // 
            // TxtTramite
            // 
            this.TxtTramite.Location = new System.Drawing.Point(416, 119);
            this.TxtTramite.Name = "TxtTramite";
            this.TxtTramite.Size = new System.Drawing.Size(100, 20);
            this.TxtTramite.TabIndex = 25;
            this.TxtTramite.TextChanged += new System.EventHandler(this.TxtTramite_TextChanged);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(416, 84);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 24;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(416, 47);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(100, 20);
            this.TxtCodigo.TabIndex = 23;
            this.TxtCodigo.TextChanged += new System.EventHandler(this.TxtCodigo_TextChanged);
            // 
            // LblTramite
            // 
            this.LblTramite.AutoSize = true;
            this.LblTramite.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTramite.Location = new System.Drawing.Point(351, 126);
            this.LblTramite.Name = "LblTramite";
            this.LblTramite.Size = new System.Drawing.Size(54, 15);
            this.LblTramite.TabIndex = 22;
            this.LblTramite.Text = "Tramite:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(351, 92);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(55, 15);
            this.LblNombre.TabIndex = 21;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(351, 54);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(48, 15);
            this.LblCodigo.TabIndex = 20;
            this.LblCodigo.Text = "Codigo:";
            // 
            // GpbNuevo
            // 
            this.GpbNuevo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbNuevo.Location = new System.Drawing.Point(344, 15);
            this.GpbNuevo.Name = "GpbNuevo";
            this.GpbNuevo.Size = new System.Drawing.Size(182, 170);
            this.GpbNuevo.TabIndex = 34;
            this.GpbNuevo.TabStop = false;
            this.GpbNuevo.Text = "Nuevo Elemento";
            // 
            // GpbEliminado
            // 
            this.GpbEliminado.Controls.Add(this.CmbCodigo);
            this.GpbEliminado.Controls.Add(this.LblCodigoo);
            this.GpbEliminado.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbEliminado.Location = new System.Drawing.Point(578, 15);
            this.GpbEliminado.Name = "GpbEliminado";
            this.GpbEliminado.Size = new System.Drawing.Size(194, 170);
            this.GpbEliminado.TabIndex = 35;
            this.GpbEliminado.TabStop = false;
            this.GpbEliminado.Text = "Elemento Eliminado";
            // 
            // CmbCodigo
            // 
            this.CmbCodigo.FormattingEnabled = true;
            this.CmbCodigo.Location = new System.Drawing.Point(59, 66);
            this.CmbCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.CmbCodigo.Name = "CmbCodigo";
            this.CmbCodigo.Size = new System.Drawing.Size(104, 24);
            this.CmbCodigo.TabIndex = 27;
            this.CmbCodigo.SelectedIndexChanged += new System.EventHandler(this.CmbCodigo_SelectedIndexChanged);
            // 
            // GpbListadoGrilla
            // 
            this.GpbListadoGrilla.Controls.Add(this.LstLista);
            this.GpbListadoGrilla.Controls.Add(this.DgvLista);
            this.GpbListadoGrilla.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbListadoGrilla.Location = new System.Drawing.Point(100, 191);
            this.GpbListadoGrilla.Name = "GpbListadoGrilla";
            this.GpbListadoGrilla.Size = new System.Drawing.Size(663, 225);
            this.GpbListadoGrilla.TabIndex = 36;
            this.GpbListadoGrilla.TabStop = false;
            this.GpbListadoGrilla.Text = "Listado en una Lista y una Grilla";
            // 
            // LstLista
            // 
            this.LstLista.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstLista.FormattingEnabled = true;
            this.LstLista.ItemHeight = 15;
            this.LstLista.Location = new System.Drawing.Point(38, 20);
            this.LstLista.Name = "LstLista";
            this.LstLista.Size = new System.Drawing.Size(196, 184);
            this.LstLista.TabIndex = 15;
            // 
            // DgvLista
            // 
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvLista.Location = new System.Drawing.Point(254, 20);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.RowHeadersWidth = 51;
            this.DgvLista.Size = new System.Drawing.Size(393, 199);
            this.DgvLista.TabIndex = 12;
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
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tramite";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._01_ListaSimple1;
            this.pictureBox1.Location = new System.Drawing.Point(138, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // frmListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 431);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtTramite);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.LblTramite);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.GpbNuevo);
            this.Controls.Add(this.GpbEliminado);
            this.Controls.Add(this.GpbListadoGrilla);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmListaSimple";
            this.Text = "frmListaSimple";
            this.Load += new System.EventHandler(this.frmListaSimple_Load);
            this.GpbEliminado.ResumeLayout(false);
            this.GpbEliminado.PerformLayout();
            this.GpbListadoGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label LblCodigoo;
        private System.Windows.Forms.TextBox TxtTramite;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label LblTramite;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.GroupBox GpbNuevo;
        private System.Windows.Forms.GroupBox GpbEliminado;
        private System.Windows.Forms.GroupBox GpbListadoGrilla;
        private System.Windows.Forms.ListBox LstLista;
        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox CmbCodigo;
    }
}