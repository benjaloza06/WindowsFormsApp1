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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }

        ClsArbolBinario objPila = new ClsArbolBinario();

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ClsNodo x = new ClsNodo();
            x.Codigo = Convert.ToInt32(TxtCodigo.Text);
            x.Nombre = TxtNombre.Text;
            x.Tramite = TxtTramite.Text;

            objPila.Agregar(x);
            objPila.Recorrer(DgvArbol);
            objPila.Recorrer(CmbCodigo);
            objPila.Recorrer(TvwArbol);

            TxtCodigo.Text = "";
            TxtNombre.Text = "";
            TxtTramite.Text = "";
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

        private void frmArbolBinario_Load(object sender, EventArgs e)
        {
            BtnEliminar.Enabled = false;
            BtnAgregar.Enabled = false;
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

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            if (CmbCodigo.SelectedIndex != -1)
            {
                if (objPila.PrimerNodo != null)
                {
                    Int32 x = Convert.ToInt32(CmbCodigo.Text);

                    objPila.Recorrer(DgvArbol);

                    objPila.Recorrer(CmbCodigo);

                }
                else
                {
                    MessageBox.Show("La lista esta vacia", "Lista sin datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                BtnEliminar.Enabled = false;
            }
        }
    }
}

        
    

