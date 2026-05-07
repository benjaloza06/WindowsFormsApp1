using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class ClsListaDoble
    {
        private ClsNodo pri;
        private ClsNodo ult;

        public ClsNodo Primero
        {
            get { return pri; }
            set { pri = value; }

        }

        public ClsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void Agregar(ClsNodo Nvo)
        {
            if (Primero == null)
            {
                Primero = Nvo;
                Ultimo = Nvo;
            }
            else
            {
                if (Nvo.Codigo < Primero.Codigo)
                {
                    Nvo.Siguiente = Primero;
                    Primero.Anterior = Nvo;
                    Primero = Nvo;
                }
                else
                {
                    if (Nvo.Codigo > Ultimo.Codigo)
                    {
                        Ultimo.Siguiente = Nvo;
                        Nvo.Anterior = Ultimo;
                        Ultimo = Nvo;
                    }
                    else
                    {
                        ClsNodo Aux = Primero;
                        ClsNodo Ant = Primero;
                        while (Aux.Codigo < Nvo.Codigo)
                        {
                            Ant = Aux;
                            Aux = Aux.Siguiente;
                        }
                        Ant.Siguiente = Nvo;
                        Nvo.Siguiente = Aux;
                        Aux.Anterior = Nvo;
                        Nvo.Siguiente = Ant;

                    }
                }
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

        public void RecorrerDesc(DataGridView Grilla)
        {
            ClsNodo aux = Ultimo;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Anterior;
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

        public void RecorrerDesc(ListBox Lista)
        {
            ClsNodo aux = Ultimo;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo);
                aux = aux.Anterior;
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

        public void RecorrerDesc(ComboBox Lista)
        {
            ClsNodo aux = Ultimo;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo);
                aux = aux.Anterior;
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

        public void RecorrerDesc(String NombreArchivo)
        {
            ClsNodo aux = Ultimo;
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
                aux = aux.Anterior;
            }
            AD.Close();
        }


        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                if (Primero.Codigo == Codigo)
                {
                    Primero = Primero.Siguiente;
                    Primero.Anterior = null;
                }
                else
                {
                    if (Ultimo.Codigo == Codigo)
                    {
                        Ultimo = Ultimo.Anterior;
                        Ultimo.Siguiente = null;
                    }
                    else
                    {
                        ClsNodo Aux = Primero;
                        ClsNodo Ant = Primero;
                        while (Aux.Codigo < Codigo)
                        {
                            Ant = Aux;
                            Aux = Aux.Siguiente;
                        }
                        Aux = Aux.Siguiente;
                        Ant.Siguiente = Aux;
                        Aux.Anterior = Ant;
                    }
                }
            }
        }


    }
}

    



        
    

