using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_6._2_yulmenina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variabel untuk menyimpan hasil penjumlahan 
            int total = 0;

            Console.WriteLine("Menghitung jumlah angka dari 1 sampai 5:");

            // Perulangan for dari 1 hingga 5
            for (int i = 1; i <= 5; i++)
            {
                // Tambahkan nilai i saat ini ke variabel total
                total = total + i; // Bisa juga ditulis sebagai: total += i;

                // Tampilkan prosses penjumlahan di setiap langkah 
                Console.WriteLine("Menambahkan " + i + ", Total sementara = " + total);
            }
            // Tampilkan hasil akhir setelah pengulangan selesai
            Console.WriteLine("\nHasil akhir penjumlahan adalah : " + total);
        }
    }
}
