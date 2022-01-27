using System;
using System.IO;

namespace P21Streams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long cantidad = 0;//los streams trabajan con longs
            long n = 0;
            int valor = 0;

            FileStream fs = new FileStream("datos.txt", FileMode.Open, FileAccess.Read, FileShare.None);

            //obtenemos la cantidad
            cantidad = fs.Length;
            Console.WriteLine($"El archivo mide {cantidad}");

            //Leemos byte por byte

            for (int i = 0; i < cantidad; i++)
            {
                //ponemos la posicion, este es el offset
                fs.Seek(n, SeekOrigin.Begin);

                valor = fs.ReadByte();
                Console.WriteLine("{0}", (char)valor);
            }

            Console.WriteLine("\n--------\n");

            fs.Close();

        }
    }
}
