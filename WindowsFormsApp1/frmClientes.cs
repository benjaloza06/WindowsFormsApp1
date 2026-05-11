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
   
        private void BtnGrabar_Click_1(object sender, EventArgs e)
        {
            ClsArchivo objRecorrer = new ClsArchivo();
            objRecorrer.NombreArc = "Clientes.csv";
            objRecorrer.Grabar(TxtCodigo.Text, TxtNombre.Text, TxtDeuda.Text);
            objRecorrer.Recorrer(DgvClientes);

        }

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            ClsArchivo x = new ClsArchivo();
            x.NombreArc = ("Clientes.csv");
            x.LimpiarTodo();
           
            TxtCodigo.Text = "";
            TxtNombre.Text = "";
            TxtDeuda.Text = "";

        }

        private void frmClientes_Load_1(object sender, EventArgs e)
        {
            ClsArchivo x = new ClsArchivo
            {
                NombreArc = "Clientes.csv"
            };
            if (File.Exists(x.NombreArc)) x.Recorrer(DgvClientes);
            BtnGrabar.Enabled = false;
        }
        private void ValidarDatos()
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
         private void TxtCodigo_TextChanged_1(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void TxtDeuda_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }
    }
}

