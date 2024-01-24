using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_Functions
{
    internal class StringFunctions
    {
        public static void Main(string[] args)
        {
            Console.Clear(); // ekranı temizler

            Console.WriteLine("******************************************");
            Console.WriteLine("*                                        *");
            Console.WriteLine("* STRING METOT/FONKSİYON ÖRNEKLERİ       *");
            Console.WriteLine("*                                        *");
            Console.WriteLine("******************************************\n\n\n");

            #region Length Metodu
            // Verilen metin bilgisinin kac karakter olduğunu söyler..Integer türünden bir veri döndürür

            //string metin1 = "MCSD C# Dersleri";

            //int sonuc1 = metin1.Length;

            //Console.WriteLine($"Karakter adedi {sonuc1}");


            #endregion

            #region ToLower, ToUpper
            // verilen bir metni küçük harften büyüğe, büyük haften küçüğe çevirmek için

            //string metin2 = "mcsd c# dersleri";
            //string metin3 = "MCSD C# DERSLERİ";

            //string ymetin2 = metin2.ToUpper();
            //string ymetin3 = metin3.ToLower();

            //Console.WriteLine($"Eski metin2 {metin2}  Yeni durumu {ymetin2}\n\n");
            //Console.WriteLine($"Eski metin3 {metin3}  Yeni durumu {ymetin3}\n\n");

            #endregion


            #region Trim
            // Bir string bilginin başında ve sonunda bulunan extradan varolan boşluk karakterlerini kaldırmak için kullanılır

            //string metin4 = "     mcsd c# dersleri      ";

            //string ymetin4 = metin4.Trim();

            //Console.WriteLine($"Eski metin4 {metin4}  Yeni durumu {ymetin4}\n\n");

            #endregion

            #region Contains
            // Geriye boolean olarak bir değer döndürür.Belirtilen metin bilgisi içinde yine belirtmiş olduğumuz karakter veya karakterlin olup olmadığına bakar. Büyük/küçük harf duyarlı çalışır.

            //string metin5 = "Arı Bilgi MCSD 300 Kursu";

            //bool varmiyokmu=metin5.Contains("kur");

            //Console.WriteLine($"Metnim {metin5} Kur dizesi içinde var mı? {varmiyokmu}");


            #endregion


            #region ToCharArray
            // verilen bir metin bilgisini karaktersel bir dizi durumuna çevirir

            string metin6 = "Benim adım Ümit Karaçivi";

            char[] charArray=metin6.ToCharArray();

            foreach (char c in charArray)
            {
                Console.Write(c);
            }


            #endregion



        }

    }
}
