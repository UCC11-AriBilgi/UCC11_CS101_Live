using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_FlowMechanims
{
    internal class While
    {
        public static void Main(string[] args)
        {
            Console.Clear(); // ekranı temizler

            Console.WriteLine("******************************************");
            Console.WriteLine("*                                        *");
            Console.WriteLine("* WHILE ÖRNEKLERİ                        *");
            Console.WriteLine("*                                        *");
            Console.WriteLine("******************************************\n\n\n");

            #region while 1
            // 1 den 100 e kadar sayıların toplamı

            int toplam = 0;

            int sayi = 0;

            while (sayi < 100) // direkt olarak kontrol..doğruysa bloğu çalıştır.
            {
                toplam += sayi;

                sayi++; // bir sonraki sayıya geçişi kendim sağlamış oldum.
            }

            Console.WriteLine($"Toplam = {toplam}");


            #endregion




        }
    }
}
