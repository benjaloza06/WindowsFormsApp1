using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }

        ClsListaSimple objPila = new ClsListaSimple();

        private void frmListaSimple_Load(object sender, EventArgs e)
        {
            ClsArchivo x = new ClsArchivo();
            x.NombreArc = "ListaSimple.csv";
            if (File.Exists(x.NombreArc)) x.Recorrer(DgvLista);
            BtnAgregar.Enabled = false;
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ClsNodo x = new ClsNodo();
            x.Codigo = Convert.ToInt32(TxtCodigo.Text);
            x.Nombre = TxtNombre.Text;
            x.Tramite = TxtTramite.Text;

            objPila.Agregar(x);
            objPila.Recorrer(DgvLista);
            objPila.Recorrer(CmbCodigo);
            objPila.Recorrer(LstLista);

            TxtCodigo.Text = "";
            TxtNombre.Text = "";
            TxtTramite.Text = "";
        }

        private void ValidarDatos()
        {
            if (TxtCodigo.Text != "" && TxtNombre.Text != "" && TxtTramite.Text != "")
            {
                BtnAgregar.Enabled = false;
            }
            else
            {
                BtnAgregar.Enabled = true;
            }
        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void TxtTramite_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void CmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}