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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        ClsPila objPila = new ClsPila();

        private void frmPila_Load(object sender, EventArgs e)
        {
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
            objPila.Recorrer(LstPila);
            objPila.Recorrer("Pila.csv");

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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (objPila.Primero != null)
            {
                LblCo.Text = objPila.Primero.Codigo.ToString();
                LblNom.Text = objPila.Primero.Nombre;
                LblTram.Text = objPila.Primero.Tramite;

                objPila.Eliminar();
                objPila.Recorrer(DgvLista);
                objPila.Recorrer(LstPila);
                objPila.Recorrer("Pila.csv");
            }
            else
            {
                LblCo.Text = "";
                LblNom.Text = "";
                LblTram.Text = "";
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
    }
}
 

