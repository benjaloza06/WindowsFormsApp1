using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    internal class ClsArbolBinario
    {
        
        //Creo el campo inicial del arbol
        private ClsNodo PriNodo;

        //Creo la unica propiedad del arbol
        public ClsNodo PrimerNodo
        {
            get { return PriNodo; }
            set { PriNodo = value; }
        }

        public void Agregar(ClsNodo Nvo)
        {
            if (PriNodo == null)
            {
                PriNodo = Nvo;
            }
            else
            {
                ClsNodo P = PriNodo; //Ant
                ClsNodo Aux = PriNodo; //Sig
                while (Aux != null)
                {
                    P = Aux;
                    if (Nvo.Codigo < Aux.Codigo) Aux = Aux.Izquierdo;
                    else Aux = Aux.Derecho;
                }
                //Afuera del while
                if (Nvo.Codigo < P.Codigo) P.Izquierdo = Nvo;
                else P.Derecho = Nvo;
            }
        }

        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, PrimerNodo);
        }

        public void InOrdenAsc(DataGridView Grilla, ClsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Grilla, R.Izquierdo);
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrdenAsc(Grilla, R.Derecho);
        }

        public void Recorrer(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, PrimerNodo);
        }

        public void InOrdenAsc(ComboBox Lista, ClsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Lista, R.Izquierdo);
            Lista.Items.Add(R.Nombre);
            if (R.Derecho != null) InOrdenAsc(Lista, R.Derecho);
        }

        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode nodo = new TreeNode("Árbol");
            tree.Nodes.Add(nodo);
            PreOrden(PrimerNodo, nodo);
            tree.ExpandAll();

        }

        //Que esto se pase a un treeview

        private void PreOrden(ClsNodo R, TreeNode nodoTreeView)
        {
            TreeNode nodo = new TreeNode(R.Codigo.ToString());
            nodoTreeView.Nodes.Add(nodo);
            if (R.Izquierdo != null) PreOrden(R.Izquierdo, nodo);
            if (R.Derecho != null) PreOrden(R.Derecho, nodo);
        }
    }
}

        
