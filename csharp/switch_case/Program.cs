﻿using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;
            switch (month)
            {
                case 1:
                    Console.WriteLine("ocak ayındasınız");
                    break;
                case 2:
                    Console.WriteLine("şubat ayındasınız");
                    break;
                case 3:
                    Console.WriteLine("mart ayındasınız");
                    break;
                case 11:
                    Console.WriteLine("kasım ayındasınız");
                    break;
                
                default:
                    Console.WriteLine("yanlış veri girişi");
                    break;
                
                    
            }
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("kış mevsimindesiniz");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("ilkbahar mevsimindesiniz");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("yaz mevsimindesiniz");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("sonbahar mevsimindesiniz");
                    break;
                
                default:
                break;
            }
        }
    }
}
