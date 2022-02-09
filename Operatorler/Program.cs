using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("*****Atama ve işlemli atama*****");
           //Atama ve işlemli atama
           int x = 3;
           int y = 3;
           y = y + 2;
           Console.WriteLine(y);

           y += 2;
           Console.WriteLine(y);

           y /= 1;
           Console.WriteLine(y);

           x *= 2;
           Console.WriteLine(x);

           Console.WriteLine("*****Mantıksal operatörler*****");
           //Mantıksal operatörler
           // ||(veya) , &&(ve) , !(değil)
           bool isSuccess =true;
           bool isCompleted =false;

           if(isSuccess && isCompleted)
           Console.WriteLine("Perfect!");

           if(isSuccess || isCompleted)
           Console.WriteLine("Great!");

           if(isSuccess && !isCompleted)
           Console.WriteLine("Fine!");

           Console.WriteLine("*****İlişkisel operatörler*****");
           //İlişkisel operatörler
           // <, >, <=, >=, ==, !=
           int a = 3;
           int b = 4;
           bool sonuc = a<b;
           Console.WriteLine(sonuc);

           sonuc = a>b ;
           Console.WriteLine(sonuc);

           sonuc = a>=b;
           Console.WriteLine(sonuc);

           sonuc = a<=b;
           Console.WriteLine(sonuc);

           sonuc = a==b;
           Console.WriteLine(sonuc);

           sonuc = a!=b;
           Console.WriteLine(sonuc);

           Console.WriteLine("*****Aritmetik operatörler*****");
           //Aritmetik operatörler
           // *, /, +, -
           int sayi1 = 10;
           int sayi2 = 5 ;
           int sonuc1 =sayi1*sayi2;
           Console.WriteLine(sonuc1);

           sonuc1 = sayi1/sayi2;
           Console.WriteLine(sonuc1);

           sonuc1 = sayi1+sayi2;
           Console.WriteLine(sonuc1);

           sonuc1 = sayi1++;
           Console.WriteLine(sonuc1);

           // % mod alır.
           int sonuc2 =20%6;
           Console.WriteLine(sonuc2);





        }
    }
}
