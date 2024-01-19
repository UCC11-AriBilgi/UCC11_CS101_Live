using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Arrays
{
    internal class DiziDongu
    {
        public static void Main(string[] args)
        {
            #region dizilerde for/for each döngülerinin kullanımı

            // Örnek1 : Verilen bir tamsayı dizisinin elemanlarının toplamını for ve foreach yapılarını kullarak bulma

            // for yapısıyla
            //int[] sayilar1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            //int toplam1 = 0; // dizi toplamını tutacak

            //for (int index = 0; index < sayilar1.Length; index++)
            //{
            //    toplam1 += sayilar1[index];
            //}

            //Console.WriteLine("Dizinin toplamı (for ile) = " + toplam1);

            // foreach yapısıyla
            //int[] sayilar2 = { 55, 22, 13, 44, 51, 69, 77, 88, 19, 100, 11 };

            //int toplam2 = 0;

            //foreach (int sayi in sayilar2)
            //{
            //    toplam2 += sayi;
            //}

            //Console.WriteLine("Dizinin toplamı (foreach ile) = " + toplam2);

            #endregion

            #region for/foreach 2
            //// Örnek 5
            //// Tanımlana bir sayılar dizisi içersindeki sayıların negatif/pozitif olma durumlarına göre bunların durumlarını sayıyı yazarak yanına yazdırma, adetlerini de yazdırma

            //int[] sayilar = { -55, 22, 13, -54, -45, 5, 10 };
            //int pozitifadet=0, negatifadet=0;

            //foreach (int sayi in sayilar)
            //{
            //    if (sayi > 0)
            //    {
            //        Console.WriteLine(sayi + " ..Pozitif");
            //        pozitifadet++;
            //    }
            //    else
            //    {
            //        Console.WriteLine(sayi + " ..Negatif");
            //        negatifadet++;
            //    }
            //}

            //Console.WriteLine($"Dizideki\n\nPozitif sayı adedi {pozitifadet}\n\nNegatif sayı adedi {negatifadet}");


            #endregion

            #region foreach.3
            // Örnek
            // Kullanıcıdan bir metin girmesi istenecek(uzun olabilir)
            // Girilen bu string bilgi içindeki sesli harf sayının bulunması
            //
            // Öncelikle seslilerin tanımlandığı bir dizi tanımlayalım
            char[] sesliler = { 'a', 'e', 'i', 'ı', 'o', 'ö', 'u', 'ü' };

            // Metin içersinde bulduğum sesli harfleri yerleştireceğim bir dizi daha oluşturuyorum.
            char[] hangileri = new char[40];
            int hindex = 0; // hangileri dizisinin index bilgisini tutacak

            string metin = ""; // ekrandan alacağım metin
            int adet = 0; // sesli harf adedini tutacak

            Console.WriteLine("Lütfen metninizi giriniz...:");

            metin = Console.ReadLine().ToLower(); // ekran girilen metnin tümünu küçük harfe çevirir...

            // burada iç içe 2 tane for dongüsü kullanılarak

            // Kullanacağım 1.for döngüsü tanımlanmış olan sesliler dizisi üzerinde dolaşacak..karakteri alacak...metnin içinde arastırmayı 2.for döngüsü yapacak

            // 1.for döngüsü
            for (int indexsesli = 0; indexsesli < sesliler.Length; indexsesli++)
            {
                // 2.for döngüsü...Benim metin bilgim üzerinde dolasacak
                // not girilen metin değeri sanki bir diziymiş gibi kullanılabilir
                for (int indexmetin = 0; indexmetin < metin.Length; indexmetin++)
                {
                    if (metin[indexmetin] == sesliler[indexsesli])
                    {
                        // bunun hangi karakter olduğunu yaratmış olduğum ara diziye atıyorum
                        hangileri[hindex] = metin[indexmetin];
                        hindex++;

                        adet++;
                    }
                }
            }

            Console.WriteLine($"Girmiş olduğunuz metinde {adet} kadar sesli harf vardır...");

            Console.WriteLine(hangileri);

            #endregion




        }
    }
}
