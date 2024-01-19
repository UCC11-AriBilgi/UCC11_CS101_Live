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
            int[] sayilar1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            int toplam1 = 0; // dizi toplamını tutacak

            for (int index = 0; index < sayilar1.Length; index++)
            {
                toplam1 += sayilar1[index];
            }

            Console.WriteLine("Dizinin toplamı (for ile) = " + toplam1);

            #endregion




        }
    }
}
