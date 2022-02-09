using System;

namespace Donguler_While_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            //1den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayan program
            Console.Write("Lütfen bir sayı giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac ++;
            }
            Console.WriteLine(toplam/sayi);

            //a dan z ye kadar tüm harfleri console a yazdır.
            char character = 'a';
            while (character <= 'z')
            {
                Console.WriteLine(character);
                character ++;
            }

            Console.WriteLine("*****ForEach*****");
            string [] arabalar = {"Bmw","Ford","Toyota","Nissan"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }


        }
    }
}
