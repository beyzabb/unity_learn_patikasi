using System;

namespace while_foreach_donguleri
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("********while********\n");
            //girilen sayiya kadar sayi dahil ortalamasini ekrana yazdir
            Console.Write("bir sayi giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)           
            {
                toplam += sayac;
                sayac ++;
            }
            Console.WriteLine(toplam/sayi);

            //a dan baslayarak z ye kadar tum harfleri ekrana yazdir
            char character = 'a';
            while (character<='z')
            {
                 Console.Write(character);
                 character ++;
            }

            Console.Write("\n********foreach********\n");
            string[] arabalar = {"BMV", "Toyota",  "Nissan", "Ford"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
                
            }


        }
    }
}
