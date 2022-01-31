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
                Console.WriteLine("Nombre de persona");
                string nombre = Console.ReadLine();
                Console.WriteLine($"Año de promedios de {nombre}");
                string year = Console.ReadLine();
                while(cantidadValores < 6)
                {
                    Console.WriteLine($"Valor numero {cantidadValores}");
                    
                    double valor = Double.Parse(Console.ReadLine());                        

                    if (valor == 0)
                        valor = 12;

                    double promedio = valor / 12;
                    
                    list.Add(promedio);
                    
                    cantidadValores++;
                }
                Console.WriteLine("---------------");
                Console.WriteLine("----Valores----");
                Console.WriteLine($"Nombre: {nombre} Year: {year}");
                Console.WriteLine("---------------");
                int indice = 1;
                foreach (var item in list)
                {
                    Console.WriteLine($"Valor {indice} :  {item}");
                    Console.WriteLine("-----------------------");
                    indice++;
                }
                Console.WriteLine("\n");
                list.Clear();
            }
        }
    }
}
