using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_2_7_fungsi_rata_rata
{
    internal class Program
    {
        // fungsi RataRata : menerima tiga nilai dan mengembalikan hasil rata ratanya
        static double RataRata(double a, double b, double c)
        {
            double hasil = (a + b + c) / 3;
            return hasil;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== Program Menghitung Rata-Rata ===");

            // Meminta input dari pengguna
            Console.Write("Masukkan nilai pertama : ");
            double nilai1 = double.Parse(Console.ReadLine());
            Console.Write("Masukkan nilai kedua : ");
            double nilai2 = double.Parse(Console.ReadLine());
            Console.Write("Masukkan nilai ketiga : ");
            double nilai3 = double.Parse(Console.ReadLine());

            // Memanggil fungsi Rata-Rata dan menampilkan hasilnya
            double hasilRata = RataRata(nilai1, nilai2, nilai3);
            Console.WriteLine("Hasil rata-rata : " +  hasilRata);
        }
    }
}
