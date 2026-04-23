using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    internal class ClsCola
    {
        //Campos de la clase 
        private ClsNodo Pri;
        private ClsNodo Ult;

        //Propiedades de la clase 
        public ClsNodo Primero
        {
            get { return Pri; }
            set { Pri = value; }
        }
        public ClsNodo Ultimo
        {
            get { return Ult; }
            set { Ult = value; }
        }

        //Metodos de la clase
        public void Agregar(ClsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ult = Nuevo;
            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Ultimo = Nuevo;
            }
        }


        public void Eliminar()
        {
            if (Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                Primero = Primero.Siguiente;
            }
        }


        public void Recorrer(DataGridView Grilla)
        {
            ClsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }

        }

        public void Recorrer(ListBox Lista)
        {
            ClsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            ClsNodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }
        }  

        public void Recorrer(String NombreArchivo)
        {
            ClsNodo aux = Primero;
            StreamWriter AD = new StreamWriter(NombreArchivo, false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            while (aux != null)
            {
                AD.WriteLine(aux.Codigo);
                AD.Write(";");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.WriteLine(aux.Tramite);
                aux = aux.Siguiente;
            }
            AD.Close();
        }


    }
}




    

