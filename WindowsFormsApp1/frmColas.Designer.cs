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
            this.TxtCodigos = new System.Windows.Forms.TextBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.TxtTramites = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtTramite = new System.Windows.Forms.TextBox();
            this.DgvColas = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.GpbElementoNuevo = new System.Windows.Forms.GroupBox();
            this.GpbElementoEliminado = new System.Windows.Forms.GroupBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LstListado = new System.Windows.Forms.ListBox();
            this.GpbListadoListaGrilla = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvColas)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(323, 86);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(63, 20);
            this.LblCodigo.TabIndex = 0;
            this.LblCodigo.Text = "Codigo:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(323, 143);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(72, 20);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblTramite
            // 
            this.LblTramite.AutoSize = true;
            this.LblTramite.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTramite.Location = new System.Drawing.Point(323, 195);
            this.LblTramite.Name = "LblTramite";
            this.LblTramite.Size = new System.Drawing.Size(66, 20);
            this.LblTramite.TabIndex = 2;
            this.LblTramite.Text = "Tramite";
            // 
            // LblCodigos
            // 
            this.LblCodigos.AutoSize = true;
            this.LblCodigos.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigos.Location = new System.Drawing.Point(585, 86);
            this.LblCodigos.Name = "LblCodigos";
            this.LblCodigos.Size = new System.Drawing.Size(63, 20);
            this.LblCodigos.TabIndex = 6;
            this.LblCodigos.Text = "Codigo:";
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombres.Location = new System.Drawing.Point(585, 143);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(72, 20);
            this.LblNombres.TabIndex = 7;
            this.LblNombres.Text = "Nombre:";
            // 
            // LblTramites
            // 
            this.LblTramites.AutoSize = true;
            this.LblTramites.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTramites.Location = new System.Drawing.Point(585, 195);
            this.LblTramites.Name = "LblTramites";
            this.LblTramites.Size = new System.Drawing.Size(70, 20);
            this.LblTramites.TabIndex = 8;
            this.LblTramites.Text = "Tramite:";
            // 
            // TxtCodigos
            // 
            this.TxtCodigos.Location = new System.Drawing.Point(672, 80);
            this.TxtCodigos.Name = "TxtCodigos";
            this.TxtCodigos.Size = new System.Drawing.Size(100, 22);
            this.TxtCodigos.TabIndex = 9;
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(672, 143);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(100, 22);
            this.TxtNombres.TabIndex = 10;
            // 
            // TxtTramites
            // 
            this.TxtTramites.Location = new System.Drawing.Point(672, 189);
            this.TxtTramites.Name = "TxtTramites";
            this.TxtTramites.Size = new System.Drawing.Size(100, 22);
            this.TxtTramites.TabIndex = 11;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(401, 79);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(100, 22);
            this.TxtCodigo.TabIndex = 12;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(401, 136);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 22);
            this.TxtNombre.TabIndex = 13;
            // 
            // TxtTramite
            // 
            this.TxtTramite.Location = new System.Drawing.Point(401, 188);
            this.TxtTramite.Name = "TxtTramite";
            this.TxtTramite.Size = new System.Drawing.Size(100, 22);
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
            this.DgvColas.Location = new System.Drawing.Point(318, 339);
            this.DgvColas.Name = "DgvColas";
            this.DgvColas.RowHeadersWidth = 51;
            this.DgvColas.RowTemplate.Height = 24;
            this.DgvColas.Size = new System.Drawing.Size(479, 212);
            this.DgvColas.TabIndex = 16;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(326, 235);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(175, 34);
            this.BtnAgregar.TabIndex = 17;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(588, 235);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(184, 34);
            this.BtnEliminar.TabIndex = 18;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // GpbElementoNuevo
            // 
            this.GpbElementoNuevo.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbElementoNuevo.Location = new System.Drawing.Point(297, 35);
            this.GpbElementoNuevo.Name = "GpbElementoNuevo";
            this.GpbElementoNuevo.Size = new System.Drawing.Size(247, 234);
            this.GpbElementoNuevo.TabIndex = 19;
            this.GpbElementoNuevo.TabStop = false;
            this.GpbElementoNuevo.Text = "Nuevo Elemento";
            // 
            // GpbElementoEliminado
            // 
            this.GpbElementoEliminado.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbElementoEliminado.Location = new System.Drawing.Point(563, 35);
            this.GpbElementoEliminado.Name = "GpbElementoEliminado";
            this.GpbElementoEliminado.Size = new System.Drawing.Size(247, 234);
            this.GpbElementoEliminado.TabIndex = 20;
            this.GpbElementoEliminado.TabStop = false;
            this.GpbElementoEliminado.Text = "Elemento Eliminado";
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
            // LstListado
            // 
            this.LstListado.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstListado.FormattingEnabled = true;
            this.LstListado.ItemHeight = 20;
            this.LstListado.Location = new System.Drawing.Point(67, 339);
            this.LstListado.Name = "LstListado";
            this.LstListado.Size = new System.Drawing.Size(229, 204);
            this.LstListado.TabIndex = 21;
            // 
            // GpbListadoListaGrilla
            // 
            this.GpbListadoListaGrilla.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbListadoListaGrilla.Location = new System.Drawing.Point(34, 318);
            this.GpbListadoListaGrilla.Name = "GpbListadoListaGrilla";
            this.GpbListadoListaGrilla.Size = new System.Drawing.Size(776, 241);
            this.GpbListadoListaGrilla.TabIndex = 22;
            this.GpbListadoListaGrilla.TabStop = false;
            this.GpbListadoListaGrilla.Text = "Listado en una Lista y una Grilla";
            // 
            // frmColas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(837, 591);
            this.Controls.Add(this.LstListado);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DgvColas);
            this.Controls.Add(this.TxtTramite);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.TxtTramites);
            this.Controls.Add(this.TxtNombres);
            this.Controls.Add(this.TxtCodigos);
            this.Controls.Add(this.LblTramites);
            this.Controls.Add(this.LblNombres);
            this.Controls.Add(this.LblCodigos);
            this.Controls.Add(this.LblTramite);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.GpbElementoNuevo);
            this.Controls.Add(this.GpbElementoEliminado);
            this.Controls.Add(this.GpbListadoListaGrilla);
            this.Name = "frmColas";
            this.Text = "frmColas";
            ((System.ComponentModel.ISupportInitialize)(this.DgvColas)).EndInit();
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
        private System.Windows.Forms.TextBox TxtCodigos;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.TextBox TxtTramites;
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
    }
}