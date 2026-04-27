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
    public partial class frmColas : Form
    {
        public frmColas()
        {
            InitializeComponent();
        }

        ClsCola ColaEspera = new ClsCola(); //GLOBAL
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ClsNodo Persona = new ClsNodo();
            Persona.Codigo = Convert.ToInt32(TxtCodigo.Text);
            Persona.Nombre = TxtNombre.Text;
            Persona.Tramite = TxtTramite.Text;

            ColaEspera.Agregar(Persona);
            ColaEspera.Recorrer(DgvColas);
            ColaEspera.Recorrer("Cola.csv");
            ColaEspera.Recorrer(LstListado);

            TxtCodigo.Text = "";
            TxtNombre.Text = "";
            TxtTramite.Text = "";
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (ColaEspera.Primero != null)
            {
                LblCodigoo.Text = ColaEspera.Primero.Codigo.ToString();
                LblNombree.Text = ColaEspera.Primero.Nombre;
                LblTramitee.Text = ColaEspera.Primero.Tramite;

                ColaEspera.Eliminar();
                ColaEspera.Recorrer(DgvColas);
                ColaEspera.Recorrer("Cola.csv");
                ColaEspera.Recorrer(LstListado);
            }
            else 
            {
                LblCodigo.Text = "";
                LblNombre.Text = "";
                LblTramite.Text = "";

            }
        }

        private void frmColas_Load(object sender, EventArgs e)
        {

        }
    }
}

