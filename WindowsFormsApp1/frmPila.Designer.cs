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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.LstPila = new System.Windows.Forms.ListBox();
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
            this.LblCodigo.Location = new System.Drawing.Point(379, 76);
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
            this.LblNombre.Location = new System.Drawing.Point(379, 123);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(72, 20);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblTramite
            // 
            this.LblTramite.AutoSize = true;
            this.LblTramite.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTramite.Location = new System.Drawing.Point(379, 165);
            this.LblTramite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTramite.Name = "LblTramite";
            this.LblTramite.Size = new System.Drawing.Size(70, 20);
            this.LblTramite.TabIndex = 2;
            this.LblTramite.Text = "Tramite:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(465, 68);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(132, 22);
            this.TxtCodigo.TabIndex = 3;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(465, 114);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(132, 22);
            this.TxtNombre.TabIndex = 4;
            // 
            // TxtTramite
            // 
            this.TxtTramite.Location = new System.Drawing.Point(465, 156);
            this.TxtTramite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtTramite.Name = "TxtTramite";
            this.TxtTramite.Size = new System.Drawing.Size(132, 22);
            this.TxtTramite.TabIndex = 5;
            // 
            // LblCodigoo
            // 
            this.LblCodigoo.AutoSize = true;
            this.LblCodigoo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigoo.Location = new System.Drawing.Point(689, 75);
            this.LblCodigoo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCodigoo.Name = "LblCodigoo";
            this.LblCodigoo.Size = new System.Drawing.Size(63, 20);
            this.LblCodigoo.TabIndex = 6;
            this.LblCodigoo.Text = "Codigo:";
            this.LblCodigoo.Click += new System.EventHandler(this.LblCodigoo_Click);
            // 
            // LblNombree
            // 
            this.LblNombree.AutoSize = true;
            this.LblNombree.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombree.Location = new System.Drawing.Point(693, 122);
            this.LblNombree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombree.Name = "LblNombree";
            this.LblNombree.Size = new System.Drawing.Size(72, 20);
            this.LblNombree.TabIndex = 7;
            this.LblNombree.Text = "Nombre:";
            // 
            // LblTramitee
            // 
            this.LblTramitee.AutoSize = true;
            this.LblTramitee.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTramitee.Location = new System.Drawing.Point(693, 164);
            this.LblTramitee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTramitee.Name = "LblTramitee";
            this.LblTramitee.Size = new System.Drawing.Size(70, 20);
            this.LblTramitee.TabIndex = 8;
            this.LblTramitee.Text = "Tramite:";
            // 
            // LblCo
            // 
            this.LblCo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCo.Location = new System.Drawing.Point(791, 75);
            this.LblCo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCo.Name = "LblCo";
            this.LblCo.Size = new System.Drawing.Size(133, 28);
            this.LblCo.TabIndex = 9;
            // 
            // LblNom
            // 
            this.LblNom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblNom.Location = new System.Drawing.Point(795, 122);
            this.LblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(133, 28);
            this.LblNom.TabIndex = 10;
            // 
            // LblTram
            // 
            this.LblTram.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTram.Location = new System.Drawing.Point(795, 164);
            this.LblTram.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTram.Name = "LblTram";
            this.LblTram.Size = new System.Drawing.Size(133, 28);
            this.LblTram.TabIndex = 11;
            // 
            // DgvPila
            // 
            this.DgvPila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvPila.Location = new System.Drawing.Point(339, 25);
            this.DgvPila.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvPila.Name = "DgvPila";
            this.DgvPila.RowHeadersWidth = 51;
            this.DgvPila.Size = new System.Drawing.Size(524, 245);
            this.DgvPila.TabIndex = 12;
            this.DgvPila.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPila_CellContentClick);
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
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(383, 199);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(216, 38);
            this.BtnAgregar.TabIndex = 13;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(697, 199);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(231, 38);
            this.BtnEliminar.TabIndex = 14;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // LstPila
            // 
            this.LstPila.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstPila.FormattingEnabled = true;
            this.LstPila.ItemHeight = 19;
            this.LstPila.Location = new System.Drawing.Point(51, 25);
            this.LstPila.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LstPila.Name = "LstPila";
            this.LstPila.Size = new System.Drawing.Size(260, 232);
            this.LstPila.TabIndex = 15;
            // 
            // GpbNuevo
            // 
            this.GpbNuevo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbNuevo.Location = new System.Drawing.Point(369, 28);
            this.GpbNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GpbNuevo.Name = "GpbNuevo";
            this.GpbNuevo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GpbNuevo.Size = new System.Drawing.Size(243, 209);
            this.GpbNuevo.TabIndex = 16;
            this.GpbNuevo.TabStop = false;
            this.GpbNuevo.Text = "Nuevo Elemento";
            // 
            // GpbEliminado
            // 
            this.GpbEliminado.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbEliminado.Location = new System.Drawing.Point(681, 28);
            this.GpbEliminado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GpbEliminado.Name = "GpbEliminado";
            this.GpbEliminado.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GpbEliminado.Size = new System.Drawing.Size(259, 209);
            this.GpbEliminado.TabIndex = 17;
            this.GpbEliminado.TabStop = false;
            this.GpbEliminado.Text = "Elemento Eliminado";
            // 
            // GpbListadoGrilla
            // 
            this.GpbListadoGrilla.Controls.Add(this.LstPila);
            this.GpbListadoGrilla.Controls.Add(this.DgvPila);
            this.GpbListadoGrilla.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbListadoGrilla.Location = new System.Drawing.Point(44, 245);
            this.GpbListadoGrilla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GpbListadoGrilla.Name = "GpbListadoGrilla";
            this.GpbListadoGrilla.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GpbListadoGrilla.Size = new System.Drawing.Size(884, 277);
            this.GpbListadoGrilla.TabIndex = 18;
            this.GpbListadoGrilla.TabStop = false;
            this.GpbListadoGrilla.Text = "Listado en una Lista y una Grilla";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.cola_3;
            this.pictureBox1.Location = new System.Drawing.Point(95, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPila";
            this.Text = "frmPila";
            this.Load += new System.EventHandler(this.frmPila_Load);
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