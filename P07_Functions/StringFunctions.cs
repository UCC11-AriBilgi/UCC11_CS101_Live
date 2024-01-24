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

            //string metin6 = "Benim adım Ümit Karaçivi";

            //char[] charArray=metin6.ToCharArray();

            //foreach (char c in charArray)
            //{
            //    Console.Write(c);
            //}


            #endregion

            #region Substring
            //Substring(int StartIndex,int Uzunluk) türünden bir kullanımla startindex de tanımlamış olduğum indexden, uzunluk kadarını getirir
            //string metin7 = "Benim adım Ümit Karaçivi";

            //string uzunlukolmadan = metin7.Substring(10);

            //string uzunlukolarak= metin7.Substring(10,8);

            //Console.WriteLine(metin7 + "\n\n" + uzunlukolmadan + "\n\n" + uzunlukolarak );


            #endregion


            #region Remove,Insert
            //string testString = "Bizim sınıf C# MCSD sınıfı";

            //string removeString = testString.Remove(10);

            //string removeStringwIndex = testString.Remove(10,5);

            //Console.WriteLine(testString + "\n\n" + removeString + "\n\n" + removeStringwIndex );

            //string insertString = testString.Insert(5, " gdgdhkftykrk ");

            //Console.WriteLine(testString + "\n\n" + insertString);


            #endregion

            #region Compare
            // Karşılastırma işlemi yapar.Karakter karakter karşılastırır.
            // Karşılastırma işlemi sonrası bir değer döndürür
            // Geri dönen değer
            // 0 ise eşitlik (metin1=metin2)
            // 1 ise 1.metnin karsılastırılan karakterinin diğer karakterden büyük olduğu (metin1 > metin2)
            // -1 1.metnin karsılastırılan karakterinin diğer karakterden küçük olduğu (metin1 < metin2)


            //string metin8, metin9; // Karşılastırmaya girecek değerler

            //metin8 = "mcsdASDery";
            //metin9 = "MCSDASgfr";

            //int sonuc=String.Compare(metin8, metin9);

            //Console.WriteLine($"Sonuç {sonuc}");

            #endregion

            #region Concat
            // String ifadeleri birleştirmek için kullanılır
            // verilen ifadeleri ardı ardına ekler

            string metin10 = "Türkiye'nin başkenti ";
            string metin11 = "Ankara'dır ve nüfusu ";
            int nufus = 85;
            string metin12 = "milyondur..";


            string sonuc1 = String.Concat(metin10, metin11, nufus," ",metin12);

            Console.WriteLine(sonuc1);


            #endregion

            #region IndexOf,LastIndexOf
            // IndexOf - bir karakterin veya verilen bir dizedeki ilk rastladığı indexi geri döndürür. Eğer böyle bir şey yoksa -1 değeri(bulamadım) döndürür
            
            string testString = "Bizim sınıf C# MCSD sınıfı";

            int kPozisyon = testString.IndexOf('s');
            int strPozisyon = testString.IndexOf("zim");

            Console.WriteLine(testString + "\n\n");
            Console.WriteLine(kPozisyon + "\n\n");
            Console.WriteLine(strPozisyon + "\n\n");

            // LasIndexOf - bir karakterin veya verilen bir dizedeki son rastladığı indexi geri döndürür. Eğer böyle bir şey yoksa -1 değeri(bulamadım) döndürür
            int lPosisyon = testString.LastIndexOf('s');
            int lstrPozisyon = testString.LastIndexOf("MC");

            Console.WriteLine(testString + "\n\n");
            Console.WriteLine(lPosisyon + "\n\n");
            Console.WriteLine(lstrPozisyon + "\n\n");

            #endregion

            // Haftasonu çalışması
            // Kullanıcıdan bir string bilgi alacak uzun olabilir...
            // Girilen bilginin ilk ve son hecesi ekrana yazdırılacak
            // Hint - ayrıştırıcı olarak heceler arasındaki boşluk kullanılabilir

            // ....
        }

    }
}
