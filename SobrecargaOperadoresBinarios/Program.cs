using System;

namespace SobrecargaOperadoresBinarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CImaginario im1 = new CImaginario(1, 2);
            CImaginario im2 = new CImaginario(3, 4);

            CImaginario imr;

            //Hacemos la suma
            imr = im1 + im2;

            Console.WriteLine($"{im1} + {im2} = {imr}");
        }
    }
}
