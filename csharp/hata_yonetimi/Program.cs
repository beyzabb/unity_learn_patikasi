using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("bir sayi giriniz");
                int sayi= Int32.Parse(Console.ReadLine());
                Console.WriteLine("girdiginiz sayi:"+sayi);
            }
            catch(Exception ex)
            {
                Console.WriteLine("hata:"+ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
                
            }

            try
            {
                //int a= int.Parse(null);
                //int b= int.Parse("form");
                int c= int.Parse("-200000000000");


            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("bos deger yazdiniz");
                Console.WriteLine(ex);
                
            }
            catch(FormatException ex)
            {
                Console.WriteLine("veri tipi uygun degil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("cok buyuk ya da cok kucuk deger girdiniz");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("islem basariyla tamamlandi");
            }


            


        }
    }
}
