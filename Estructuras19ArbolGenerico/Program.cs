using System;

namespace Estructuras19ArbolGenerico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CArbol arbol = new CArbol();

            CNodo raiz = arbol.Insertar("a", null);

            arbol.Insertar("b", raiz);
            arbol.Insertar("c", raiz);

            

            CNodo nodoHelper = arbol.Insertar("d", raiz);
            arbol.Insertar("h", nodoHelper);// h va para d

            nodoHelper = arbol.Insertar("e", raiz);
            arbol.Insertar("i", nodoHelper);
            nodoHelper = arbol.Insertar("j", nodoHelper);
            arbol.Insertar("p", nodoHelper);
            arbol.Insertar("q", nodoHelper);

            arbol.TransversaPreO(raiz);
        }
    }
}
