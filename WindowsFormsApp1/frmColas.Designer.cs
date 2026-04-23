namespace WindowsFormsApp1
{
    partial class frmColas
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
            this.LblTramite = new System.Windows.Forms.Label();
            this.LblCodigos = new System.Windows.Forms.Label();
            this.LblNombres = new System.Windows.Forms.Label();
            this.LblTramites = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtTramite = new System.Windows.Forms.TextBox();
            this.DgvColas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.GpbElementoNuevo = new System.Windows.Forms.GroupBox();
            this.GpbElementoEliminado = new System.Windows.Forms.GroupBox();
            this.LstListado = new System.Windows.Forms.ListBox();
            this.GpbListadoListaGrilla = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblCodigoo = new System.Windows.Forms.Label();
            this.LblNombree = new System.Windows.Forms.Label();
            this.LblTramitee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvColas)).BeginInit();
            this.GpbElementoEliminado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(242, 70);
            this.LblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(52, 16);
            this.LblCodigo.TabIndex = 0;
            this.LblCodigo.Text = "Codigo:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(242, 116);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(61, 16);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblTramite
            // 
            this.LblTramite.AutoSize = true;
            this.LblTramite.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTramite.Location = new System.Drawing.Point(242, 158);
            this.LblTramite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTramite.Name = "LblTramite";
            this.LblTramite.Size = new System.Drawing.Size(56, 16);
            this.LblTramite.TabIndex = 2;
            this.LblTramite.Text = "Tramite";
            // 
            // LblCodigos
            // 
            this.LblCodigos.AutoSize = true;
            this.LblCodigos.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigos.Location = new System.Drawing.Point(439, 70);
            this.LblCodigos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCodigos.Name = "LblCodigos";
            this.LblCodigos.Size = new System.Drawing.Size(52, 16);
            this.LblCodigos.TabIndex = 6;
            this.LblCodigos.Text = "Codigo:";
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombres.Location = new System.Drawing.Point(439, 116);
            this.LblNombres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(61, 16);
            this.LblNombres.TabIndex = 7;
            this.LblNombres.Text = "Nombre:";
            // 
            // LblTramites
            // 
            this.LblTramites.AutoSize = true;
            this.LblTramites.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTramites.Location = new System.Drawing.Point(439, 158);
            this.LblTramites.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTramites.Name = "LblTramites";
            this.LblTramites.Size = new System.Drawing.Size(60, 16);
            this.LblTramites.TabIndex = 8;
            this.LblTramites.Text = "Tramite:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(301, 64);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(76, 20);
            this.TxtCodigo.TabIndex = 12;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(301, 110);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(76, 20);
            this.TxtNombre.TabIndex = 13;
            // 
            // TxtTramite
            // 
            this.TxtTramite.Location = new System.Drawing.Point(301, 153);
            this.TxtTramite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtTramite.Name = "TxtTramite";
            this.TxtTramite.Size = new System.Drawing.Size(76, 20);
            this.TxtTramite.TabIndex = 14;
            // 
            // DgvColas
            // 
            this.DgvColas.AllowUserToAddRows = false;
            this.DgvColas.AllowUserToOrderColumns = true;
            this.DgvColas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvColas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvColas.Location = new System.Drawing.Point(238, 275);
            this.DgvColas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvColas.Name = "DgvColas";
            this.DgvColas.RowHeadersWidth = 51;
            this.DgvColas.RowTemplate.Height = 24;
            this.DgvColas.Size = new System.Drawing.Size(359, 172);
            this.DgvColas.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 150F;
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
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tramite";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(244, 191);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(131, 28);
            this.BtnAgregar.TabIndex = 17;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(441, 191);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(138, 28);
            this.BtnEliminar.TabIndex = 18;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // GpbElementoNuevo
            // 
            this.GpbElementoNuevo.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbElementoNuevo.Location = new System.Drawing.Point(223, 28);
            this.GpbElementoNuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GpbElementoNuevo.Name = "GpbElementoNuevo";
            this.GpbElementoNuevo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GpbElementoNuevo.Size = new System.Drawing.Size(185, 190);
            this.GpbElementoNuevo.TabIndex = 19;
            this.GpbElementoNuevo.TabStop = false;
            this.GpbElementoNuevo.Text = "Nuevo Elemento";
            // 
            // GpbElementoEliminado
            // 
            this.GpbElementoEliminado.Controls.Add(this.LblTramitee);
            this.GpbElementoEliminado.Controls.Add(this.LblNombree);
            this.GpbElementoEliminado.Controls.Add(this.LblCodigoo);
            this.GpbElementoEliminado.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbElementoEliminado.Location = new System.Drawing.Point(422, 28);
            this.GpbElementoEliminado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GpbElementoEliminado.Name = "GpbElementoEliminado";
            this.GpbElementoEliminado.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GpbElementoEliminado.Size = new System.Drawing.Size(185, 190);
            this.GpbElementoEliminado.TabIndex = 20;
            this.GpbElementoEliminado.TabStop = false;
            this.GpbElementoEliminado.Text = "Elemento Eliminado";
            // 
            // LstListado
            // 
            this.LstListado.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstListado.FormattingEnabled = true;
            this.LstListado.ItemHeight = 16;
            this.LstListado.Location = new System.Drawing.Point(50, 275);
            this.LstListado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LstListado.Name = "LstListado";
            this.LstListado.Size = new System.Drawing.Size(173, 164);
            this.LstListado.TabIndex = 21;
            // 
            // GpbListadoListaGrilla
            // 
            this.GpbListadoListaGrilla.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbListadoListaGrilla.Location = new System.Drawing.Point(26, 258);
            this.GpbListadoListaGrilla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GpbListadoListaGrilla.Name = "GpbListadoListaGrilla";
            this.GpbListadoListaGrilla.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GpbListadoListaGrilla.Size = new System.Drawing.Size(582, 196);
            this.GpbListadoListaGrilla.TabIndex = 22;
            this.GpbListadoListaGrilla.TabStop = false;
            this.GpbListadoListaGrilla.Text = "Listado en una Lista y una Grilla";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(40, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // LblCodigoo
            // 
            this.LblCodigoo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCodigoo.Location = new System.Drawing.Point(96, 36);
            this.LblCodigoo.Name = "LblCodigoo";
            this.LblCodigoo.Size = new System.Drawing.Size(61, 22);
            this.LblCodigoo.TabIndex = 0;
            // 
            // LblNombree
            // 
            this.LblNombree.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblNombree.Location = new System.Drawing.Point(99, 82);
            this.LblNombree.Name = "LblNombree";
            this.LblNombree.Size = new System.Drawing.Size(58, 21);
            this.LblNombree.TabIndex = 1;
            // 
            // LblTramitee
            // 
            this.LblTramitee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTramitee.Location = new System.Drawing.Point(99, 125);
            this.LblTramitee.Name = "LblTramitee";
            this.LblTramitee.Size = new System.Drawing.Size(58, 20);
            this.LblTramitee.TabIndex = 2;
            // 
            // frmColas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(628, 480);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LstListado);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DgvColas);
            this.Controls.Add(this.TxtTramite);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.LblTramites);
            this.Controls.Add(this.LblNombres);
            this.Controls.Add(this.LblCodigos);
            this.Controls.Add(this.LblTramite);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.GpbElementoNuevo);
            this.Controls.Add(this.GpbElementoEliminado);
            this.Controls.Add(this.GpbListadoListaGrilla);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmColas";
            this.Text = "frmColas";
            ((System.ComponentModel.ISupportInitialize)(this.DgvColas)).EndInit();
            this.GpbElementoEliminado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblTramite;
        private System.Windows.Forms.Label LblCodigos;
        private System.Windows.Forms.Label LblNombres;
        private System.Windows.Forms.Label LblTramites;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtTramite;
        private System.Windows.Forms.DataGridView DgvColas;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.GroupBox GpbElementoNuevo;
        private System.Windows.Forms.GroupBox GpbElementoEliminado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ListBox LstListado;
        private System.Windows.Forms.GroupBox GpbListadoListaGrilla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblTramitee;
        private System.Windows.Forms.Label LblNombree;
        private System.Windows.Forms.Label LblCodigoo;
    }
}