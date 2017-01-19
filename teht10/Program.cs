using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] luvut = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };

            for (i=0; i<luvut.Length; i++ )
            {
                if (luvut[i] % 2 == 0) 
                Console.WriteLine(luvut[i] + " HEP!");
                       
            }
        }
    }
}
