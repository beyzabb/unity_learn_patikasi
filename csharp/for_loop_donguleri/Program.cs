using System;

namespace for_loop_donguleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //ekranda girilen sayiya kadar olan tek sayilari ekrana yazdir
            Console.Write("bir sayi giriniz:");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 0; i <= sayac; i++)
            {
                if (i%2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            //1 ile 1000 arasindaki tek ve çift sayilarikendi aralarinda toplamlarini ekrana yazdir
            int tekToplam = 0;
            int ciftToplam= 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i%2==1)
                {
                    tekToplam += i; //ciftToplam = ciftToplam + i
                }
                else
                {
                    ciftToplam += i; //tekToplam = tekToplam + i
                }
                
            }
            Console.WriteLine("tek sayilarin toplami:"+ tekToplam +" "+ "cift sayilarin toplami:"+ ciftToplam);

            //break ve continue
            for (int i = 0; i < 10; i++)
            {
                if (i==4)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i==4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

        }
    }
}
