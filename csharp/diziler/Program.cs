using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanımlama
            string[] renkler= new string[5]; //boyut belirtilir
            string[] hayvanlar = {"kedi", "köpek", "tavşan", "sincap"};
            int[] dizi;
            dizi= new int[5];

            //Dizilere Atama ve Erişim
            renkler[0] = "mavi";
            dizi[3] = 10;
            Console.WriteLine(hayvanlar[0]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Diziler ile döngülerin birlikte kullanımı
            //Ekrana girilen n taen sayının ortalamasını yazdıran program
            Console.WriteLine("Kaç adet sayının ortalamasını alacaksınız: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] dizi2= new int[diziUzunlugu];


            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("lütfen {0}. degeri giriniz:", i+1);
                dizi2[i]= int.Parse(Console.ReadLine());
                
            }
            int toplam =0;
            foreach (var sayi in dizi2)
                toplam += sayi;  
                
            Console.WriteLine("ortalama= " + toplam/diziUzunlugu);


        }
    }
}
