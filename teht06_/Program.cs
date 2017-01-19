using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht06_
{
    class Program
    {
        static void Main(string[] args)
        {

            double matka, kust, bensa;
            Console.WriteLine("Anna matka: ");
            string line = Console.ReadLine();
            matka = int.Parse(line);

            bensa = (matka / 100) * 7.02;
            kust = bensa * 1.595;

            Console.WriteLine("Bensaa kuluu " + bensa + " litraa");
            Console.WriteLine("kustannus " + kust + " euroa");



        }
    }
}
