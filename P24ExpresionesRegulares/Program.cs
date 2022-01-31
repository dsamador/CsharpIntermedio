using System;
using System.Text.RegularExpressions;

namespace P24ExpresionesRegulares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metodo 1

            string texto = "Javascript no es Java ni se escribe Javahiana";
            string exp = "Java";

            MatchCollection encontrado = Regex.Matches(texto, exp);

            // Va a mostrar Java tres veces
            foreach (Match match in encontrado) Console.WriteLine(match);

            Console.WriteLine("---------");

            string exp2 = " Java ";

            Regex regex = new Regex(exp2);

            encontrado = regex.Matches(texto);

            //Muestra Java una sola vez
            foreach (var item in encontrado) Console.WriteLine($"Un solo {item}"); ;


        }
    }
}
