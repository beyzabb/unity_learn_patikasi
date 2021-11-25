using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion (Bilinçsiz Dönüşüm)
            Console.WriteLine("------Implicit Conversion (Bilinçsiz Dönüşüm)-------");
            byte a = 10;
            sbyte b = 20;
            short c = 30;
            int d = a+b+c;
            Console.WriteLine("d:" + d);

            long e =d;
            Console.WriteLine("e:" + e);

            float h= e;
            Console.WriteLine("h:" + h);

            string f= "zeynep";
            char g = 'k';
            Console.WriteLine("toplam:" + f+g+d);

            //Explicit Conversion (Bilinçli Dönüşüm)
            Console.WriteLine("------Explicit Conversion (Bilinçli Dönüşüm)-------");
            int x =4;
            byte y= (byte)x; //int degiskenini byte tipine donusturur
            Console.WriteLine("y:"+y);

            int sayi= 100;
            byte sayi2 = (byte)sayi;
            Console.WriteLine("sayi2:"+sayi2);

            float z= 10.3f;
            byte w=(byte)z; 
            Console.WriteLine("w:"+w);

            //ToString Methodu
            Console.WriteLine("------ToString Methodu------");
            int xx= 777;
            string bb= xx.ToString();
            Console.WriteLine("bb:"+bb);

            string zz= 12.5f.ToString();
            Console.WriteLine("zz:"+zz);

            //System.Convert
            Console.WriteLine("------System.Convert------");
            string s1 = "10", s2="20";
            int say1, say2;
            int toplam;
            say1= Convert.ToInt32(s1);
            say2= Convert.ToInt32(s2);
            toplam= say1+say2;
            Console.WriteLine("toplam:"+toplam);

            //Parse Methodu
            Console.WriteLine("------Parse Methodu------");
            ParseMethodu();
             
        }
        public static void ParseMethodu()
        {
            string s1= "10";
            string s2="10,5";
            int rakam1;
            double db;
            rakam1 = Int32.Parse(s1); //parse parantez icerisine daima string ifade alir
            Console.WriteLine("rakam1:"+rakam1);

            db = Double.Parse(s2);
            Console.WriteLine("double:"+db);



        }
    }
}
