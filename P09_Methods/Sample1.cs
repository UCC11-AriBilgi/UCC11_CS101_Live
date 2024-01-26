using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09_Methods
{
    internal class Sample1
    {
        public static void Main(string[] args)
        {
            // Bir dikdortgenin alanını hesaplayan bir metodun 4 farklı seklinin incelenmesi

            #region 1. Geriye değer döndürmeyen ve parametre almayan metot örneği
            // Burada yazmış olduğumuz metodu çağırıyoruz.
            //Hesapla();

            #endregion

            #region 2. Geriye değer döndürmeyen ve parametre alan metot örneği
            //Console.WriteLine("Kısa kenar : ");
            //int kk = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Uzun kenar : ");
            //int uk = Convert.ToInt32(Console.ReadLine());

            //Hesapla(kk, uk);

            #endregion

            #region 3. Geriye değer döndüren ve parametre almayan metot örneği
            //int sonuc = HesaplaPrmsiz(); // metoda git...dönen değeri sonuc değişgenine al

            //Console.WriteLine($"\n\nDikdörgenin alanı(3) = {sonuc}");

            #endregion

            #region 4. Geriye değer döndüren ve parametre alan metot örneği
            Console.WriteLine("Kısa kenar : ");
            int kk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Uzun kenar : ");
            int uk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\n\nDikdörgenin alanı(4) = {HesaplaPrmli(kk,uk)}");

            #endregion

        }

        // Metotlarımız
        // region1
        private static void Hesapla()
        {
            Console.WriteLine("Kısa kenar : ");
            int kk=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Uzun kenar : ");
            int uk=Convert.ToInt32(Console.ReadLine());

            int alan = kk * uk;

            Console.WriteLine($"\n\nDikdörgenin alanı(1) = {alan}");
        }

        // region2
        private static void Hesapla(int pKisa,int pUzun)
        {
            int alan = pKisa * pUzun;

            Console.WriteLine($"\n\nDikdörgenin alanı(2) = {alan}");

        }


        // region3
        private static int HesaplaPrmsiz()
        {
            // Geriye değer döndüren metotlar/fonksiyonlarda mutlaka return keywordunu kullanmalıyız.
            Console.WriteLine("Kısa kenar : ");
            int kk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Uzun kenar : ");
            int uk = Convert.ToInt32(Console.ReadLine());

            int alan = kk * uk;

            return alan; // alan değerini geriye postala
        }

        // region4
        private static int HesaplaPrmli(int pKisa,int pUzun)
        {
            return pKisa * pUzun;
        }

    }
}
