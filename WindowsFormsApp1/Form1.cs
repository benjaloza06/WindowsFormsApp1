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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DatosDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDesarrollador vent = new frmDatosDesarrollador();
            vent.ShowDialog();
        }

        private void SalirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMeses ven = new FrmMeses();
            ven.ShowDialog();
        }

        private void ColoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColores ven = new frmColores();
            ven.ShowDialog();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes ven = new frmClientes();
            ven.ShowDialog();
        }

        private void AlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlumnos ven = new FrmAlumnos();
            ven.ShowDialog();

        }

        private void CarrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCarreras ven = new FrmCarreras();
            ven.ShowDialog();
        }

        private void ColaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void colaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmColas ven = new frmColas();
            ven.ShowDialog();

        }
    }
}

