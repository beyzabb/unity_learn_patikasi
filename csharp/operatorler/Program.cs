using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****atama ve islemli atama operatorleri*****");
            //atama ve islemli atama
            int x=3;
            int y=3;
            y = y+2;
            Console.WriteLine(y);
            y+=2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x*=2;
            Console.WriteLine(x);

            Console.WriteLine("*****mantiksal operatorler*****");
            //mantiksal operatorler
            // || (veya), && (ve), ! (degil)
            bool isSuccess = true;
            bool isCompleted = false;
            if(isSuccess && isCompleted)
                Console.WriteLine("perfect");
            if(isCompleted||isSuccess)
                Console.WriteLine("great");
            if(isSuccess && !isCompleted)
                Console.WriteLine("fine");
            
            Console.WriteLine("*****iliskisel operatorler*****");
            //iliskisel operatorler
            // >, <, >=, <=, ==, !=
            int a = 3;
            int b = 4;
            bool sonuc= b>a;
            Console.WriteLine(sonuc);

            sonuc= a>b;
            Console.WriteLine(sonuc);

            sonuc= a>=b;
            Console.WriteLine(sonuc);

            sonuc= a<=b;
            Console.WriteLine(sonuc);

            sonuc= a==b;
            Console.WriteLine(sonuc);

            sonuc= a!=b;
            Console.WriteLine(sonuc);

            Console.WriteLine("*****aritmetik operatorler*****");
            // + - / *
            int sayi1=2;
            int sayi2=5;
            int sonuc1= sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1= sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1= sayi1+sayi2;
            Console.WriteLine(sonuc1);
            sayi1++;
            Console.WriteLine(sayi1);

            //% mod alir
            int sonuc2= 20%3;
            Console.WriteLine(sonuc2);








        }
    }
}
