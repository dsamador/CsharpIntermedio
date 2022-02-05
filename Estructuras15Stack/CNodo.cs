using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras15Stack
{
    internal class CNodo
    {
        //Aqui colocamos el dato o los datos que guarda el nodo        
        private int dato;

        //Esta variable de referencia es usada para apuntar al nodo siguiente
        //una variable de referencia es una variable que puede ser referenciada
        //a cualquier instancia del mismo tipo de la clase. Por seguridad se
        //inicia en null
        private CNodo siguiente = null;

        //propiedades que usaremos
        public int Dato { get => dato; set => dato = value; }
        internal CNodo Siguiente { get => siguiente; set => siguiente = value; }

        //Para su facil impresion
        public override string ToString()
        {
            return string.Format("[{0}]", dato);
        }
    }
}
