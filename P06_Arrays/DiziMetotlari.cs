using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Arrays
{
    internal class DiziMetotlari
    {
        public static void Main(string[] args)
        {

            #region Dizi metotları

            // GetLength

            //int[] dizi1 = { 1, 2, 3, 4,5,6,7,8 };

            //Console.WriteLine("Tek boyutlu dizinin uzunluğu : " + dizi1.GetLength(0) + "\n\n");


            //int[,] dizi2 = { { 2, 4, 2, 4 }, { 7, 67, 34, 5 }, { 5, 7, 9, 6 }, { 3, 5, 6, 7 } };

            //Console.WriteLine("İki boyutlu dizinin uzunluğu : "+ dizi2.GetLength(1) + "\n\n");

            //// create instance ****

            //Array dizi3 = Array.CreateInstance(typeof(int), 5);
            //// int türünden 5 elemanlı bir dizi tanımlantı(dizi3 isminde) ve dolayısıyla dizinin herbir elemanı int türünden varsayılan değeri atandı.

            //Array dizi4=Array.CreateInstance(typeof(int), 3,2,5);
            //// 3x2x5 boyutunda 3 boyutlu bir dizi tanımlandı.

            //// Bir kullanım şekli

            //// farklı bir gösterim ve ilginç bir kullanım
            //int[] dizi5 = new int[5] { 2, 3, 4, 6, 5 }; // diziyi yaratırken ilk değerlerini atama

            //Array dizi6 = Array.CreateInstance(typeof(int), dizi5);
            //// Burada ilginç bir yöntemle
            //// 2x3x4x6x5 boyutunda 5 boyutlu bir dizi yaratılmış oldu...

            //// Dikkat..CreateInstance yöntemiyle yaratılan dizilere diziadı[0,4] olarak erişmemiz mümkün olmuyor. Bunun yerine asağıdaki gibi yöntem kullanılıyor.
            //Array dizi7 = Array.CreateInstance(typeof(int), 5, 4, 3);

            //for (int i = 0; i <= dizi7.GetUpperBound(0); i++) // GetUpperBound bir dizinin en son index numarasını geri döndürür.
            //    for (int j = 0; j <= dizi7.GetUpperBound(1); j++)
            //        for (int k = 0; k <= dizi7.GetUpperBound(2); k++)
            //            dizi7.SetValue(i + j + k, i, j, k);
            //// normal sekilde değer atama yerine genelde SetValue metodu kullanılarak atama işlemi gerçekleştirilir.

            // Dizileri   kopyalamak

            //int[] dizi8 = { 1, 2, 3, 4 };

            //int[] dizi9 = new int[10];

            //dizi8.CopyTo(dizi9, 3); // Burada dizi8 in tüm elemanları dizi9 a 3.indexten itibaren kopyalıyor.

            #endregion


            #region Dizi Sıralama
            //Array sehir = Array.CreateInstance(typeof(string), 8);

            //// SetValue metoduyla diziyi dolduralım

            //sehir.SetValue("Ankara", 0);
            //sehir.SetValue("İstanbul", 1);
            //sehir.SetValue("İzmir", 2);
            //sehir.SetValue("Bursa", 3);
            //sehir.SetValue("Adıyaman", 4);
            //sehir.SetValue("Mersin", 5);
            //sehir.SetValue("Van", 6);
            //sehir.SetValue("Urfa", 7);


            //Console.WriteLine("Sırasız dizi...");

            //foreach (string isim in sehir)
            //{
            //    Console.WriteLine("Şehir adı : "+ isim  );
            //}

            //Console.WriteLine("\n\nSıralı hali..");

            //Array.Sort(sehir); // sehir isimli dizimi sırala

            //foreach (string isim in sehir)
            //{
            //    Console.WriteLine("Şehir adı : " + isim);
            //}


            //Array sayisal = Array.CreateInstance(typeof(int), 8);

            //// SetValue metoduyla diziyi dolduralım

            //sayisal.SetValue(200, 0);
            //sayisal.SetValue(100, 1);
            //sayisal.SetValue(5, 2);
            //sayisal.SetValue(1, 3);
            //sayisal.SetValue(15, 4);
            //sayisal.SetValue(13, 5);
            //sayisal.SetValue(51, 6);
            //sayisal.SetValue(88, 7);


            //Console.WriteLine("\n\nSırasız sayısal dizi...");

            //foreach (int sayi in sayisal)
            //{
            //    Console.WriteLine("Sayı : " + sayi);
            //}

            //Console.WriteLine("\n\nSıralı sayısal hali..");

            //Array.Sort(sayisal); // sayısal isimli dizimi sırala

            //foreach (int sayi in sayisal)
            //{
            //    Console.WriteLine("Sayı : " + sayi);
            //}



            #endregion


            #region Dizilerde arama

            int[] dizi28 = { 500, 35, 56, 2, 8 };

            Array.Sort(dizi28);

            foreach (int sayi in dizi28)
            {
                Console.WriteLine(sayi);
            }

            Console.Write("dizi28 index : " + Array.BinarySearch(dizi28,350) + "\n\n");
            // ilgili değeri dizi içinde arar. eğer bulursa bulduğu bu nesnenin indexini tutar, bulamazsa da negatif bir sayı üretir.Not.Binary Search metodunun doğru bir şekilde çalışabilmesi için diziyi Sort metodu ile öncelikle sıralamalıyız.



            #endregion


        }


    }
}
