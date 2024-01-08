using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_TypeConversion
{
    // Yani burada sadece implicit örnekleri bulunacak

    internal class Bilincsiz_Implicit
    {
        // burası da bu classın giriş noktası

        public static void Main(string[] args)
        {
            // Bilinçsiz tür dönüşümleri

            byte a = 10;

            short b = 20;

            sbyte c = 30;

            // 3 farklı veri yapısında değişler tanımlandı.

            int d = a + b + c; // küçük vt --> buyuk vt oto geçiş

            string e = "ARI Bilgi Project";

            char f= 'A'; // char da tek tırnak

            object g = e + " " + f + " " + d; // string char ve int birleştirmesi yapıldı.

            long h = d; // int -> long

            float i = h; // long-> float

            double j = i; // float -> double

            double k = 21.5; // decimal -> double

            Console.WriteLine("1.durum (d) : " + d.ToString());

            Console.WriteLine("2.durum (g) : " + g.ToString());
            double sonuc = h + k;

            Console.WriteLine("3.durum (h ve k) : " + sonuc);






        }
    }
}
