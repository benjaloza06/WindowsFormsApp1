namespace WindowsFormsApp1
{
    partial class frmGrafo
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
            this.GpbNuevo = new System.Windows.Forms.GroupBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtTramite = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblTramite = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.GpbEliminar = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbCodigo = new System.Windows.Forms.ComboBox();
            this.LblCodigoo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GpbNuevo.SuspendLayout();
            this.GpbEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.GpbNuevo.Location = new System.Drawing.Point(264, 27);
            this.GpbNuevo.Name = "GpbNuevo";
            this.GpbNuevo.Size = new System.Drawing.Size(197, 170);
            this.GpbNuevo.TabIndex = 49;
            this.GpbNuevo.TabStop = false;
            this.GpbNuevo.Text = "Nuevo Elemento";
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
            // 
            // TxtTramite
            // 
            this.TxtTramite.Location = new System.Drawing.Point(70, 84);
            this.TxtTramite.Name = "TxtTramite";
            this.TxtTramite.Size = new System.Drawing.Size(100, 23);
            this.TxtTramite.TabIndex = 43;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(70, 25);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(100, 23);
            this.TxtCodigo.TabIndex = 41;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(70, 55);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 23);
            this.TxtNombre.TabIndex = 42;
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
            // GpbEliminar
            // 
            this.GpbEliminar.Controls.Add(this.label5);
            this.GpbEliminar.Controls.Add(this.comboBox4);
            this.GpbEliminar.Controls.Add(this.label4);
            this.GpbEliminar.Controls.Add(this.label3);
            this.GpbEliminar.Controls.Add(this.CmbCodigo);
            this.GpbEliminar.Controls.Add(this.LblCodigoo);
            this.GpbEliminar.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbEliminar.Location = new System.Drawing.Point(484, 27);
            this.GpbEliminar.Name = "GpbEliminar";
            this.GpbEliminar.Size = new System.Drawing.Size(304, 170);
            this.GpbEliminar.TabIndex = 50;
            this.GpbEliminar.TabStop = false;
            this.GpbEliminar.Text = "Elemento a Eliminar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Destino:";
            // 
            // CmbCodigo
            // 
            this.CmbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCodigo.FormattingEnabled = true;
            this.CmbCodigo.Location = new System.Drawing.Point(67, 24);
            this.CmbCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.CmbCodigo.Name = "CmbCodigo";
            this.CmbCodigo.Size = new System.Drawing.Size(198, 24);
            this.CmbCodigo.TabIndex = 27;
            // 
            // LblCodigoo
            // 
            this.LblCodigoo.AutoSize = true;
            this.LblCodigoo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigoo.Location = new System.Drawing.Point(12, 28);
            this.LblCodigoo.Name = "LblCodigoo";
            this.LblCodigoo.Size = new System.Drawing.Size(48, 15);
            this.LblCodigoo.TabIndex = 26;
            this.LblCodigoo.Text = "Codigo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(31, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(90, 248);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 53;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 22);
            this.button1.TabIndex = 54;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "label2";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(458, 248);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 56;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(616, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 57;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(764, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 58;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(67, 60);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(198, 24);
            this.comboBox4.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "label5";
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 551);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GpbNuevo);
            this.Controls.Add(this.GpbEliminar);
            this.Name = "frmGrafo";
            this.Text = "frmGrafo";
            this.GpbNuevo.ResumeLayout(false);
            this.GpbNuevo.PerformLayout();
            this.GpbEliminar.ResumeLayout(false);
            this.GpbEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GpbNuevo;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox TxtTramite;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblTramite;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.GroupBox GpbEliminar;
        private System.Windows.Forms.ComboBox CmbCodigo;
        private System.Windows.Forms.Label LblCodigoo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}