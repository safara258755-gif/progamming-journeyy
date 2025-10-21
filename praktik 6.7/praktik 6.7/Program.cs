using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_6._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pilihan;

            do
            {
                //Tampiilkan menu
                Console.WriteLine("\n=== Menu Aplikasi ===");
                Console.WriteLine("1. Lihat Data");
                Console.WriteLine("2. Tambah data");
                Console.WriteLine("3.Keluar");
                Console.Write("masukkan pilihan anda (1-3): ");

                // Baca input pengguna
                if (!int.TryParse(Console.ReadLine(), out pilihan))
                {
                    Console.WriteLine("Pilihan tidak valid. harap masukkan angka 1, 2, atau 3.");
                    //Tetapkan nilai selain 3 agar loop berlanjut
                    pilihan = 0;
                    continue;
                }

                //proses pilihan
                switch (pilihan)
                {
                    case 1:
                        Console.WriteLine("Anda memilih: Lihat Data.");
                        break;
                    case 2:
                        Console.WriteLine("Anda memilih: Tambah data.");
                        break;
                    case 3:
                        Console.WriteLine("Program akan berhenti...");
                        break; // keluar dari switch
                    default:
                        Console.WriteLine("Pilihan di luar jangkauan. harap masukkan 1, 2, atau 3.");
                        break;

                }

                // kondisi loop: Lanjutan selama pilihan BUKAN 3.
            } while (pilihan != 3);
            Console.WriteLine("Terima kasih telah menggunakan aplikasi.");
        }
    }
    }

