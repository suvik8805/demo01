﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kysy luku
            int luku;
            Console.Write("Anna luku > ");
            string line = Console.ReadLine(); // "1" merkki
            luku = int.Parse(line); // "1" -> 1, merkkijono kokonaisluvuksi
            // Mikä luku...
            switch(luku)
            {
                case 1: Console.WriteLine("yksi");break;
                case 2: Console.WriteLine("kaksi");break;
                case 3: Console.WriteLine("kolme");break;
                default: Console.WriteLine("joku muu luku");break;
              
            }
            Console.ReadLine();
            // odota enteriä
        }

    }
}
