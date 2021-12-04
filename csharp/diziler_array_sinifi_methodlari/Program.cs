using System;

namespace diziler_array_sinifi_methodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort-Sıralama
            Console.WriteLine("***********Sırasız Dizi********");
            int[] sayiDizisi={2,5,65,32,15,87,1,45};
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("***********Sıralı Dizi********");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //Clear-Temizleme
            Console.WriteLine("***********Array Clear********");
            //SayiDizisi elemanlarini kullanarak ikinci indexten başlayarak iki adet elemani 0'lar
            Array.Clear(sayiDizisi,2,2);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //Reverse-Aynalama
            Console.WriteLine("***********Array Reverse********");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //IndexOf
            Console.WriteLine("***********Array IndexOf********");
            Console.WriteLine(Array.IndexOf(sayiDizisi,65));

            //Resize
            Console.WriteLine("***********Array Resize********");
            Array.Resize<int>(ref sayiDizisi,5);
            sayiDizisi[4] =99;
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            

        }
    }
}
