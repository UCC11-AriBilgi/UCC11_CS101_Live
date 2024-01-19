using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Arrays
{
    internal class DiziGenel
    {
        public static void Main(string[] args)
        {


            #region Dizi tanımlama, değer atama ve kullanma

            // 20 elemanlı ..adı dizi olan ve tamsayı içerecek

            int[] dizi = new int[20]; // 20 elemanlı dizi tanımlandı.

            dizi[5]= 30; // dizi ismindeki dizinin 5.indexine 30 sayısını atıyorum...

            Console.WriteLine("Dizinin elemanı : " + dizi[5]); // ekrana yazdırıyorum...

            #endregion


        }
    }
}
