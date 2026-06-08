namespace WindowsFormsApp1
{
    partial class frmOperacionesBd
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
            this.DgvOperaciones = new System.Windows.Forms.DataGridView();
            this.BtnProSimple = new System.Windows.Forms.Button();
            this.BtnProMultiatributo = new System.Windows.Forms.Button();
            this.BtnJuntar = new System.Windows.Forms.Button();
            this.BtnSelecSimple = new System.Windows.Forms.Button();
            this.BtnSelecMultiatributo = new System.Windows.Forms.Button();
            this.BtnSelecConvolucion = new System.Windows.Forms.Button();
            this.BtnUnion = new System.Windows.Forms.Button();
            this.BtnInterseccion = new System.Windows.Forms.Button();
            this.BtnDif = new System.Windows.Forms.Button();
            this.GpbOpeProyeccion = new System.Windows.Forms.GroupBox();
            this.GpbOpeSeleccion = new System.Windows.Forms.GroupBox();
            this.GpbOpeAlgebraicas = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOperaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvOperaciones
            // 
            this.DgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOperaciones.Location = new System.Drawing.Point(13, 13);
            this.DgvOperaciones.Name = "DgvOperaciones";
            this.DgvOperaciones.Size = new System.Drawing.Size(932, 449);
            this.DgvOperaciones.TabIndex = 0;
            // 
            // BtnProSimple
            // 
            this.BtnProSimple.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProSimple.Location = new System.Drawing.Point(24, 503);
            this.BtnProSimple.Name = "BtnProSimple";
            this.BtnProSimple.Size = new System.Drawing.Size(202, 23);
            this.BtnProSimple.TabIndex = 2;
            this.BtnProSimple.Text = "Proyeccion simple ";
            this.BtnProSimple.UseVisualStyleBackColor = true;
            this.BtnProSimple.Click += new System.EventHandler(this.BtnProSimple_Click);
            // 
            // BtnProMultiatributo
            // 
            this.BtnProMultiatributo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProMultiatributo.Location = new System.Drawing.Point(24, 542);
            this.BtnProMultiatributo.Name = "BtnProMultiatributo";
            this.BtnProMultiatributo.Size = new System.Drawing.Size(202, 23);
            this.BtnProMultiatributo.TabIndex = 3;
            this.BtnProMultiatributo.Text = "Proyeccion multiatributo";
            this.BtnProMultiatributo.UseVisualStyleBackColor = true;
            this.BtnProMultiatributo.Click += new System.EventHandler(this.BtnProMultiatributo_Click);
            // 
            // BtnJuntar
            // 
            this.BtnJuntar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJuntar.Location = new System.Drawing.Point(24, 574);
            this.BtnJuntar.Name = "BtnJuntar";
            this.BtnJuntar.Size = new System.Drawing.Size(202, 23);
            this.BtnJuntar.TabIndex = 4;
            this.BtnJuntar.Text = "Juntar";
            this.BtnJuntar.UseVisualStyleBackColor = true;
            this.BtnJuntar.Click += new System.EventHandler(this.BtnJuntar_Click);
            // 
            // BtnSelecSimple
            // 
            this.BtnSelecSimple.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelecSimple.Location = new System.Drawing.Point(375, 503);
            this.BtnSelecSimple.Name = "BtnSelecSimple";
            this.BtnSelecSimple.Size = new System.Drawing.Size(202, 23);
            this.BtnSelecSimple.TabIndex = 6;
            this.BtnSelecSimple.Text = "Seleccion simple ";
            this.BtnSelecSimple.UseVisualStyleBackColor = true;
            // 
            // BtnSelecMultiatributo
            // 
            this.BtnSelecMultiatributo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelecMultiatributo.Location = new System.Drawing.Point(375, 542);
            this.BtnSelecMultiatributo.Name = "BtnSelecMultiatributo";
            this.BtnSelecMultiatributo.Size = new System.Drawing.Size(202, 23);
            this.BtnSelecMultiatributo.TabIndex = 7;
            this.BtnSelecMultiatributo.Text = "Seleccion multiatributo";
            this.BtnSelecMultiatributo.UseVisualStyleBackColor = true;
            // 
            // BtnSelecConvolucion
            // 
            this.BtnSelecConvolucion.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelecConvolucion.Location = new System.Drawing.Point(375, 574);
            this.BtnSelecConvolucion.Name = "BtnSelecConvolucion";
            this.BtnSelecConvolucion.Size = new System.Drawing.Size(202, 23);
            this.BtnSelecConvolucion.TabIndex = 8;
            this.BtnSelecConvolucion.Text = "Seleccion por convolucion";
            this.BtnSelecConvolucion.UseVisualStyleBackColor = true;
            this.BtnSelecConvolucion.Click += new System.EventHandler(this.BtnSelecConvolucion_Click);
            // 
            // BtnUnion
            // 
            this.BtnUnion.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUnion.Location = new System.Drawing.Point(715, 503);
            this.BtnUnion.Name = "BtnUnion";
            this.BtnUnion.Size = new System.Drawing.Size(202, 23);
            this.BtnUnion.TabIndex = 10;
            this.BtnUnion.Text = "Union";
            this.BtnUnion.UseVisualStyleBackColor = true;
            this.BtnUnion.Click += new System.EventHandler(this.BtnUnion_Click);
            // 
            // BtnInterseccion
            // 
            this.BtnInterseccion.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInterseccion.Location = new System.Drawing.Point(715, 542);
            this.BtnInterseccion.Name = "BtnInterseccion";
            this.BtnInterseccion.Size = new System.Drawing.Size(202, 23);
            this.BtnInterseccion.TabIndex = 11;
            this.BtnInterseccion.Text = "Intersección";
            this.BtnInterseccion.UseVisualStyleBackColor = true;
            this.BtnInterseccion.Click += new System.EventHandler(this.BtnInterseccion_Click);
            // 
            // BtnDif
            // 
            this.BtnDif.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDif.Location = new System.Drawing.Point(715, 574);
            this.BtnDif.Name = "BtnDif";
            this.BtnDif.Size = new System.Drawing.Size(202, 23);
            this.BtnDif.TabIndex = 12;
            this.BtnDif.Text = "Diferencia ";
            this.BtnDif.UseVisualStyleBackColor = true;
            this.BtnDif.Click += new System.EventHandler(this.BtnDif_Click);
            // 
            // GpbOpeProyeccion
            // 
            this.GpbOpeProyeccion.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbOpeProyeccion.Location = new System.Drawing.Point(12, 481);
            this.GpbOpeProyeccion.Name = "GpbOpeProyeccion";
            this.GpbOpeProyeccion.Size = new System.Drawing.Size(224, 134);
            this.GpbOpeProyeccion.TabIndex = 13;
            this.GpbOpeProyeccion.TabStop = false;
            this.GpbOpeProyeccion.Text = "Operaciones de Proyección - SELECT";
            // 
            // GpbOpeSeleccion
            // 
            this.GpbOpeSeleccion.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbOpeSeleccion.Location = new System.Drawing.Point(365, 481);
            this.GpbOpeSeleccion.Name = "GpbOpeSeleccion";
            this.GpbOpeSeleccion.Size = new System.Drawing.Size(223, 134);
            this.GpbOpeSeleccion.TabIndex = 14;
            this.GpbOpeSeleccion.TabStop = false;
            this.GpbOpeSeleccion.Text = "Operaciones de Selección - WHERE";
            // 
            // GpbOpeAlgebraicas
            // 
            this.GpbOpeAlgebraicas.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbOpeAlgebraicas.Location = new System.Drawing.Point(704, 481);
            this.GpbOpeAlgebraicas.Name = "GpbOpeAlgebraicas";
            this.GpbOpeAlgebraicas.Size = new System.Drawing.Size(223, 134);
            this.GpbOpeAlgebraicas.TabIndex = 15;
            this.GpbOpeAlgebraicas.TabStop = false;
            this.GpbOpeAlgebraicas.Text = "Operaciones Algebraicas";
            // 
            // frmOperacionesBd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 635);
            this.Controls.Add(this.BtnDif);
            this.Controls.Add(this.BtnInterseccion);
            this.Controls.Add(this.BtnUnion);
            this.Controls.Add(this.BtnSelecConvolucion);
            this.Controls.Add(this.BtnSelecMultiatributo);
            this.Controls.Add(this.BtnSelecSimple);
            this.Controls.Add(this.BtnJuntar);
            this.Controls.Add(this.BtnProMultiatributo);
            this.Controls.Add(this.BtnProSimple);
            this.Controls.Add(this.DgvOperaciones);
            this.Controls.Add(this.GpbOpeProyeccion);
            this.Controls.Add(this.GpbOpeSeleccion);
            this.Controls.Add(this.GpbOpeAlgebraicas);
            this.Name = "frmOperacionesBd";
            this.Text = "frmOperacionesBd";
            ((System.ComponentModel.ISupportInitialize)(this.DgvOperaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvOperaciones;
        private System.Windows.Forms.Button BtnProSimple;
        private System.Windows.Forms.Button BtnProMultiatributo;
        private System.Windows.Forms.Button BtnJuntar;
        private System.Windows.Forms.Button BtnSelecSimple;
        private System.Windows.Forms.Button BtnSelecMultiatributo;
        private System.Windows.Forms.Button BtnSelecConvolucion;
        private System.Windows.Forms.Button BtnUnion;
        private System.Windows.Forms.Button BtnInterseccion;
        private System.Windows.Forms.Button BtnDif;
        private System.Windows.Forms.GroupBox GpbOpeProyeccion;
        private System.Windows.Forms.GroupBox GpbOpeSeleccion;
        private System.Windows.Forms.GroupBox GpbOpeAlgebraicas;
    }
}