using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_6._6_yulmenina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int angka;

            // Blok 'do' akan dieksekusi minimal satu kali.
            do
            {
                Console.Write("Masukkan angka genap: ");
                // Mecoba membaca input dari pengguna
                if (!int.TryParse(Console.ReadLine(), out angka))
                {
                    Console.WriteLine("Input tidak valid. Silahkan masukkan angka.");
                    // Jika input tidak valid, set angka = 1(ganjil) agar loop berlanjut
                    angka = 1;
                    continue; // Lanjutkan lierasi berikutnya
                }
                // Memeriksa apakah angka tersebut ganjil 
                if (angka % 2 != 0) ;
                {
                    Console.WriteLine($"angka {angka} adalah ganjil. Coba lagi.");
                }
                // Kondisi diperiksa di akhir. Loop akan berlanjut selama angka ganjil
            } while (angka % 2 != 0);
            Console.WriteLine($"Selamat! anda memasukkan angka genap: {angka}");
        }
    }
}
