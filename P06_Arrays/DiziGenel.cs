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

            //int[] dizi = new int[20]; // 20 elemanlı dizi tanımlandı.

            //dizi[5]= 30; // dizi ismindeki dizinin 5.indexine 30 sayısını atıyorum...

            //Console.WriteLine("Dizinin elemanı : " + dizi[5]); // ekrana yazdırıyorum...


            //// Şöyle de bir tanımlama olabilir..
            //// Diziyi daha yaratırken içine ilk değerleri vermek

            //string[] strdizi = { "Bir", "İki", "Üç" };
            //int[] intdizi = { 2, 6, 7, 23 };
            //float[] floatdizi = { 2f, 1.2f, 5f };

            // Ancak yukardaki gibi bir kullanım ancak ve ancak dizi ilk tanımlanırken yapabiliriz.Yani asağıdaki gibi bir kullanım yanlıştır. hata verecektir

            //int[] intdizi2;
            //intdizi2 ={ 3,4,5};

            // Dinamik bir şekilde yaratabiliriz

            //Console.WriteLine("Lütfen 1..10 arasında bir değer giriniz...");
            //int boyut=Convert.ToInt32(Console.ReadLine());

            //int[] intdizi3=new int[boyut]; // dinamik olarak yaratılıyor.

            //intdizi3[6] = 100;

            //Console.WriteLine(intdizi3[6]);


            // Birden fazla diziyi tek satırda yaratma
            //int[] intdizi4 = new int[10], intdizi5 = new int[20];

            // 5 elemanlı bir string dizi tanımlayıp,ilk elemanlarını belirleyip
            // daha sonrada ekrana ters sırada...yani dizini en sonundaki eleman ilk yazılacak sekilde....

            string[] myUCC11Team = { "Şevval", "Abdullah", "Furkan Emre", "Ferit", "scrat" };

            // dolayısıyla benim dizinin boyutunu öğrenmem gerekiyor...

            // asağıdaki hazır bir sistem fonksiyonu/metodu kullanarak dizin boyutu öğrenilebilir
            int son = myUCC11Team.Length - 1; // diziler 0. indexden basladığı için.

            for (int index = son; index >= 0; index--)
            {
                Console.WriteLine(myUCC11Team[index]); // o anki indexdeki bulunan eleman değerini yaz
            }



            #endregion


        }
    }
}
