using System;

namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            //creamos la tienda
            TiendaAutos tiendaAutos = new TiendaAutos();

            //obtenemos un auto
            Auto miAuto = tiendaAutos[1];
            miAuto.MuestraInformacion();

            //colocamos un auto
            Auto otroAuto = new Auto("Vocho", 85000);
            tiendaAutos[1] = otroAuto;

            //imprimimos toda la tienda
            for (int i = 0; i < 4; i++)
            {
                tiendaAutos[i].MuestraInformacion();
            }
        }
    }
}
