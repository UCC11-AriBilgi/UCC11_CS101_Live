using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_FlowMechanims
{
    internal class For
    {
        public static void Main(string[] args)
        {
            Console.Clear(); // ekranı temizler

            Console.WriteLine("******************************************");
            Console.WriteLine("*                                        *");
            Console.WriteLine("* FOR DÖNGÜ ÖRNEKLERİ                    *");
            Console.WriteLine("*                                        *");
            Console.WriteLine("******************************************\n\n\n");

            #region for.1
            // 1 den 10 a kadar sayıların toplamını for dongüsüyle hesaplama

            int toplam = 0; // Benim o anki toplam değerimi tutacak değişgen

            // Başlangıç değerinden baslayacak, son değerden küçük olduğu sürece {} arasındaki bloğu çalıştıracak.ve herbir dönüşte baslangıç değerini 1 artıracak
            for (int sayi = 1; sayi < 11; sayi++)
            {
                toplam= toplam + sayi; // toplam += sayi;

            }
            Console.WriteLine($"1-10 arası sayıların tolamı : {toplam}");


            #endregion

        }
    }
}
