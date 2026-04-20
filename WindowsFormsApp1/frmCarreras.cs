using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmCarreras : Form
    {
        public FrmCarreras()
        {
            InitializeComponent();
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            ClsArchivo x = new ClsArchivo
            {
                NombreArc = ("Carreras.csv")
            };
            x.Grabar(TxtCarreras.Text);
            x.Recorrer(LstCarreras);

            TxtCarreras.Text = "";
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            ClsArchivo x = new ClsArchivo
            {
                NombreArc = ("Carreras.csv")
            };
            x.LimpiarTodo();
            x.Recorrer(LstCarreras);

            TxtCarreras.Text = "";
        }

        private void TxtCarreras_TextChanged(object sender, EventArgs e)
        {
            if (TxtCarreras.Text == "")
            {
                BtnGrabar.Enabled = false;
            }
            else
            {
                BtnGrabar.Enabled = true;
            }
        }

        private void FrmCarreras_Load(object sender, EventArgs e)
        {
            BtnGrabar.Enabled = false;
        }

        private void LstCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
