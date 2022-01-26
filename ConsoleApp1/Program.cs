﻿using System;

namespace ConsoleApp1
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            //creamos el refri
            CRefri miRefri = new CRefri(70, -20);

            Random rnd = new Random();

            //adicionamos los handlers
            miRefri.AdicionaMetodoReservas(new 
                CRefri.DReservasBajas(InformeKilos));

            miRefri.AdicionaMetodoDescongelado(new 
                CRefri.DDescongelado(InformeGrados));

            //El refri trabaja
            while (miRefri.Kilos > 0)
            {
                miRefri.Trabajar(rnd.Next(1, 5));
            }
        }
        public static void InformeKilos(int pKilos)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.
                WriteLine("--> Reservas bajas de alimentos, " +
                "estoy a nivel de main");

            Console.WriteLine("--> Quedan {0} kilos", pKilos);
        }
        public static void InformeGrados(int pGrados)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.
                WriteLine("--> Se descongela el refri," +
                " estoy a nivel de main");

            Console.WriteLine("--> Esta a {0} grados", pGrados);
        }
    }
}

