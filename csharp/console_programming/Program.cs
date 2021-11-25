using System;

namespace giris
{
    class Program
    {
        static public void Main(string[] args)
        {
            Console.WriteLine("Adınızı giriniz");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz");
            string surname = Console.ReadLine();
            string yeni_isim= "Hoşgeldin" + " "+ name + " " + surname;
            Console.WriteLine(yeni_isim);
            

        }
    }
}
