// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Birinci sayıyı girin: ");
        int sayi1 = int.Parse(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        int sayi2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
        Console.WriteLine("1: Toplama");
        Console.WriteLine("2: Çıkarma");
        Console.WriteLine("3: Çarpma");
        Console.WriteLine("4: Bölme");
        int secim = int.Parse(Console.ReadLine());

        double sonuc = 0;

        switch (secim)
        {
            case 1:
                sonuc = sayi1 + sayi2;
                Console.WriteLine($"Sonuç: {sayi1} + {sayi2} = {sonuc}");
                break;
            case 2:
                sonuc = sayi1 - sayi2;
                Console.WriteLine($"Sonuç: {sayi1} - {sayi2} = {sonuc}");
                break;
            case 3:
                sonuc = sayi1 * sayi2;
                Console.WriteLine($"Sonuç: {sayi1} * {sayi2} = {sonuc}");
                break;
            case 4:
           
                if (sayi2 != 0)
                {
                    sonuc = (double)sayi1 / sayi2;
                    Console.WriteLine($"Sonuç: {sayi1} / {sayi2} = {sonuc}");
                }
                else
                {
                    Console.WriteLine("Hata: Bir sayıyı sıfıra bölemezsiniz.");
                }
                break;
            default:
                Console.WriteLine("Geçersiz işlem seçimi.");
                break;
        }
    }
}

