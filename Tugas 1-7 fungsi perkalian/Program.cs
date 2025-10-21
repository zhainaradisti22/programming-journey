using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_1_7_fungsi_perkalian
{
    internal class Program
    {
        static int Kali(int a, int b, int c)
        {
            return a * b * c;
        }
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka pertama: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan angka kedua: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan angka ketiga: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int hasil = Kali(a, b, c);
            Console.WriteLine("Hasil perkalian: " + hasil);
        }
    }
}
