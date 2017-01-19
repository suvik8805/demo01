using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht08
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int luku, suurin=0, i;

            for (i = 0; i < 3; i++)
            {
               
                Console.WriteLine("Anna luku: ");
                string line = Console.ReadLine();
                luku = int.Parse(line);

                if (luku > suurin)
                {
                    suurin = luku;
                } 

            }

            Console.WriteLine("Suurin luku on: " + suurin);


        }
    }
}
