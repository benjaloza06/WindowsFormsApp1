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
    public partial class frmOperacionesBd : Form
    {
        public frmOperacionesBd()
        {
            InitializeComponent();
        }

        ClsBaseDatos objDatos = new ClsBaseDatos();

        private void BtnProSimple_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO, AÑO " +
                "FROM LIBRO " +
                "ORDER BY 1 DESC";
            objDatos.Listar(DgvOperaciones, varSQL);
        }

        private void BtnProMultiatributo_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO, AÑO " +
                "FROM LIBRO " +
                "ORDER BY TITULO ASC";
            objDatos.Listar(DgvOperaciones, varSQL);

        }

        private void BtnJuntar_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO , NOMBRE " +
                "from LIBRO inner join PAIS " +
                "on LIBRO.IDPAIS = PAIS.IDPAIS";

            objDatos.Listar(DgvOperaciones, varSQL);
        }

        private void BtnSelecConvolucion_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * " +
                "FROM (select * from libro where idIdioma > 1) as  X" +
                "WHERE IDPAIS = 2 ";
            objDatos.Listar(DgvOperaciones, varSQL);
        }

        private void BtnDif_Click(object sender, EventArgs e)
        {
            
        }
    }
}
