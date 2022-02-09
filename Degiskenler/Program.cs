using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("");

            byte b = 5;            //1 byte yer kaplar. 0-255
            sbyte c = 5;           //1 byte yer kaplar. -128 ile 127 arası

            short s = 5;           //2 byte. -32768,32768
            ushort us = 5;         //2 byte. 0-65365

            Int16 i16 = 2;         //2 byte
            int i = 2;             //4 byte
            Int32 i32 = 2;         //4 byte
            Int64 i64 = 2;         //8 byte

            uint ui = 2;           //4 byte
            long l = 5;            //8 byte
            ulong ul = 5;          //8 byte
            
            //Reel Sayılar
            float f = 5;           //4 byte
            double d = 5;          //8 byte
            decimal de = 5;        //16 byte

            char ch = '2';         //2 byte
            string str ="Ersel";   //Sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "abc";     //object her türden veriyi alabilir.
            object o2 = 'y';
            object o3 = 5;
            object o4 = 5.4;
       
            string str1 = string.Empty;
            str1 = "Ersel Gemici";
            string ad = "Ersel";
            string soyad = "Gemici";
            string tamisim = ad + " " + soyad;

            int integer1 = 3;
            int integer2 = 5;
            int integer3 = integer1 + integer2;

            bool bool1 = 10>5;

            //Değişken Dönüşümleri
            string str20 = "20";
            int int20 = 22;
            string yenideger = str20 + int20.ToString();
            Console.WriteLine(yenideger);   //Çıktısı 2022

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);       //Çıktısı 42

            int int22 = int.Parse(str20);   //Çıktısı 42. -String içindeki sayı değerini integer değere dönüştürür.

            //Datetime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy"); //Sadece tarih
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy"); 
            Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH:mm"); 
            Console.WriteLine(hour);









        }
    }
}
