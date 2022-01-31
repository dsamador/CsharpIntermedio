using System;
using System.Collections.Generic;

namespace dividirpor12
{//Programa para ayudarme a sacar promedios un informe
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Double> list = new List<Double>();
            while (true)
            {
                int cantidadValores = 1;
                Console.WriteLine("Nueva cantidad de valores");
                while(cantidadValores < 6)
                {
                    Console.WriteLine($"Valor numero {cantidadValores}");
                    double valor = Double.Parse(Console.ReadLine());

                    if (valor == 0)
                        valor = 1;

                    double promedio = valor / 12;
                    
                    list.Add(promedio);
                    
                    cantidadValores++;
                }
                Console.WriteLine("-----------");
                Console.WriteLine("--Valores--");
                int indice = 1;
                foreach (var item in list)
                {
                    Console.WriteLine($"Valor {indice} {item}");
                    indice++;
                }
                Console.WriteLine("\n");
                list.Clear();
            }
        }
    }
}
