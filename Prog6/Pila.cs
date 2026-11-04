using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog6
{
    public class Pila
    {
        Nodo cp;
        public Pila() { cp = new Nodo(); }

        public void Apilar(string pId)
        {
            Nodo aQuienApunto = null;

            if (cp.Siguiente!=null) { aQuienApunto = cp.Siguiente; }

            cp.Siguiente =new Nodo(pId, aQuienApunto);

        }

        public Nodo Desapilar() 
        {
            Nodo aux = null;
            if (cp.Siguiente != null) 
            {
                aux = cp.Siguiente;

                cp.Siguiente =aux.Siguiente;

                aux.Siguiente =null;
            }

            return aux;
        }

        public Nodo Ver() 
        {
            Nodo aux = null;

            if (cp.Siguiente != null)
            {
                aux = new Nodo(cp.Siguiente.Id);
            }

            return aux;
        }




    }
}
