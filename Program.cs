using System.Threading;
using System;

public class Kalkulator
{
    public static void Main(string[] args)
    {
    start:
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGreen;

        //VARIABLE
        decimal a, b;
        string proses, ulang;

        //WELCOME
        Console.WriteLine("===========================================");
        Console.WriteLine("            KALKULATOR C# BY YUDA       ");
        Console.WriteLine("===========================================");
        Thread.Sleep(2000);

        //INPUT BILANGAN
        Console.Write("MASUKKAN BILANGAN PERTAMA: ");
        a = Convert.ToDecimal(Console.ReadLine());
        Console.Write("MASUKKAN BILANGAN KEDUA: ");
        b = Convert.ToDecimal(Console.ReadLine());

        Console.Clear();
        //MENU LIST
        Console.WriteLine("============================================");
        Console.WriteLine("         PILIH MENU OPERASI BILANGAN");
        Console.WriteLine("");
        Console.WriteLine("     1. PENJUMLAHAN      2. PENGURANGAN");
        Console.WriteLine("     3. PERKALIAN        4. PEMBAGIAN");
        Console.WriteLine("");

        //INPUT MENU LIST
        Console.Write("                 PILIHAN: ");
        proses = Convert.ToString(Console.ReadLine())!;
        Console.WriteLine("============================================");

        Console.Clear();
        //PENJUMLAHAN
        if (proses == "1")
        {
            Console.WriteLine("HASIL PENJUMLAHAN " + (a) + " + " + (b) + " = " + (a + b));
        }

        //PENGURANGAN
        else if (proses == "2")
        {
            Console.WriteLine("HASIL PENGURANGAN " + (a) + " - " + (b) + " = " + (a - b));
        }

        //PERKALIAN
        else if (proses == "3")
        {
            Console.WriteLine("HASIL PERKALIAN " + (a) + " × " + (b) + " = " + (a * b));
        }

        //PEMBAGIAN
        else if (proses == "4")
        {
            Console.WriteLine("HASIL PEMBAGIAN " + (a) + " : " + (b) + " = " + (a / b));
        }

        //ERROR INPUT MENU TIDAK VALID
        else
        {
            Console.WriteLine("            PILIHAN TIDAK VALID!!!");
            Console.WriteLine("               HARAP COBA LAGI.");
            Console.WriteLine("     KETIK 1 UNTUK MASUK KE MENU UTAMA.");
            ulang = Convert.ToString(Console.ReadLine())!;
            if (ulang == "1")
            {
                goto start;
            }
            Thread.Sleep(1500);
        }
        Console.WriteLine("============================================");

        //REPEAT
        Console.WriteLine("MAU MENGULANGI? KETIK 1 UNTUK YA DAN 2 TIDAK");
        Console.Write("MASUKKAN PILIHAN: ");
        ulang = Convert.ToString(Console.ReadLine())!;

        if (ulang == "1")
        {
            goto start;
        }
        Console.WriteLine("============================================");
    }
}