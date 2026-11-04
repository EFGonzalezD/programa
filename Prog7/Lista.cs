using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog7
{
    public class Lista
    {
        Auto NCP;

        public Lista()
        {
            NCP = new Auto();
        }

        public Auto PrimerAuto()
        {
            Auto aux = NCP.Siguiente;

            if (aux != null)
            {
                aux = new Auto(aux.Patente, aux.Marca, aux.Modelo);
            }
            return aux;
        }

        public void InsertarPrincipío(string pPatente = "", string pMarca = "", string pModelo = "")
        {
            Auto n = new Auto(pPatente, pMarca, pModelo);
            if (NCP.Siguiente != null)
            {
                n.Siguiente = NCP.Siguiente;
            }
            NCP.Siguiente = n;
        }

        public void InsertarFinal(string pPatente = "", string pMarca = "", string pModelo = "")
        {
            Auto aux = null;
            if (NCP.Siguiente == null) 
            {
                aux = NCP;
            }

            else
            {
                aux = BuscarUltimo();
            }

            aux.Siguiente = new Auto (pPatente, pMarca, pModelo);
        }

        public void InsertarEnPosicionN(int pos, string pPatente, string pModelo, string pMarca)
        {
            if (pos <= 0 || pos > Cantidad() + 1)
            {
                MessageBox.Show("La posición ingresada no es valida, ingresar posición valida");
            }
            if (NCP.Siguiente != null) 
            {
                Auto aux = null;
                if (pos <= Cantidad() + 1 && pos >0) 
                {
                    if (pos == 1)
                    {
                        aux = new Auto (pPatente, pMarca, pModelo);
                        aux.Siguiente = NCP.Siguiente;
                        NCP.Siguiente = aux;
                    }

                    else if (pos == Cantidad() + 1)
                    {
                        aux = BuscarUltimo ();
                        aux.Siguiente = new Auto(pPatente, pMarca, pModelo);
                    }
                    else
                    {
                        aux = new Auto(pPatente, pMarca, pModelo);
                        Auto auxAutoAnterior = RetornaAutoPosN (pos - 1);
                        Auto auxAutoPos = RetornaAutoPosN(pos);
                        auxAutoAnterior.Siguiente = aux;
                        aux.Siguiente= auxAutoPos;
                    }
                }
            }
        }

        public void BorrarAutoPosN(int pPosicion)
        {
            if (NCP.Siguiente != null)
            {
                if (pPosicion <= Cantidad() && pPosicion > 0)
                {
                    if (pPosicion == 1)
                    {
                        NCP.Siguiente = NCP.Siguiente.Siguiente;
                    }

                    else if (pPosicion == Cantidad())
                    {
                        Auto aux =RetornaAutoPosN(pPosicion - 1);
                        aux.Siguiente = null;
                    }

                    else
                    {
                        Auto auxAutoAnterior = RetornaAutoPosN(pPosicion - 1);
                        Auto auxAutoPosterior = RetornaAutoPosN(pPosicion + 1);
                        auxAutoAnterior.Siguiente = auxAutoPosterior;
                    }
                }
            }
        }

        public void Swap(int pos1, int pos2)
        {
            if ((pos1 > 0 && pos1 <= Cantidad()) && (pos2 > 0 && pos2 <= Cantidad()) && (pos1 != pos2))
            {
                if (pos1 > pos2) { var Aux = pos2; pos2 = pos1; pos1 = Aux; }
                if (pos1 == 1 && pos2 <= Cantidad())
                {
                    Auto antPos1, antPos2, aux1, aux2, postPos1, postPos2;
                    antPos1 = NCP;
                    antPos2 = RetornaAutoPosN(pos2 - 1);
                    postPos1 = RetornaAutoPosN(pos1 + 1);
                    if (pos2 == Cantidad()) { postPos2 = null; }
                    else { postPos2 = RetornaAutoPosN(pos2 + 1); }

                    aux1 = RetornaAutoPosN(pos1); aux2 = RetornaAutoPosN(pos2);
                    if (pos2 == 2 ) { antPos1.Siguiente = postPos1; aux2.Siguiente = aux1; }
                    else
                    {
                        antPos1.Siguiente = aux2;
                        antPos2.Siguiente = aux1;
                        aux2.Siguiente=postPos1;
                    }

                    aux1.Siguiente=postPos2;
                }
                else if ((pos1 > 1 && pos1 < Cantidad()) && pos2 == Cantidad())
                {
                    Auto antPos1, antPos2, aux1, aux2, postPos1, postPos2;
                    antPos1 = RetornaAutoPosN(pos1 - 1);
                    antPos2 = RetornaAutoPosN(pos2 - 1);
                    postPos1 = RetornaAutoPosN(pos1 + 1);
                    postPos2 = null;
                    aux1 = RetornaAutoPosN(pos1); aux2 = RetornaAutoPosN(pos2);
                    var q = Cantidad();
                    antPos1.Siguiente = aux2;
                    if (pos1==(q-1)) aux2.Siguiente = aux1;
                    else
                    {
                        aux2.Siguiente = postPos1;
                        antPos2.Siguiente = aux1;
                    }

                    aux1.Siguiente = null;
                }

                else if (pos1 > 1 && pos2 < Cantidad())
                {
                    Auto antPos1, antPos2, aux1, aux2, postPos1, postPos2;
                    antPos1 = RetornaAutoPosN(pos1 - 1);
                    antPos2 = RetornaAutoPosN(pos2 - 1);
                    postPos1 = RetornaAutoPosN(pos1 + 1);
                    postPos2 = RetornaAutoPosN(pos2 + 1);

                    aux1 = RetornaAutoPosN(pos1); aux2 = RetornaAutoPosN(pos2);

                    antPos1.Siguiente = aux2;
                    if (pos2 == pos1 + 1) aux2.Siguiente = aux1;
                    else
                    {
                        aux2.Siguiente = postPos1;
                        antPos2.Siguiente = aux1;
                    }

                    aux1.Siguiente = postPos2;
                }
            }
            else { MessageBox.Show("Inserte posicion valida"); }
        }

        public int Cantidad()
        {
            int aux = 0;
            if (NCP.Siguiente != null)
            {
                aux = CantidadRecursiva(NCP.Siguiente);
            }
            return aux;
        }

        private int CantidadRecursiva(Auto pAuto)
        {
            int q = 1;
            if (pAuto.Patente != null) q += CantidadRecursiva(pAuto.Siguiente);
            return q;
        }

        public Auto RetornaAutoPosN(int pPosicion)
        {
            Auto aux= null;
            if (pPosicion > 0 && pPosicion <= Cantidad())
            {
                aux = RetornaAutoPosRecursiva(pPosicion, NCP.Siguiente);
            }
            return aux;
        }

        public Auto RetornaAutoPosRecursiva(int pPosicion, Auto pAuto)
        {
            Auto aux = pAuto;
            if (pPosicion > 1)
            {
                aux = RetornaAutoPosRecursiva(pPosicion - 1, pAuto.Siguiente);
            }
            return aux;
        }

        private Auto BuscarUltimo()
        {
            Auto aux = null;
            if (NCP.Siguiente != null) { aux = BuscarUltimoRecursiva(NCP.Siguiente); }
            return aux;
        }

        private Auto BuscarUltimoRecursiva(Auto pAuto)
        {
            Auto aux = pAuto;
            if (pAuto.Siguiente !=null) aux = BuscarUltimoRecursiva(pAuto.Siguiente);

            return aux;
        }


    }
}
