using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
