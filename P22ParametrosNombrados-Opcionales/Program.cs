using System;

namespace P22ParametrosNombrados_Opcionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Invocamos la funcion de forma normal
            //tres valores posicionales
            mostrarDatos(3, 5, 7);

            /*
             * Invocamos la funcion con primero en normal, 
             * los demas en otro orden, 
             */
            mostrarDatos(2, pC: 11, pB: 12);

            //Un posicional no puede venir despues de un nombrado
            //mostrarDatos(pB: 5, 7, 8);

            //Dos opcionales con uno nombrado
            mostrarOpcionales(pC: 12);

        }

        public static void mostrarDatos(int pA, int pB, int pC)
        {
            Console.WriteLine("El valor de A es {0}", pA);
            Console.WriteLine("El valor de B es {0}", pB);
            Console.WriteLine("El valor de C es {0}", pC);
            Console.WriteLine("----------------------");
        }

        //Si damos por opcional a uno debemos hacerlo en todos
        //los parametros
        public static void mostrarOpcionales(int pA = 1, 
            int pB = 2, int pC = 3)
        {
            Console.WriteLine("El valor de A es {0}", pA);
            Console.WriteLine("El valor de B es {0}", pB);
            Console.WriteLine("El valor de C es {0}", pC);
            Console.WriteLine("----------------------");
        }
    }
}
