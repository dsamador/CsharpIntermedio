using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class TiendaAutos
    {
        private Auto[] disponibles;

        public TiendaAutos()
        {
            disponibles = new Auto[4];

            disponibles[0] = new Auto("Soul", 220000.50);
            disponibles[1] = new Auto("Fit", 175600.70);
            disponibles[2] = new Auto("March", 168900.00);
            disponibles[3] = new Auto("Fit", 160400.40);
        }

        //creamos el indexer
        public Auto this[int indice]
        {
            //Usamos get para obtener el elemento en ese indice
            get { return disponibles[indice]; }
            
            //Usamos set para colocar un elemento en ese indice
            set { disponibles[indice] = value; }
        }
    }
}
