using System;

namespace Estructuras10BubbleSort
{
    internal class Program
    {
        private static CListaLigada miLista = new CListaLigada();
        static void Main(string[] args)
        {
            miLista.Adicionar(3);
            miLista.Adicionar(2);
            miLista.Adicionar(37);
            miLista.Adicionar(300);
            miLista.Adicionar(8);
            miLista.Adicionar(65);
            miLista.Adicionar(45);
            miLista.Adicionar(76);
            miLista.Adicionar(12);
            miLista.Adicionar(27);

            miLista.Transversa();

            int m = 0;
            int n = 0;
            int cantidad = miLista.Cantidad();

            Console.WriteLine($"Son {cantidad} elementos");

            //Hacemos los pases correspondientes
            for(m = 1; m < cantidad; m++)
            {
                for (n = 0; n < cantidad - m; n++)
                {
                    if (miLista[n] > miLista[n + 1])
                        Swap(n, n + 1);
                }
            }
            miLista.Transversa();
        }

        private static void Swap(int i1, int i2)
        {
            int temp = miLista[i1];
            miLista[i1] = miLista[i2];
            miLista[i2] = temp;
        }
    }
}
