using System;

namespace Diziler_Array_Sinifi_Methodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort (Sıralama)
            int[] sayiDizisi = {23,12,4,86,72,3,11,17};

            Console.WriteLine("***** Sırasız Dizi *****");

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("***** Sıralı Dizi *****");
            
            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            

            Console.WriteLine("***** Array Clear *****");

            Array.Clear(sayiDizisi,2,2); //2. indexten başlayarak 2 eleman sıfırladık.

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            

            //Reverse (Tersine Çevirme)
            Console.WriteLine("***** Array Reverse *****");

            Array.Reverse(sayiDizisi);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            

            //IndexOf
            Console.WriteLine("***** Array IndexOf *****");

            Console.WriteLine(Array.IndexOf(sayiDizisi,23)); //23 kaçıncı indexte ?

            //Resize(Yeniden Boyutlandırma)
            Console.WriteLine("***** Array Resize *****");

            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8]=99;

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
        }
    }
}
