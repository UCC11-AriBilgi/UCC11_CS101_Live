using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Operators
{
    internal class Mantiksal
    {
        public static void Main(string[] args)
        {
            Console.Clear(); // ekranı temizler

            Console.WriteLine("******************************************");
            Console.WriteLine("*                                        *");
            Console.WriteLine("* MANTIKSAL OPERATÖR ÖRNEKLERİ           *");
            Console.WriteLine("*                                        *");
            Console.WriteLine("******************************************");

            #region 6.1 
            // Değişgenlerimizi/sabitlerimizi mantıksal olarak ve,veya,değil işlemlerine sokan operatörler. ve(&&) veya(||) değil (!)

            bool D = 35 > 10 && 10 == 50;

            bool E = 35 > 10 && 10 != 50;

            bool F = 5 is int || 45 / 5 == 9;

            bool G = 5 < 4 || 45 / 5 == 9;

            bool H = !(5 < 4);


            // string interpolation
            Console.WriteLine($"D = {D} - E = {E} - F = {F} - G = {G} - H = {H}\n\n");

            #endregion


        }
    }
}
