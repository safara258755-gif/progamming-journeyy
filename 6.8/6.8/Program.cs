using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ulangPilihan;

            do
            {
                // --- Blok Proses akan diulang ---
                Console.WriteLine("----------------------------------");
                Console.Write("Masukkan nama anda: ");
                string nama = Console.ReadLine();
                Console.WriteLine($"Hallo, {nama}! Proses telah selesai");
                // --------------------------------------
                // Pertanyaan untuk mengulang 
                Console.Write("Apakah Anda ingin mengulang lagi (ya/tidak): ");
                ulangPilihan = Console.ReadLine().ToLower(); // Mengambil input dan mengubah ke huruf kecil

                Console.WriteLine(); // Baris kosong untuk kerapian

                // Kondisi diperiksa di akhir: Ulangi selam pengguna mengetik "ya"
            } while (ulangPilihan == "ya");
            Console.WriteLine("Terima Kasih. Program selesai.");
        }
    }
}
