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

        private void LblCodigoo_Click(object sender, EventArgs e)
        {

        }

        private void frmPila_Load(object sender, EventArgs e)
        {

        }

        private void DgvPila_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ClsNodo x = new ClsNodo();
            x.Codigo = Convert.ToInt32(TxtCodigo.Text);
            x.Nombre = TxtNombre.Text;
            x.Tramite = TxtTramite.Text;

            objPila.Agregar(x);
            objPila.Recorrer(DgvPila);
            objPila.Recorrer(LstPila);
            objPila.Recorrer("Pila.csv");

            TxtCodigo.Text = "";
            TxtNombre.Text = "";
            TxtTramite.Text = "";
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (objPila.Primero != null)
            {
                LblCo.Text = objPila.Primero.Codigo.ToString();
                LblNom.Text = objPila.Primero.Nombre;
                LblTram.Text = objPila.Primero.Tramite;

                objPila.Eliminar();
                objPila.Recorrer(DgvPila);
                objPila.Recorrer(LstPila);
                objPila.Recorrer("Pila.csv");
            }
            else
            {
                LblCodigo.Text = "";
                LblNombre.Text = "";
                LblTramite.Text = "";
            }
        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
