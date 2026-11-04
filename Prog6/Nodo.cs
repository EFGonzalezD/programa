using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog6
{
    public class Nodo
    {
        public Nodo(string pId="", Nodo pSiguiente = null)
        {
            Id = pId;
            Siguiente = pSiguiente;
        }

        public string Id { get; set; }
        public Nodo Siguiente { get; set; }

    }
}
