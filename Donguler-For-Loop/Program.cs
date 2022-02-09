using System;

namespace Donguler_For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen sayıya kadar olan tek sayılar
            Console.Write("Lütfen bir sayı giriniz:");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i < sayac; i++)           
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            //1-1000 arasındaki tek ve çift sayıların kendi aralarındaki toplamları
            int tekToplam = 0,ciftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    tekToplam += i; //tekToplam=tekToplam+i;
                }
                else
                {
                    ciftToplam += i;
                }
            }

            Console.WriteLine("TekToplam :" + tekToplam);
            Console.WriteLine("ÇiftToplam :" + ciftToplam);

            //break,continue
            // for (int i = 1; i < 10; i++)
            // {
            //     if (i == 4)
            //     {
            //         break;   // Çıktı = 1,2,3
            //         Console.WriteLine(i);
            //     }
            // }

            // for (int i = 1; i < 10; i++)
            // {
            //     if (i == 4)
            //     {
            //         continue;   //Çıktı = 1,2,3,5,6,7,8,9
            //         Console.WriteLine(i);
            //     }
            // }
        }
    }
}
