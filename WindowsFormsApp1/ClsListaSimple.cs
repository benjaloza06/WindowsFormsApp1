using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class ClsListaSimple
    {
        //Campos de la clase 
        private ClsNodo Pri;

        //Propiedades de la clase 
        public ClsNodo Primero
        {
            get { return Pri; }
            set { Pri = value; }
        }


        //Metodos de la clase: Agregar, Eliminar y Recorrer
        public void Agregar(ClsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;

            }
            else
            {
                if (Nuevo.Codigo < Primero.Codigo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero = Nuevo;
                }
                else
                {
                    ClsNodo Aux = Primero;
                    ClsNodo Ant = Aux;
                    while (Aux.Codigo < Nuevo.Codigo)
                    {
                        Ant = Aux;
                        Aux = Aux.Siguiente;
                        if (Aux == null) break;
                    }
                    Ant.Siguiente = Nuevo;
                    Nuevo.Siguiente = Aux;
                }
            }
        }

        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo)
            {
                Primero = Primero.Siguiente;
            }
            else
            {
                ClsNodo aux1 = Primero;
                ClsNodo aux2 = Primero;
                while (aux1.Codigo != Codigo)
                {
                    aux2 = aux1;
                    aux1 = aux1.Siguiente;
                }
                aux2.Siguiente = aux1.Siguiente;
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

        public void Recorrer(ComboBox Lista)
        {
            ClsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo);
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
