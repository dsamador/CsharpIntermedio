using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras19ArbolGenerico
{
    internal class CArbol
    {
        private CNodo raiz;
        private CNodo trabajo;//nodo de apoyo
        private int i = 0;

        public CArbol()
        {
            raiz = new CNodo();
        }

        public CNodo Insertar(string pDato, CNodo pNodo)
        {
            //si  no hay nodo donde insertar, tomamos como si fuera en la raiz
            if(pNodo == null)
            {
                raiz = new CNodo();
                raiz.Dato = pDato;

                //no hay hijo
                raiz.Hijo = null;

                //no hay hermano
                raiz.Hermano = null;

                return raiz;
            } 
            if(pNodo.Hijo == null)
            {
                CNodo temp = new CNodo();

                temp.Dato = pDato;

                //conectamos el nuevo nodo como hijo
                pNodo.Hijo = temp;
                
                return temp;
            }
            else//ya tiene hijo tenemos que insertarlo como hermano
            {
                trabajo = pNodo.Hijo;

                //avanzamos hasta el ultimo hermano
                while (trabajo.Hermano != null)
                    trabajo = trabajo.Hermano;

                //creamos el nodo temporal
                CNodo temp = new CNodo();

                temp.Dato = pDato;

                trabajo.Hermano = temp;

                return temp;
            }
        }

        //transversa preorden
        public void TransversaPreO(CNodo pNodo)
        {
            //caso base, es sencillo
            if (pNodo == null)
                return;

            //Me proceso a mi primero
            for (int n = 0; n < i; n++)
                Console.WriteLine(" ");
            

            Console.WriteLine(pNodo.Dato);

            //Luego proceso a mi hijo
            //caso inductivo
            if(pNodo.Hijo == null)
            {
                i++;
                TransversaPreO(pNodo.Hijo);
                i--;
            }

            // si tengo hermanos los proceso
            //otro caso inductivo
            if(pNodo.Hermano != null)
                TransversaPreO(pNodo.Hermano);
        }

    }
}
