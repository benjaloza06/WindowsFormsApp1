namespace WindowsFormsApp1
{
    partial class frmPila
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
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtTramite = new System.Windows.Forms.TextBox();
            this.LblCodigoo = new System.Windows.Forms.Label();
            this.LblNombree = new System.Windows.Forms.Label();
            this.LblTramitee = new System.Windows.Forms.Label();
            this.LblCo = new System.Windows.Forms.Label();
            this.LblNom = new System.Windows.Forms.Label();
            this.LblTram = new System.Windows.Forms.Label();
            this.DgvPila = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.LstPila = new System.Windows.Forms.ListBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GpbNuevo = new System.Windows.Forms.GroupBox();
            this.GpbEliminado = new System.Windows.Forms.GroupBox();
            this.GpbListadoGrilla = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPila)).BeginInit();
            this.GpbListadoGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(284, 62);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(48, 15);
            this.LblCodigo.TabIndex = 0;
            this.LblCodigo.Text = "Codigo:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(284, 100);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(55, 15);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblTramite
            // 
            this.LblTramite.AutoSize = true;
            this.LblTramite.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTramite.Location = new System.Drawing.Point(284, 134);
            this.LblTramite.Name = "LblTramite";
            this.LblTramite.Size = new System.Drawing.Size(54, 15);
            this.LblTramite.TabIndex = 2;
            this.LblTramite.Text = "Tramite:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(349, 55);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(100, 20);
            this.TxtCodigo.TabIndex = 3;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(349, 93);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 4;
            // 
            // TxtTramite
            // 
            this.TxtTramite.Location = new System.Drawing.Point(349, 127);
            this.TxtTramite.Name = "TxtTramite";
            this.TxtTramite.Size = new System.Drawing.Size(100, 20);
            this.TxtTramite.TabIndex = 5;
            // 
            // LblCodigoo
            // 
            this.LblCodigoo.AutoSize = true;
            this.LblCodigoo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigoo.Location = new System.Drawing.Point(517, 61);
            this.LblCodigoo.Name = "LblCodigoo";
            this.LblCodigoo.Size = new System.Drawing.Size(48, 15);
            this.LblCodigoo.TabIndex = 6;
            this.LblCodigoo.Text = "Codigo:";
            this.LblCodigoo.Click += new System.EventHandler(this.LblCodigoo_Click);
            // 
            // LblNombree
            // 
            this.LblNombree.AutoSize = true;
            this.LblNombree.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombree.Location = new System.Drawing.Point(520, 99);
            this.LblNombree.Name = "LblNombree";
            this.LblNombree.Size = new System.Drawing.Size(55, 15);
            this.LblNombree.TabIndex = 7;
            this.LblNombree.Text = "Nombre:";
            // 
            // LblTramitee
            // 
            this.LblTramitee.AutoSize = true;
            this.LblTramitee.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTramitee.Location = new System.Drawing.Point(520, 133);
            this.LblTramitee.Name = "LblTramitee";
            this.LblTramitee.Size = new System.Drawing.Size(54, 15);
            this.LblTramitee.TabIndex = 8;
            this.LblTramitee.Text = "Tramite:";
            // 
            // LblCo
            // 
            this.LblCo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCo.Location = new System.Drawing.Point(593, 61);
            this.LblCo.Name = "LblCo";
            this.LblCo.Size = new System.Drawing.Size(100, 23);
            this.LblCo.TabIndex = 9;
            // 
            // LblNom
            // 
            this.LblNom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblNom.Location = new System.Drawing.Point(596, 99);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(100, 23);
            this.LblNom.TabIndex = 10;
            // 
            // LblTram
            // 
            this.LblTram.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTram.Location = new System.Drawing.Point(596, 133);
            this.LblTram.Name = "LblTram";
            this.LblTram.Size = new System.Drawing.Size(100, 23);
            this.LblTram.TabIndex = 11;
            // 
            // DgvPila
            // 
            this.DgvPila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvPila.Location = new System.Drawing.Point(254, 20);
            this.DgvPila.Name = "DgvPila";
            this.DgvPila.Size = new System.Drawing.Size(393, 199);
            this.DgvPila.TabIndex = 12;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(287, 162);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(162, 31);
            this.BtnAgregar.TabIndex = 13;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(523, 162);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(173, 31);
            this.BtnEliminar.TabIndex = 14;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // LstPila
            // 
            this.LstPila.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstPila.FormattingEnabled = true;
            this.LstPila.ItemHeight = 15;
            this.LstPila.Location = new System.Drawing.Point(38, 20);
            this.LstPila.Name = "LstPila";
            this.LstPila.Size = new System.Drawing.Size(196, 199);
            this.LstPila.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tramite";
            this.Column3.Name = "Column3";
            // 
            // GpbNuevo
            // 
            this.GpbNuevo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbNuevo.Location = new System.Drawing.Point(277, 23);
            this.GpbNuevo.Name = "GpbNuevo";
            this.GpbNuevo.Size = new System.Drawing.Size(182, 170);
            this.GpbNuevo.TabIndex = 16;
            this.GpbNuevo.TabStop = false;
            this.GpbNuevo.Text = "Nuevo Elemento";
            // 
            // GpbEliminado
            // 
            this.GpbEliminado.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbEliminado.Location = new System.Drawing.Point(511, 23);
            this.GpbEliminado.Name = "GpbEliminado";
            this.GpbEliminado.Size = new System.Drawing.Size(194, 170);
            this.GpbEliminado.TabIndex = 17;
            this.GpbEliminado.TabStop = false;
            this.GpbEliminado.Text = "Elemento Eliminado";
            // 
            // GpbListadoGrilla
            // 
            this.GpbListadoGrilla.Controls.Add(this.LstPila);
            this.GpbListadoGrilla.Controls.Add(this.DgvPila);
            this.GpbListadoGrilla.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbListadoGrilla.Location = new System.Drawing.Point(33, 199);
            this.GpbListadoGrilla.Name = "GpbListadoGrilla";
            this.GpbListadoGrilla.Size = new System.Drawing.Size(663, 225);
            this.GpbListadoGrilla.TabIndex = 18;
            this.GpbListadoGrilla.TabStop = false;
            this.GpbListadoGrilla.Text = "Listado en una Lista y una Grilla";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.cola_3;
            this.pictureBox1.Location = new System.Drawing.Point(71, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.LblTram);
            this.Controls.Add(this.LblNom);
            this.Controls.Add(this.LblCo);
            this.Controls.Add(this.LblTramitee);
            this.Controls.Add(this.LblNombree);
            this.Controls.Add(this.LblCodigoo);
            this.Controls.Add(this.TxtTramite);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.LblTramite);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.GpbNuevo);
            this.Controls.Add(this.GpbEliminado);
            this.Controls.Add(this.GpbListadoGrilla);
            this.Name = "frmPila";
            this.Text = "frmPila";
            ((System.ComponentModel.ISupportInitialize)(this.DgvPila)).EndInit();
            this.GpbListadoGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblTramite;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtTramite;
        private System.Windows.Forms.Label LblCodigoo;
        private System.Windows.Forms.Label LblNombree;
        private System.Windows.Forms.Label LblTramitee;
        private System.Windows.Forms.Label LblCo;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.Label LblTram;
        private System.Windows.Forms.DataGridView DgvPila;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.ListBox LstPila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox GpbNuevo;
        private System.Windows.Forms.GroupBox GpbEliminado;
        private System.Windows.Forms.GroupBox GpbListadoGrilla;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}