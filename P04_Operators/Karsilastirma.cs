using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Operators
{
    internal class Karsilastirma
    {
        public static void Main(string[] args)
        {
            Console.Clear(); // ekranı temizler

            Console.WriteLine("******************************************");
            Console.WriteLine("*                                        *");
            Console.WriteLine("* KARŞILAŞTIRMA OPERATÖR ÖRNEKLERİ       *");
            Console.WriteLine("*                                        *");
            Console.WriteLine("******************************************");

            #region 3.1 Karşılastırma op.
            // <, >, <=, >=, ==,!=
            // yapılan karşılastırma işleminin sonucu haliyle doğru/yanlış şeklinde olacaktır.(true/false) dolayısıyla bool(ean) türünden bir sonuç oluşturacaktır.

            bool m = 4 < 6;

            bool n = 6 > 5;

            bool o = 7 <= 7;

            bool p = 9 >= 12;

            bool q = 10 == 12;

            bool r = 1 != 8;

            // string interpolation
            Console.WriteLine($"m = {m} \n n = {n} \n o = {o} - p = {p} - q = {q} - r = {r}\n\n");



            #endregion


        }
    }
}
