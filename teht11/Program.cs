using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht11
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku, rivi, sarake=1;
            Console.WriteLine("Anna luku: ");
            string line = Console.ReadLine();
            luku = int.Parse(line);

            for(rivi=1;rivi <=luku; rivi++)
            {
                
                for (sarake = 1; sarake <= rivi; sarake++)
                {
                    Console.Write("*");
                }
                sarake++;
                Console.WriteLine();
                
            }

        }
    }
}
