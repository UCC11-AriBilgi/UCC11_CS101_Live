using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Operators
{
    internal class As
    {
        public static void Main(string[] args)
        {
            Console.Clear(); // ekranı temizler

            Console.WriteLine("******************************************");
            Console.WriteLine("*                                        *");
            Console.WriteLine("* KARŞILAŞTIRMA OPERATÖR ÖRNEKLERİ       *");
            Console.WriteLine("*                                        *");
            Console.WriteLine("******************************************");

            #region 4.1 As Operatoru
            // Tüm veri tiplerinden object türüne ve/veya object veri türünden referans değişgenlerine dönüşüm işlemi yapar. Eğer herhangi bir dönüşüm işlemi yapılamıyorsa sonuc olarak null değeri geri döner.
            // 

            object s = "50"; // object veri türü tanımlandı ve içine string bir değer konuldu.
            string t = s as string; // s değişgenini gerçekten string olarak t değişgeni içine atayacaktır.

            int u = 100;

            object v= u as object;

                        // string interpolation
            Console.WriteLine($"s = {s} - t = {t} - u = {u} - v = {v}\n\n");

            #endregion


        }
    }
}
