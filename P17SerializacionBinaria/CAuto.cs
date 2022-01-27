using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P17SerializacionBinaria
{
    [Serializable]
    internal class CAuto
    {
        private double costo;
        private string modelo;

        public CAuto( string modelo, double costo)
        {
            this.costo = costo;
            this.modelo = modelo;
        }

        public void MuestraInformacion()
        {
            Console.WriteLine($"Tu auto {modelo}");
            Console.WriteLine($"costo {costo}");
            Console.WriteLine("-------------------");
        }
    }
}
