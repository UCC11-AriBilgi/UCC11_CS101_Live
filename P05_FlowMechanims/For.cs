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
            //// 1 den 10 a kadar sayıların toplamını for dongüsüyle hesaplama

            //int toplam = 0; // Benim o anki toplam değerimi tutacak değişgen

            //// Başlangıç değerinden baslayacak, son değerden küçük olduğu sürece {} arasındaki bloğu çalıştıracak.ve herbir dönüşte baslangıç değerini 1 artıracak
            //for (int sayi = 1; sayi < 11; sayi++)
            //{
            //    toplam= toplam + sayi; // toplam += sayi;
            //}
            //Console.WriteLine($"1-10 arası sayıların tolamı : {toplam}");


            #endregion


            #region for.2 faktoriyel
            //Girdiğimiz herhangi bir sayının faktoriyelini bulma

            //float s;
            //int si, faktoriyel; // f1..Sonuc tutacak değişgen
            //bool a1 = true; // sayının negatiflik/pozitiflik durumunu belirleyen mantıksal değişgen

            //// Bu asağıdaki for gösteriminde esas sonucu bulacak döngüsel olay bloğun içinde. Ben sadece o bloğun çalışması giriş yapıyorum..
            //// 46.satırdaki yapıyı kullanıcıdan devamlı bir şekilde veri isteme için kullanabilirsiniz
            //for (;a1;)
            //{
            //    Console.Write("Lütfen faktöriyeli hesaplamak istediğiniz sayıyı giriniz : "  );

            //    s=Convert.ToSingle(Console.ReadLine());

            //    si = (int)s; // Tip zorlaması ile int e cevirme

            //    if (si!=s || s <1)
            //    {
            //        Console.WriteLine("Lütfen pozitif bir sayı giriniz...\n\n");
            //        a1 = false;
            //        // artık for çevrimi cıkıp gidecek...
            //    }
            //    else
            //    {
            //        // herşey uyumluysa...pozitif bir tamsayı girilmişse
            //        a1= true; // Kontrol değeri

            //        for (faktoriyel = 1; si > 1; si--)
            //        {
            //            faktoriyel *= si; // f1= f1 * si

            //        }

            //        Console.WriteLine("Faktöriyel sonucu = {0}\n\n",faktoriyel);

            //    }
            //}


            #endregion


            #region for.3
            // 1 den 1000'e kadar(sınırlar dahil olmak üzere) olan sayılar içinde 5'e tam bölünen ancak 7'ye tam bölünmeyen sayıları alt alta listeleyen ve bu sayıların kaç tane olduğu bulan ve toplamını gösteren bir program yazınız
            //            int toplam = 0;
            //            int adet = 0; // 
            //            int sayac;

            //            // ??
            //            for (sayac = 0; sayac < 1001; sayac += 5) // 2,3,4 zaten 5 den küçük
            //            {
            //                if (sayac % 35 == 0)

            ////                if (sayac % 5 == 0 && sayac % 7 != 0) // sayac % 35 == 0
            //                    continue;
            //                adet++; // olaya uyan sayı adedini 1 artır..

            //                toplam += sayac;

            //                Console.WriteLine("Sayı = {0}",sayac);

            //            }

            //            Console.WriteLine("Sayıların adedi : {0}\n\n",adet);

            //            Console.WriteLine("Sayıların toplamı : {0}\n\n",toplam);

            #endregion

            #region for.4 
            // Daily WorkOut....
            // Konsol ekranına girilen 0-100 (sınırlar dahil) arasındaki 3 notun en büyüğünü, en küçüğünü ve bunların ortalamasını ekrana gösteren programı yazınız...
            // ??
            // çok minimal anlamda bir sıralama algoritması

            // Öncelikle kullanacağım değişgenleri tanımlıyorum
            
            //int not; // Bu benim ekrandan alacağım not verisini tutacak olan değişgen
            //int bnot = 0; // Büyük olan notun tutulacağı değişgen
            //int knot = 0; // Küçük olan notun tutulacağı değişgen
            //int toplam = 0; // derslerin not toplamını tutacak değişgen

            //// ekrandan veri girişi yapılacak

            //// Aşağıdaki yapıyla dinamik bir şekilde ekrandan veri alma ve işlem yapma kullanılacak
            //for (int sayac = 0; sayac < 3; sayac++)
            //{
            //    Console.WriteLine(sayac + 1 +". sınav notunu giriniz : "); // dinamik yapı

            //    not=Convert.ToInt32(Console.ReadLine()); // notumu okudum

            //    if (not > 100 || not < 0) // Sınırlar dışında veri girdiyse
            //    {
            //        Console.Write("Geçersiz bir not girdiniz...Lütfen tekrar deneyiniz..");
            //        continue;
            //    }

            //    // Doğru bilgi girildiyse

            //    // ilk çalışma durumunda girilen değeri hem büyük hem de küçük olarak algılıyorum

            //    if (sayac == 0)
            //    {
            //        bnot = not;
            //        knot = not;
            //    }
            //    else
            //    {
            //        if (not > bnot)
            //        {
            //            bnot = not;
            //        }

            //        if (not < knot)
            //        {
            //            knot = not;
            //        }
            //    }

            //    toplam += not; // ekrandan girilen değeri toplam ekliyor
            //}

            //// Parametrik kullanı
            ////Console.WriteLine("\n\nEn büyük not : {0}\nEn küçük not : {1}\nOrtalama : {2}",bnot,knot,toplam/3);

            //Console.WriteLine($"\n\nEn büyük not : {bnot}\nEn küçük not : {knot}\nOrtalama : {toplam/3}");


            #endregion

            #region for.5
            //0 dan 100 e kadar olan sayıları 5er 5er artışlı olacak şekilde ve bir satırda 6 adet sayı yazacak(yanyana) şekilde gösteriniz/listeleyiniz. Not: Gösterilecek sayılar arasında da görünüm karmasıklığını azaltmak açısından biraz boşluk 1-2 karakter..bırakınız..(sistem gereklilikleri dokümanı)
            // 
            // a  b  c  d  e  f
            // g  h  ı  i  j  k
            // ....

            int satiradet = 0; // tek bir satırda yazılacak olan eleman sayısı

            for (int sayi = 0; sayi <= 1000; sayi+=3) // 5'er artış
            {
                if (satiradet % 9 == 0) //demekki bir satırı doldurmuşum..Bir alt satıra geçebilirim..
                {
                    Console.WriteLine(); // bir alt satıra geç
                }

                Console.Write("{0}\t",sayi); // biraz boşluklu

                satiradet++;
            }

            Console.WriteLine("\n\nBitti...");

            #endregion

        }
    }
}
