using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras5ListaLigada1
{
    internal class CListaLigada
    {
        //Ancla o encabezado de la lista
        private CNodo ancla;

        //Variable de referencia que nos ayuda a trabajar con la lista
        //nodo actual
        private CNodo trabajo;

        //Variable de referencia que apoya en ciertas operaciones de la lista
        //para busquedas o para saber el nodo anterior
        private CNodo trabajo2;

        public CListaLigada()
        {
            //Instanciamos el ancla
            ancla = new CNodo();

            //Como es una lista vacia su siguiente es null
            ancla.Siguiente = null;
        }

        //Recorre toda la lista
        public void Transversa()
        {
            //Trabajo al inicio
            trabajo = ancla;

            //recorremos hasta encontrar el final
            while(trabajo.Siguiente != null)
            {
                //Avanzamos trabajo
                trabajo = trabajo.Siguiente;

                //obtenemos el dato y lo mostramos
                int d = trabajo.Dato;

                Console.WriteLine("{0}, ",d);
            }

            //Bajamos la linea
            Console.WriteLine();
        }

        //Adiciona un nuevo elemento,
        //la adicion siempre va al final

        public void Adicionar(int pDato)
        {
            //trabajo al inicio
            trabajo = ancla;

            //recorremos hasta encontrar el final
            while (trabajo.Siguiente != null)
            {
                //avanzamos trabajo
                trabajo = trabajo.Siguiente;
            }

            //creamos el nuevo nodo
            CNodo temp = new CNodo();

            //insertamos el dato
            temp.Dato = pDato;

            //finalizamos correctamente
            temp.Siguiente = null;

            //Ligamos el ultimo nodo encontrado con el recien creado
            trabajo.Siguiente = temp;
        }

        //Vaciar lista
        public void Vaciar()
        {
            ancla.Siguiente = null;
        }

    }
}
