using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Operators
{
    internal class Matematiksel
    {
        public static void Main(string[] args)
        {
            Console.Clear(); // ekranı temizler

            Console.WriteLine("******************************************");
            Console.WriteLine("*                                        *");
            Console.WriteLine("* MATEMATİKSEL OPERATÖR ÖRNEKLERİ        *");
            Console.WriteLine("*                                        *");
            Console.WriteLine("******************************************");

            #region 1. Standart operatörler
            // Normal işlemler
            //int x = 10;
            //int y = 8;

            //int toplam = x + y;
                        
            //int top1;

            //top1 = x + y;

            //int fark = x - y;

            //int carpim = x * y;

            //int bolum = x / y;

            //int mod = x % y; // Bölüm sonucu kalan değere ihtiyacımız olduğunda

            //Console.WriteLine("Toplam = " + toplam);
            //Console.WriteLine("Toplam = " + top1 + "\n\n");
            //Console.WriteLine("Fark = " + fark+"\n\n");
            //Console.WriteLine("Çarpım = " + carpim+"\n\n");
            //Console.WriteLine("Bölüm = " + bolum + "\n\n");
            //Console.WriteLine("Mod = " + mod + "\n\n");

            ////Console.WriteLine("Sonuç : h={0}\ti={1}\tj={2}\tk={3}\tl{4}\n\n", h, i, j, k, l);

            //// string interpolation
            //Console.WriteLine($"Toplam = {toplam} \n Fark = {fark} \n Çarpım = {carpim} - Bölüm = {bolum} - Mod = {mod}\n\n");

            #endregion

            #region 1.1 Değişik bir durum
            int sayi1 = 5;

            float sonuc11 = sayi1 / 2f;

            // Eğer işlem yapılan her iki operand birbirinden farklı veri türündeyse sonuç daha üst kapasiteli veri tipinde tutulur.

            Console.WriteLine("Sonuc 1.1 = " + sonuc11 + "\n\n");

            #endregion

            #region 1.2 Ancak...durumu
            int sayi2 = 2;
            int sayi3 = 5;
            float sayi4 = 2f;

            float sonuc12= sayi2 / sayi3 / sayi4; // 2/5/2f
            // İşlem yapılırken daha 2. aşamada siyı2 ve 3 int olduğunda sonuc 0 lanır 0/2f


            Console.WriteLine("Sonuc 1.2 : " + sonuc12 + "\n\n");

            #endregion


            #region 1.3 Diğer bir durum....
            int sayi5 = 2;
            int sayi6 = 5;
            float sayi7 = 2f;

            float sonuc13 = sayi7 / sayi6 / sayi5;
            // sonuc bastan virgüllü bir sayı cıkacak

            Console.WriteLine("Sonuc 1.3 : " + sonuc13 + "\n\n");


            #endregion

            #region 1.4 Daha ilginç...

            float sonuc14 = 2f / 5 / 2 / 5f / 7 / 4 / 9 / 3 / 4;

            Console.WriteLine("Sonuc 1.4 : " + sonuc14 + "\n\n");

            #endregion

        }
    }
}
