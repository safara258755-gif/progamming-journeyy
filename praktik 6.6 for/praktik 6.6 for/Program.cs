using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_6._6_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int angka;
            //Blok 'do' akan dieksekusi minimal satu kali.
            do
            {
                Console.WriteLine("masukkan angka genap: ");
                // Mencoba membaca input dari pengguna
                if (!int.TryParse(Console.ReadLine(), out angka))
                {
                    Console.WriteLine("input tidak valid."
                }
            }
        }
    }
}
