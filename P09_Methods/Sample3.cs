using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09_Methods
{
    internal class Sample3
    {
        public static void Main(string[] args)
        {
            // Erkeklerin 25 yıl,kadınların da 20 yıl çalıştıktan sonra emekli olacağı varsayılan bir ortamda,
            // ekrandan alınan cinsiyet ve sigorta prim gün sayısına göre kişinin emekliliğine ne kadar süre kaldığını hesaplayan metodu yazınız.

            // Açıklama..Kabuller
            //
            // 1 yıl = 360 gün
            // 1 ay = 30 gün
            // Erkekler(E) için 9000 gün
            // Kadınlar(K) için 7200 gün çalışma günü
            //
            // baz alınacaktır.
            // Örnek 1943 gün --> 5 yıl 4 ay 23 gün

            // Bu örnekteki metoda cinsiyet parametresini de ekleyerek buna göre bulunan sonucu ekrana yazdırınız..

            // Örnek: Erkek ve 6643 gün parametreleri olduğunda ekrana yazılacak bilgi

            // Emekliliğinize 6 yıl 6 ay 17 gün kaldı şeklinde olsun...

            // Baz alınan değerler
            int Year = 360;
            int Month = 30;
            int dayCount; // ekrandan alınacak gün sayısını tutacak değişgen
            string gender; // alınacak cinsiyet bilgisi





        }

        // Metotlar
        private static int EmeklilikHesap(string pGender,int pDay)
        {// Kaç gün kaldığını bulacağız.

            int dayForWoman = 7200;
            int dayForMan = 9000;
            int day=0;

            switch (pGender)
            {
                case "E":
                    day= dayForMan - pDay;
                    break;
                case "K":
                    day = dayForWoman - pDay;
                    break;
                default:
                    break;
            }

            return day;
        }
    }
}
