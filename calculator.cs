using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator-app
{
	class Calculator
	{
		static void Main(string[] args)
		{
			int a;
			int b;
			int total = 0;

			Console.WriteLine("-- Calculator --");
			Console.WriteLine();
			Console.WriteLine("(1.) Penambahan");
			Console.WriteLine("(2.) Pengurangan");
			Console.WriteLine("(3.) Perkalian");
			Console.WriteLine("(4.) Pembagian");
			Console.WriteLine();
			Console.Write("Ingin Menghitung Apa?(Masukkan Nomer): ");
			int pilih = Int32.Parse(Console.ReadLine());

			if (pilih == 1)
			{
				Console.Write("Masukkan Nilai Pertama: ");
				a = int.Parse(Console.ReadLine());
				Console.Write("Masukkan Nilai Kedua: ");
				b = int.Parse(Console.ReadLine());
				Console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b));
			}
			else if (pilih == 2)
			{
				Console.Write("Masukkan Nilai Pertama: ");
				a = int.Parse(Console.ReadLine());
				Console.Write("Masukkan Nilai Kedua: ");
				b = int.Parse(Console.ReadLine());
				Console.WriteLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b));
			}
			else if (pilih == 3)
			{
				Console.Write("Masukkan Nilai Pertama: ");
				a = int.Parse(Console.ReadLine());
				Console.Write("Masukkan Nilai Kedua: ");
				b = int.Parse(Console.ReadLine());
				Console.WriteLine("Hasil Perkalian: {0} * {1} = {2}", a, b, Perkalian(a, b));
			}
			else if (pilih == 4)
			{
				Console.Write("Masukkan Nilai Pertama: ");
				a = int.Parse(Console.ReadLine());
				Console.Write("Masukkan Nilai Kedua: ");
				b = int.Parse(Console.ReadLine());
				Console.WriteLine("Hasil Pembagian: {0} / {1} = {2}", a, b, Pembagian(a, b));
			}
			else
			{
				Console.WriteLine("Tolong Cek Kembali Pilihan Anda.");
			}
			Console.WriteLine("\nTekan Apa Saja Untuk Keluar");
			Console.ReadKey();
		}

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

	}
}