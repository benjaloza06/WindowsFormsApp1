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
            BtnEliminar.Enabled = false;
            BtnAgregar.Enabled = false;
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ClsNodo x = new ClsNodo();
            x.Codigo = Convert.ToInt32(TxtCodigo.Text);
            x.Nombre = TxtNombre.Text;
            x.Tramite = TxtTramite.Text;

            objPila.Agregar(x);
            objPila.Recorrer(DgvSimple);
            objPila.Recorrer("ListaSimple.csv");
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            if (CmbCodigo.SelectedIndex != -1)
            {
                if (objPila.Primero != null)
                {
                    Int32 x = Convert.ToInt32(CmbCodigo.Text);
                    objPila.Eliminar(x);
                    objPila.Recorrer(DgvSimple);
                    objPila.Recorrer("ListaSimple.csv");
                    objPila.Recorrer(LstLista);
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

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
             // Solo permite números (char.IsDigit) y la tecla de borrar (char.IsControl)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea cualquier otro caracter
            }
        }

        private void CmbCodigo_SelectedIndexChanged_1(object sender, EventArgs e)
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
    }
    
}

