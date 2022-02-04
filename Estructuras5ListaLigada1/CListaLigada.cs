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

        //indica si la lista esta vacia o no
        public bool EstaVacio()
        {
            if (ancla.Siguiente == null)
                return true;
            return false;
        }

        //Regresa el nodo con la primera ocurrencia del dato
        public CNodo Buscar(int pDato)
        {
            if(EstaVacio() == true)
                return null;

            trabajo = ancla;

            //recorremos para ver si lo encontramos
            while(trabajo2.Siguiente != null)
            {
                trabajo2 = trabajo2.Siguiente;

                //al encontrarlo lo regresamos
                if(trabajo2.Dato == pDato)
                    return trabajo2;
            }

            //no se encontro, regresamos null
            return null;
        }

        //Busca el indice donde se encuentra la primera ocurrencia del dato
        public int Buscarindice(int pDato)
        {
            int n = -1;

            trabajo = ancla;
            while(trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
                n++;

                if (trabajo.Dato == pDato)
                    return n;
            }
            return -1;
        }

        //encuentra al nodo anterior
        //si esta en el primer nodo se regresa el ancla
        //si el dato no existe se regresa el ultimo nodo
        public CNodo BuscarAnterior(int pDato)
        {
            trabajo2 = ancla;
            while (trabajo2.Siguiente != null && trabajo2.Siguiente.Dato != pDato)
                trabajo2 = trabajo2.Siguiente;
            return trabajo2;
        }

        //borra la primera ocurrencia del dato
        public void Borrar(int pDato)
        {
            //verificamos que se tengan datos
            if (EstaVacio() == true)
                return;
            
            //buscamos los nodos con los que trabajamos
            CNodo anterior = BuscarAnterior(pDato);

            CNodo encontrado = Buscar(pDato);

            //si no hay nodo a borrar salimos
            if (encontrado == null)
                return;

            //brincamos el nodo
            anterior.Siguiente = encontrado.Siguiente;

            //quitamos el actual de la lista
            encontrado.Siguiente = null;
        }

        //inserta el dato pValor despues de la primera ocurrencia del dato pasado pDonde
        public void Insertar(int pDonde, int pValor)
        {
            //encontramos la posicion donde vamos a insertar
            trabajo = Buscar(pDonde);

            //verificamos que exista donde vamos a insertar
            if(trabajo == null)
                return;

            //creamos el nodo temporal a insertar
            CNodo temp = new CNodo();
            temp.Dato = pValor;

            //conectamos el tempora a la lista
            temp.Siguiente = trabajo.Siguiente;

            //conectamos trabajo a temporal
            trabajo.Siguiente = temp;
        }

        public void InsertarInicio(int pDato)
        {
            //creamos el nodo temporal
            CNodo temp = new CNodo();
            temp.Dato = pDato;

            //conectamos el temporal a la lista
            temp.Siguiente = ancla.Siguiente;

            //conectamos el ancla al temporal
            ancla.Siguiente = temp;
        }

        //obtenemos la referencia al nodo dado el indice
        public CNodo ObtenerPorIndice(int pIndice)
        {
            CNodo trabajo2 = null;
            int indice = -1;

            trabajo = ancla;

            while(trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
                indice++;

                if (indice == pIndice)
                    trabajo2 = trabajo;
            }
            return trabajo2;
        }

        //indexer, con esto podemos usar sintaxis de arreglo
        public int this[int pIndice]
        {
            get
            {
                trabajo = ObtenerPorIndice(pIndice);
                return trabajo.Dato;
            }

            set
            {
                trabajo = ObtenerPorIndice(pIndice);
                if(trabajo != null)
                    trabajo.Dato = value;
            }
        }
    }
}
