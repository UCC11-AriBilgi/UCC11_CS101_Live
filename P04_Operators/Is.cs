using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Operators
{
    internal class Is
    {
        public static void Main(string[] args)
        {
            Console.Clear(); // ekranı temizler

            Console.WriteLine("******************************************");
            Console.WriteLine("*                                        *");
            Console.WriteLine("* IS OPERATÖR ÖRNEKLERİ                  *");
            Console.WriteLine("*                                        *");
            Console.WriteLine("******************************************");

            #region 5.1 Is Operatoru
            // Tanımlanan değişgen/sabit/ifadenin veri türünü kontrol eder. Eğer söz konusu olanlar verilen bir türle uyumluysa sonucu "true" yoksa "false" sonucu üretir. 

            int w = 50;

            bool y = w is int;

            bool z = w is double;

            bool A = 12 is byte; //??

            bool B = 'c' is string;

            bool C = 12f + 7 is int;

            // string interpolation
            Console.WriteLine($"w = {w} - y = {y} - z = {z} - A = {A} - B = {B} - C = {C}\n\n");

            #endregion


        }
    }
}
