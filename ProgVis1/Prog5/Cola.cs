using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog5
{
    public class Cola
    {
        Nodo cp;
        public Cola() { cp = new Nodo(); }

        public void Encolar(string pId)
        {
            Nodo dondeEncolo = null;

            if (cp.Siguiente==null)
            {
                dondeEncolo = cp;
            }
            else
            {
                dondeEncolo = BuscarUltimo();
            }

            dondeEncolo.Siguiente = new Nodo(pId);
        }

        public Nodo Desencolar() 
        {
            Nodo aux = null;

            if (cp.Siguiente!=null)
            {
                aux= cp.Siguiente;

                cp.Siguiente = aux.Siguiente;

                aux.Siguiente = null;
            }
            return aux;
        }

        public Nodo Ver()
        {
            Nodo aux = null;

            if (cp.Siguiente!=null)
            {
                aux = new Nodo(cp.Siguiente.Id);
            }
            return aux;
        }

        private Nodo BuscarUltimo()
        {
            Nodo aux= null;
            if(cp.Siguiente!=null) aux = RecursivaBuscarUltimo(cp.Siguiente);
            return aux; 
        }

        private Nodo RecursivaBuscarUltimo(Nodo pNodo)
        {
            Nodo v = pNodo;

            if (pNodo.Siguiente != null) v = RecursivaBuscarUltimo(pNodo.Siguiente);

            return v;
        }      
    }
}
