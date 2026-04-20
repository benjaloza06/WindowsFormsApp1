using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmAlumnos : Form
    {
        public FrmAlumnos()
        {
            InitializeComponent();
        }

        private void FrmAlumnos_Load(object sender, EventArgs e)
        {
            ClsArchivo objGrabar = new ClsArchivo
            {
                NombreArc = "Carreras.csv"
            };
            objGrabar.Recorrer(CmbCarrera);

            ClsArchivo objAlumnos = new ClsArchivo();
            if (File.Exists(objAlumnos.NombreArc)) objAlumnos.Recorrer(DgvAlumnos);
            BtnGrabar.Enabled = false;

        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (TxtCodigo.Text != "" && TxtNombre.Text != "" && CmbCarrera.Text != "")
            {
                BtnGrabar.Enabled = false;
            }
            else
            {
                BtnGrabar.Enabled = true;
            }
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            ClsArchivo objRecorrer = new ClsArchivo
            {
                NombreArc = "Alumnos.csv"
            };
            objRecorrer.Grabar(TxtCodigo.Text, TxtNombre.Text, CmbCarrera.Text);
            objRecorrer.Recorrer(DgvAlumnos);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            ClsArchivo x = new ClsArchivo
            {
                NombreArc = ("Alumnos.csv")
            };
            x.LimpiarTodo();

            TxtCodigo.Text = "";
            TxtNombre.Text = "";
            CmbCarrera.Text = "";
        }
    }
}

