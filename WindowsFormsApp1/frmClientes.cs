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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            ClsArchivo objRecorrer = new ClsArchivo
            {
                NombreArc = "Clientes.csv"
            };
            objRecorrer.Grabar(TxtCodigo.Text, TxtNombre.Text, TxtDeuda.Text);
            objRecorrer.Recorrer(DgvClientes);

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            ClsArchivo x = new ClsArchivo
            {
                NombreArc = "Clientes.csv"
            };
            if (File.Exists(x.NombreArc)) x.Recorrer(DgvClientes);
            BtnGrabar.Enabled = false;
        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (TxtCodigo.Text != "" && TxtNombre.Text != "" && TxtDeuda.Text != "")
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
                NombreArc = ("Clientes.csv")
            };
            x.LimpiarTodo();
            //x.Recorrer();

            TxtCodigo.Text = "";
            TxtNombre.Text = "";
            TxtDeuda.Text = "";
        }
    }
}

