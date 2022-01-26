using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class Auto
    {
        double costo;
        double tenencia;
        string modelo;

        public Auto(string pModelo, double pCosto)
        {
            costo = pCosto;
            modelo = pModelo;
        }

        public void MuestraInformacion()
        {
            Console.WriteLine("Tu automovil {0}", modelo);
            Console.WriteLine("Costo {0}", costo);
            Console.WriteLine("-----------------------");
        }
    }
}
