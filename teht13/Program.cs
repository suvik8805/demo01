using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht13
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku, summa=0, suurin=0, pienin=200, i;
            

            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine("Anna pisteet: ");
                string line = Console.ReadLine();
                luku = int.Parse(line);
                
                summa = summa + luku;

                if (luku > suurin)
                {
                    suurin = luku;
                }
                if (luku < pienin)

                    pienin = luku;
            }

            summa = summa - (suurin + pienin);
            Console.WriteLine("Kokonaispisteet ovat: " + summa + " pistettä");



        }
    }
}
