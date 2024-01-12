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
            Console.WriteLine("* ATAMA/İŞLEMLİ ATAMA OPERATÖR ÖRNEKLERİ *");
            Console.WriteLine("*                                        *");
            Console.WriteLine("******************************************");

            #region 7.1 
            // = operatörüyle ilgili bir iki birşey
            // = operatörünün sol tarafında kesinlikle sadece bir değişgen olmalı.Örneğin şu hatalı bir kullanım
            //int i = 0, j = 0;
            //i + j = 20;

            // = operatöründeki işlemler hep "sağdan sola" doğru gerçekleşir ve = operatörü operandlarıyla birlikte atadığı değerleri tutar..

            //byte M = 75, N = 32, O = 0; ;

            //Console.WriteLine($"Öncesi Sonuç : M={M} - N={N} - O={O}"); // string interpolation

            //Console.ReadKey();

            //O = N = M;

            //Console.WriteLine($"Sonrası Sonuç : M={M} - N={N} - O={O}"); // string interpolation

            #endregion Atama

            #region 7.2 İşlemli Atama ++,--
            // ++,-- gibi operatörler..
            // ++ görevi kullanılan değişgenin değerini 1 arttırmak için kullanılır a=a+1
            // -- görevi kullanılan değişgenin değerini 1 eksiltmek için kullanılır b=b-1

            //int x=15, y=20, z=30;
            //int a=7, b=10;

            //Console.WriteLine($"Öncesi Sonuç : x={x} - y={y} - z={z} - a={a} - b={b} \n\n"); // string interpolation

            //Console.ReadKey();

            //x++;

            //y++;

            //z++;

            //a--;

            //b--;

            //Console.WriteLine($"Sonrası Sonuç : x={x} - y={y} - z={z} - a={a} - b={b}"); // string 



            #endregion

            #region 7.2 İşlemli Atama +=,-=
            // += görevi sağındaki değişgen veya değer ile solundaki değişgen değerini toplayıp tekrardan operatörün solundaki değişgene atama işlemini yapar
            // -= görevi kullanılan .....çıkartıp....
            // *=,/=
            // %=,&=,^=

            int x = 15, y = 20, z = 30, a = 7, b = 10;

            Console.WriteLine($"Öncesi Sonuç : x={x} - y={y} - z={z} - a={a} - b={b} \n\n"); // string interpolation

            Console.ReadKey();

            x+=5; // x'e 5 ekledi tekrardan x'e atadı

            y+=3;

            z+=10;

            a-=10;

            b-=5;

            Console.WriteLine($"Sonrası Sonuç : x={x} - y={y} - z={z} - a={a} - b={b}"); // string 



            #endregion
        }
    }
}
