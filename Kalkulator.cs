using System;

namespace kalkulator
{
    class Program
    {

        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        
        static int Pengurangan(int a, int b)
        {
            return a - b; 
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }


        static void Main(string[] args)
        {
            kembali:
            Console.Clear();

            Console.Title = "aplikasi kalkulator";

            int pilih;

            Console.WriteLine("__________________");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine("5. Keluar");
            Console.WriteLine("_____________________");

            Console.Write("Pilih Menu (1 - 5) = ");
            pilih = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (pilih > 5)
            {
                Console.WriteLine("Menu Tidak ada");
                Console.ReadKey();
                goto kembali;
            }
            else if (pilih == 5)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Write("masukan nilai A: ");
                int a = int.Parse(Console.ReadLine()); //proses casting merubah string menjadi int 

                Console.Write("Masukkan Nilai B = ");
                int b = int.Parse(Console.ReadLine()); //proses casting merubah string menjadi int 

                Console.WriteLine(); //menambakan baris kosong

                switch (pilih)
                {
                    case 1:
                        Console.WriteLine("Hasil Penjumlahan " + a + " + " + b + " = " + Penambahan(a, b));
                        break;
                    case 2:
                        Console.WriteLine("Hasil Pengurangan {0} - {1} = {2} ", a, b, Pengurangan(a, b));
                        break;

                    case 3:
                        Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
                        break;

                    case 4:
                        Console.WriteLine("Hasil Perkalian {0} / {1} = {2}", a, b, Pembagian(a, b));
                        break;
                }
            }

            Console.ReadKey();
            goto kembali;
        }
    }
}
