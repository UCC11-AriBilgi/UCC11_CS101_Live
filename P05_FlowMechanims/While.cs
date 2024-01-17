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

            //int toplam = 0;

            //int sayi = 0;

            //while (sayi < 100) // direkt olarak kontrol..doğruysa bloğu çalıştır.
            //{
            //    toplam += sayi;

            //    sayi++; // bir sonraki sayıya geçişi kendim sağlamış oldum.
            //}

            //Console.WriteLine($"Toplam = {toplam}");


            #endregion


            #region while 2
            // Ekrandan girilen bir sayının basamaklarını bulma
            //int sayi; // ekrandan girilecek olan sayı
            //int basamak = 0;

            //Console.WriteLine("Lütfen sayınızı giriniz...");
            //sayi=Convert.ToInt32(Console.ReadLine());

            //while(sayi > 0)
            //{
            //    basamak++;

            //    sayi = sayi / 10;

            //}

            //Console.WriteLine("Girdiğiniz sayı " + basamak + " basamaklıdır..."  );

            #endregion


            #region while 3 (nested)
            //// devamlı sekilde...nested

            //Console.Write("Bir sayı giriniz : ");
            //int sayi=Convert.ToInt32(Console.ReadLine()) ;

            //int index = 1;

            //// İç içe while döngüleri
            //while (index <= sayi) // olduğu sürece
            //{
            //    Console.WriteLine();

            //    int j = 1;

            //    while (j <= index) 
            //    {
            //        Console.Write("* ");
            //        j++;
            //    }

            //    index++;
            //}

            #endregion

            #region nested while 2--> do while

            // ekrana 4 işlem için bir mesaj çıkartıp,seçenek öğrenilip buna göre gerekli yerlere dallanıp işlemi gerçekleştirmek

            char choice;
            int MenuOption;
            int Number1, Number2;

            do
            {
                Console.WriteLine("1.Toplama, 2.Çıkarma, 3.Çarpma, 4.Bölme"  ); // bir anlamda menü

                MenuOption=Convert.ToInt32(Console.ReadLine());

                switch (MenuOption)
                {
                    case 1:
                        Console.WriteLine("sayılarınızı giriniz:");
                        Number1=Convert.ToInt32(Console.ReadLine()) ;
                        Number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Sonuç : {Number1 + Number2}");
                        break;

                    case 2:
                        Console.WriteLine("sayılarınızı giriniz:");
                        Number1 = Convert.ToInt32(Console.ReadLine());
                        Number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Sonuç : {Number1 - Number2}");
                        break;

                    case 3:
                        Console.WriteLine("sayılarınızı giriniz:");
                        Number1 = Convert.ToInt32(Console.ReadLine());
                        Number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Sonuç : {Number1 * Number2}");
                        break;

                    case 4:
                        Console.WriteLine("sayılarınızı giriniz:");
                        Number1 = Convert.ToInt32(Console.ReadLine());
                        Number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Sonuç : {Number1 /Number2}");
                        break;


                    default:
                        Console.WriteLine("Geçersiz seçenek");
                        break;
                }

                Console.WriteLine("Lütfen devam etmek için d tuşuna basınız, diğer tuşlar çıkar.."  );

                choice=Convert.ToChar(Console.ReadLine());

            } while (Char.ToUpper(choice)== 'D'); // Büyük D olması kontrol ediliyor...



            #endregion




        }
    }
}
