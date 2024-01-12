using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Operators
{
    internal class Atama
    {

        public static void Main(string[] args)
        {
            Console.Clear(); // ekranı temizler

            Console.WriteLine("******************************************");
            Console.WriteLine("*                                        *");
            Console.WriteLine("* ATAMA OPERATÖR ÖRNEKLERİ               *");
            Console.WriteLine("*                                        *");
            Console.WriteLine("******************************************");

            #region 7.1 
            // = operatörüyle ilgili bir iki birşey
            // = operatörünün sol tarafında kesinlikle sadece bir değişgen olmalı.Örneğin şu hatalı bir kullanım
            //int i = 0, j = 0;
            //i + j = 20;

            // = operatöründeki işlemler hep "sağdan sola" doğru gerçekleşir ve = operatörü operandlarıyla birlikte atadığı değerleri tutar..

            byte M = 75, N = 32, O = 0; ;

            Console.WriteLine($"Öncesi Sonuç : M={M} - N={N} - O={O}"); // string interpolation

            Console.ReadKey();

            O = N = M;

            Console.WriteLine($"Sonrası Sonuç : M={M} - N={N} - O={O}"); // string interpolation

            #endregion


        }
    }
}
