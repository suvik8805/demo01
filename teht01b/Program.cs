﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht01b
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kysy luku
            int luku;
            Console.Write("Anna luku > ");
            string line = Console.ReadLine(); // "1" merkki
            bool result = int.TryParse(line, out luku); // "1" -> 1, merkkijono kokonaisluvuksi

            if (result == true)
            {
                // Mikä luku...
                switch (luku)
                {
                    case 1: Console.WriteLine("yksi"); break;
                    case 2: Console.WriteLine("kaksi"); break;
                    case 3: Console.WriteLine("kolme"); break;
                    default: Console.WriteLine("joku muu luku"); break;

                }
            }
            else {
                Console.WriteLine("Not a integer value!"); 
                }
            Console.ReadLine();
            // odota enteriä
        }
    }
}
