using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    internal class Program
    {
        // Method Main adalah titik awal eksekusi program
        static void Main(string[] args)
        {
            string hitunglagi; // variabel untuk menyimpan pilihan pengguna (y/n)

            // Perulangan do-while akan menjalankan blok kode setidakknya satu kali
            // dan akaan terus berjalan selama kondisi while terpenuhi
            do
            {
                Console.Clear(); // Membersihkan layat konsol untuk setiap perhitungan baru
                Console.WriteLine("--- KALKULATOR SEDERHANA ---");

                // Memanggil fungsi untuk menampilkan menu
                TampilkanMenu();

                Console.Write("Masukkan pilihan operasi (1-4) : ");
                string pilihan = Console.ReadLine();

                // variabel untuk menampung angka dan hasil
                double angka1, angka2, hasil = 0;

                // Memanggil fungsi untuk mendapatkan input angka dari user
                // dan memastikan input adalah angka yang valid
                if (AmbilInputAngka(out angka1, out angka2)) ;
                {
                    // Struktur pemilihan switch-chase untuk menentukan operasi
                    switch (pilihan)
                {  
                    case "1": // penjumlahan
                        hasil = Tambah(angka1, angka2);
                        Console.WriteLine($"\nHasil: {angka1} + {angka2} = {hasil}");
                        break;
                    case "2": // pengurangan 
                        hasil = kurang(angka1, angka2);
                        Console.WriteLine($"\nHasil: {angka1} - {angka2} = {hasil}");
                        break;
                    case "3": // pekalian
                        hasil = kali(angka1, angka2);
                        Console.WriteLine($"\nHasil: {angka1} * {angka2} = {hasil}");
                        break;
                    case "4": // pembagian 
                              // Penanganan khusus untuk pembagian dengan nol
                        if (angka2 == 0)
                        {
                            Console.WriteLine("\nError: Tidak dapat melakukan pembagian dengan nol.");
                        }
                        else
                        {
                            hasil = Bagi(angka1, angka2);
                            Console.WriteLine($"\nHasil: {angka1} / {angka2} = {hasil}");
                        }
                        break;
                    default: // Jika pilihan tidak ada di case 1-4
                        Console.WriteLine("\nPilihan yang anda masukkan tidak valid.");
                        break;
                    }
                }
                // Menanyakan kepada pengguna apakah ingin menghitung lagi
                Console.Write("\nApakah Anda ingin menghitung kembali? (y/n): ");
                hitunglagi = Console.ReadLine();
                // ToLower() membuat input menjadi huruf kecil, jadi 'Y' atau 'y' akan sama

            } while (hitunglagi.ToLower() == "y");

            // Pesan penutup jika pengguna memilih unuk keluar
            Console.WriteLine("\nTerima kasih telah menggunakan kalkulator ini. " +
                              "Tekan tombol apa saja untuk keluar. ");
            Console.ReadKey();
        }
        // --- FUNGSI-FUNGSI BANTUAN ---

        // fungsi untuk menampilkan menu pilihan 
        static void TampilkanMenu()
        {
            Console.WriteLine("Pilih operasi matematika: ");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
        }
        // Fungsi untuk mengambil input angka dari pengguna
        // Menggunakan 'out' karena fungsi ini mengembalikan lebih dari satu nilai
        static bool AmbilInputAngka(out double angka1, out double angka2)
        {
            Console.Write("Masukkan angka pertama: ");
            // double. TryParse akan mencoba mengkonversi string ke double.
            // jika berhasil,, return true dan hasilnya disimpan di variabel 'angka1'
            // jika gagal, return false.
            if (!double.TryParse(Console.ReadLine(), out angka1))
            {
                Console.WriteLine("Input untuk angka pertama tidak valid.");
                angka2 = 0; // Beri nilai default agar tidak error
                return false;
            }

            Console.Write("Masukkan angka kedua: ");
            if (!double.TryParse(Console.ReadLine(), out angka2))
            {
                Console.WriteLine("Input untuk angka kedua tidak valid.");
                return false;
            }
            return true; // jika kedua input valid
        }

        // fungsi untuk operasi penjumlahan 
        static double Tambah(double a,  double b) 
        {
            return a + b;
        }

        // fungsi ntuk operasi pengurangan
        static double kurang(double a, double b)
        {
            return a - b;
        }

        // fungsi untuk operasi perkalian
        static double kali(double a, double b)
        {
            return a * b;
        }

        // fungsi untuk operasi pembagian
        static double Bagi(double a, double b)
        {
            return a / b;
        }
                            

            
        
    }
}
