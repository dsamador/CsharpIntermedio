using System;

namespace Estructuras4Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f = 0;

            f = factorial(5);

            Console.WriteLine(f);
        }



        public static int factorial(int n)
        {
            int r = 0;

            //caso inductivo
            if(n>1)
                r = n * factorial(n-1);

            //caso base
            if (r == 1)
                r = 1;

            return r;   
        }

        public static int Fib(int n)
        {
            int r = 0;

            //caso inductivo
            if(n>1)
                r=Fib(n - 1) + Fib(n -2);

            //caso base
            if (n <= 1)
                r = 1;

            return r;
        }
    }
}
