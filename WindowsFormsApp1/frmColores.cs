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
    public partial class frmColores : Form
    {
        public frmColores()
        {
            InitializeComponent();
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            ClsArchivo x = new ClsArchivo
            {
                NombreArc = ("Colores.csv")
            };
            x.Grabar(TxtColores.Text);
            x.Recorrer(LstColores);

            TxtColores.Text = "";
        }

        private void TxtColores_TextChanged(object sender, EventArgs e)
        {
            if (TxtColores.Text == "")
            {
                BtnGrabar.Enabled = false;
            }
            else
            {
                BtnGrabar.Enabled = true;
            }
        }

        private void FrmColores_Load(object sender, EventArgs e)
        {
            BtnGrabar.Enabled = false;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            ClsArchivo x = new ClsArchivo
            {
                NombreArc = ("Careras.csv")
            };
            x.LimpiarTodo();
            x.Recorrer(LstColores);

            TxtColores.Text = "";
        }
    }
}
