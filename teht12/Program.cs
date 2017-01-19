using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luvut =  new int [5];
            int luku, i;


            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine("Anna luku: ");
                string line = Console.ReadLine();
                luku = int.Parse(line);
                luvut[i] = luku;
            }

            Console.Write("Luvut ovat: ");
            for (i=4; i >= 0; i--)
            {
                
                Console.Write(luvut[i]+ ", ");
            }

            }

    }
}
