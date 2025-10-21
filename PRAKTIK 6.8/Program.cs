using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAKTIK_6._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ulangPilihan;

            do
            {

                // --- Blok proses yang akan diulang ---
                Console.WriteLine("-----------------------------------");
                Console.Write("Masukkan nama anda: ");
                string nama = Console.ReadLine();
                Console.WriteLine($"Hallo, {nama}! Proses telah selesai. ");
                //------------------------------
                // pertanyaan untuk mengulang
                Console.Write("Apakah anda ingin mengulang lagi? (iya/tidak): ");
                ulangPilihan = Console.ReadLine().ToLower(); // mengambil input dan mengubah ke huruf kecil

                Console.WriteLine(); // baris kosong untuk kerapian

                // kondisi diperiksa di akhir: ulangi selama pengguna mengetik "iya"
            } while (ulangPilihan == "ya");
            Console.WriteLine("Terima kasih. program selesai.");
        }
    }
}
