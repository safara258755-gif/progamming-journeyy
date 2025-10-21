using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_fungsi_konversi_suhu
{
    internal class Program
    {
        // Fungsi KonversiSuhu: mengubah Celcius ke Fahrenheit
        static double KonversiSuhu(double celsius)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }

        static void Main(string[] args)
        {
            Console.Write("Masukkan suhu dalam Celcius: ");
            double c = double.Parse(Console.ReadLine());

            // Panggil fungsi KonversiSuhu
            double hasilKonversi = KonversiSuhu(c);

            Console.WriteLine($"Suhu {c}°C = {hasilKonversi}°F");
        }
    }
}
    

