﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_6._1_yulmenina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Perulangan untuk menampilkan angka 1 sampai 10: ");

            // Perulangan for dimulai disini 
            for (int i = 1; i <= 10; i++)
            {
                // Blok kode yang akan diulang
                Console.WriteLine("Angka ke-" + i);
            }
            Console.WriteLine("\nPerulangan selesai.");
        }
    }
}
