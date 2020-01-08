using System;

namespace TES2
{
    class Program
    {
        static void Main(string[] args)
        {
            double nilaiValuasi, nilaiInput, hasilKeRupiah, hasilKeDolar;

            

            int pilihan;

            Console.WriteLine("Daftar Pilihan");
            Console.WriteLine("1. USD to IDR");
            Console.WriteLine("2. IDR to USD");

            Console.Write("Masukkan Pilihan Anda: ");
            pilihan = Convert.ToInt32(Console.ReadLine());

            switch (pilihan)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("USD to IDR");
                    Console.WriteLine("====================");

                    Console.Write(" Masukkan Nilai Valuasi Rupiah : ");
                    nilaiValuasi = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Masukkan Jumlah Dollar Anda : ");
                    nilaiInput = Convert.ToInt32(Console.ReadLine());

                    hasilKeRupiah = nilaiValuasi * nilaiInput;

                    Console.WriteLine("Jadi Total Anda : Rp. " + hasilKeRupiah);

                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("IDR to USD");
                    Console.WriteLine("==============");

                    Console.Write(" Masukkan Nilai Valuasi Rupiah : ");
                    nilaiValuasi = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Masukkan jumlah Rupiah : ");
                    nilaiInput = Convert.ToDouble(Console.ReadLine());

                    hasilKeDolar = nilaiInput / nilaiValuasi;

                    Console.WriteLine(" Jadi Total anda : $. " + hasilKeDolar);

                    break;
                default:
                    Console.WriteLine("Tidak Ada dalam Daftar");
                    break;
            }
        }
    }
}
