using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class ClsNodo
    {
        //Campos del nodo
        private Int32 Cod;
        private string Nom;
        private string Tra;
        private ClsNodo Sig;

        
        public Int32 Codigo
        {
            get { return Cod; }
            set { Cod = value; }
        }

        public string Nombre
        {
            get { return Nom; }
            set { Nom = value; }
        }

        public string Tramite
        {
            get { return Tra; }
            set { Tra = value; }
        }

        public ClsNodo Siguiente
        {
            get { return Sig; }
            set { Sig = value; }
        }
    }






}
 