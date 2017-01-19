using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            int ika;
            Console.WriteLine("Anna ikäsi:");
            string line = Console.ReadLine();
            ika = int.Parse(line);

            if(ika<18)
            {
                Console.WriteLine("Olet alaikäinen");
            }
            if (ika>=18 && ika <=65)
            {
                Console.WriteLine("Olet aikuinen");
            }
            if (ika>65)
            {
                Console.WriteLine("Olet seniori:");
            }

        }
    }
}
