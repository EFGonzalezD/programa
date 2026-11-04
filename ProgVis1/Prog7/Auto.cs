using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog7
{
    public class Auto
    {
        public string Patente {  get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Auto Siguiente { get; set; }

        public Auto(string pPatente = "", string pMarca = "", string pModelo = "", Auto pSiguiente = null) 
        {
            Patente = pPatente;
            Marca = pMarca;
            Modelo = pModelo;
            Siguiente = pSiguiente;
        }

        public override string ToString()
        {
            return $"{Patente}, {Marca}, {Modelo}";
        }
    }
}
