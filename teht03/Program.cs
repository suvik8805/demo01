using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luvut = new int[3];
            int luku, i, summa;
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Anna luku");
                string line = Console.ReadLine();
                luku = int.Parse(line);
                luvut[i] = luku; // syötetty luku sijoittuu taulukkoon
               

            }

            for (i = 0; i < 3; i++)
            {
                summa = luvut[i] + luvut[i + 1] + luvut[i+2];
            }

            Console.WriteLine("Lukujen summa on: " + summa );


        }
    }
}
