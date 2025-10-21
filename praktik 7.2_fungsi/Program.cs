using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_7._2_fungsi
{
    internal class Program
    {
        static void SapaNama(string nama)
        {
            Console.WriteLine("Halo, " + nama + "!");
            Console.WriteLine("Semangat belajar C# Hari ini!");
        }
        static void Main(string[] args)
        {
            Console.Write("Masukkan nama anda: ");
            string namaSiswa = Console.ReadLine();
            SapaNama(namaSiswa); // Memanggi fungsi dengan argumen
        }
    }
}
