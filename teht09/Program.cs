using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht09
{
    class Program
    {
        static void Main(string[] args)
        {
      
            int luku, summa=0;

            while (true)
            {
                Console.WriteLine("Anna luku: ");
                string line = Console.ReadLine();
                luku = int.Parse(line);
                summa = summa + luku;

                if (luku == 0) break;

            }

            Console.WriteLine("Lukujen summa on: " + summa);

            
        }

            

    }
}
