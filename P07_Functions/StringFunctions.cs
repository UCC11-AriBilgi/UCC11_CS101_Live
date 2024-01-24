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

            string metin1 = "MCSD C# Dersleri";

            int sonuc1 = metin1.Length;

            Console.WriteLine($"Karakter adedi {sonuc1}");


            #endregion

            #region ToLower, ToUpper
            // verilen bir metni küçük harften büyüğe, büyük haften küçüğe çevirmek için

            string metin2 = "mcsd c# dersleri";
            string metin3 = "MCSD C# DERSLERİ";

            string ymetin2 = metin2.ToUpper();
            string ymetin3 = metin3.ToLower();

            Console.WriteLine($"Eski metin2 {metin2}  Yeni durumu {ymetin2}\n\n");
            Console.WriteLine($"Eski metin3 {metin3}  Yeni durumu {ymetin3}\n\n");





            #endregion

        }

    }
}
