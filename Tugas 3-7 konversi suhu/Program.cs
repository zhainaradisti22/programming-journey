using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_3_7_konversi_suhu
{
    internal class Program
    {
        // Fungsi KonversiSuhu : mengubah suhu dari Celcius ke Farenheit
        static double KonversiSuhu(double C )
        {
            double F = (C * 9 / 5) + 32;
            return F;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== PROGRAM KONVERSI SUHU CELCIUS KE FAHRENHEIT ===");

            // Meminta input dari pengguna
            Console.WriteLine("Masukkan suhu dalam Celcius : ");
            double suhuC = double.Parse(Console.ReadLine());

            // Memanggil fungsi KonversiSuhu dan menampilkan hasilnya 
            double suhuF = KonversiSuhu(suhuC);
            Console.WriteLine("Suhu dalam Fahrenheit : " + suhuF);
        }
    }
}
