using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec, min, tun, sek;
            Console.WriteLine("Syötä sekuntimäärä: ");
            string line = Console.ReadLine();
            sec = int.Parse(line);

            tun = sec / 3600;
            min = sec % tun;
            sek = min % 60;



            Console.WriteLine("Antamasi sekuntiaika on: " + tun );
            Console.Write(" tuntia " + min);
            Console.Write(" minuuttia " + sek );

        }
    }
}
