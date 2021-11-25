using System;

namespace degiskenler
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int deger=2;
            string kelime =null; //herhangi bir deger yoksa null yazilabilir

            byte b=5;            //1 byte 0 ile 526
            sbyte c=5;           //1 byte -128 ile 128 

            short a =5;          //2 byte -32768 ile +32768
            ushort us=5;         //2 byte 0 ile 65365 

            Int16 int16= 2;      //2 byte
            int i =2;            //4 byte
            Int32 i32=2;         //4 byte
            Int64 i64=2;         //8 byte

            uint ui=2;           //4 byte
            long l=4;            //8 byte
            ulong ul=4;          //8 byte

            //Reel sayilar
            float f=5;           //4 byte
            double d=5;          //8 byte
            decimal de=5;        //16 byte
            
            char ch='5';           //2 byte
            string str ="beyza";     //sinirsiz

            bool b1=true;
            bool b2= false;

            DateTime dt = DateTime.Now;

            object o1= "beyzaa";
            object o2= 'a';
            object o3= 4;
            object o4= 4.3;

            //string ifadeler
            string str1= string.Empty;
            str1 = "zikriye";
            string ad = "zikriye";
            string soyad = "ürkmez";
            string tam_isim = ad + " " + soyad;

            //integer ifadeler
            int sayi1= 3;
            int sayi2= 5;
            int sayi3 = sayi1*sayi2;

            bool bool1 =10>2;

            //degiskenlerin birlesmesi
            string str11= "20";
            int i20= 20;
            string yeniDeger= str11 + i20.ToString();
            Console.WriteLine(yeniDeger);

            int yeniDeger2= i20 + Convert.ToInt32(str11);
            Console.WriteLine(yeniDeger2);

            int i22= i20 + int.Parse(str11);
            Console.WriteLine(i22);

            //dateTime
            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime);

            string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dateTime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);


















            
            Console.WriteLine(dt);
        }
    }
}
