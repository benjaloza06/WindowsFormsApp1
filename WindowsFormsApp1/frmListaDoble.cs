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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }


        ClsListaDoble objDoble = new ClsListaDoble(); //GLOBAL

        private void frmListaDoble_Load(object sender, EventArgs e)
        {
            BtnAgregar.Enabled = false;
        }
    

        private void ValidarDatos()
        {
            if (TxtCodigo.Text != "" && TxtNombre.Text != "" && TxtTramite.Text != "")
            {
                BtnAgregar.Enabled = true;
            }
            else
            {
                BtnAgregar.Enabled = false;
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
            if (CmbCodigo.Text != "")
            {
                BtnEliminar.Enabled = true;
            }
            else
            {
                BtnEliminar.Enabled = false;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ClsNodo x = new ClsNodo();
            x.Codigo = Convert.ToInt32(TxtCodigo.Text);
            x.Nombre = TxtNombre.Text;
            x.Tramite = TxtTramite.Text;

            objDoble.Agregar(x);
            objDoble.Recorrer(DgvPila);
            objDoble.Recorrer(CmbCodigo);
            objDoble.Recorrer(LstLista);

            TxtCodigo.Text = "";
            TxtNombre.Text = "";
            TxtTramite.Text = "";
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            if (objDoble.Primero != null)
            {
                Int32 x = Convert.ToInt32(CmbCodigo.Text);
                objDoble.Eliminar(x);
                objDoble.Recorrer(DgvPila);
                objDoble.Recorrer("ListaDoble.csv");
                objDoble.Recorrer(CmbCodigo);
                objDoble.Recorrer(LstLista);
            }
            else
            {
                MessageBox.Show("La lista esta vacia", "Lista sin datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BtnEliminar.Enabled = false;
        }

        private void RbtAscendente_CheckedChanged(object sender, EventArgs e)
        {
            ClsNodo x = new ClsNodo();
            objDoble.Recorrer(DgvPila);
            objDoble.Recorrer(LstLista);
            objDoble.Recorrer(CmbCodigo);
        }

        private void RbtDescendente_CheckedChanged(object sender, EventArgs e)
        {
            ClsNodo x = new ClsNodo();
            objDoble.RecorrerDesc(DgvPila);
            objDoble.RecorrerDesc(LstLista);
            objDoble.RecorrerDesc(CmbCodigo);
        }
    }
        
}
    

