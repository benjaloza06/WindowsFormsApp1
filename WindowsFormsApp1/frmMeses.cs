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
    public partial class FrmMeses : Form
    {
        public FrmMeses()
        {
            InitializeComponent();
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            ClsArchivo x = new ClsArchivo
            {
                NombreArc = ("Meses.csv")
            };
            x.Grabar(TxtMeses.Text);
            x.Recorrer(LstMeses);

            TxtMeses.Text = "";
        }

        private void FrmMeses_Load(object sender, EventArgs e)
        {
            BtnGrabar.Enabled = false;
        }

        private void TxtMeses_TextChanged(object sender, EventArgs e)
        {
            if (TxtMeses.Text == "")
            {
                BtnGrabar.Enabled = false;
            }
            else
            {
                BtnGrabar.Enabled = true;
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            ClsArchivo x = new ClsArchivo
            {
                NombreArc = ("Meses.csv")
            };
            x.LimpiarTodo();
            x.Recorrer(LstMeses);

            TxtMeses.Text = "";
        }

        private void BtnGrabar_Click_1(object sender, EventArgs e)
        {

        }
    }
}

