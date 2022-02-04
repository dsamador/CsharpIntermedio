using System;

namespace Estructuras5ListaLigada1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CListaLigada cListaLigada = new CListaLigada();

            cListaLigada.Adicionar(3);
            cListaLigada.Adicionar(33);
            cListaLigada.Adicionar(23);
            cListaLigada.Adicionar(53);
            cListaLigada.Adicionar(6);
            cListaLigada.Adicionar(9);
            cListaLigada.Adicionar(14);

            cListaLigada.Transversa();
        }
    }
}
