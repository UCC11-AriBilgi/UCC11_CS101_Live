using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_Functions
{
    internal class MathFunctions
    {
        public static void Main(string[] args)
        {

            #region Abs/Mutlak değer
            /*
             Abs metodu verilen sayının mutlak değerini almak için kullanılmaktadır. Abs metodu parametre olarak farklı veri türlerinde değer alabilmekte ve aldığı veri türünde değer geri döndürmektedir. Yani int alıyorsa int , double alıyorsa double geri döndürür.

            Kullanım Syntax;

            int sonuc=Math.Abs(int sayi);

            double sonuc=Math.Abs(double sayi);

            float sonuc=Math.Abs(float sayi);

            long sonuc=Math.Abs(long sayi);

            decimal sonuc=Math.Abs(decimal sayi);

            short sonuc=Math.Abs(short sayi);

            sbyte sonuc=Math.Abs(sbyte sayi);



             */

            // Klavyeden girilen sayının mutlak değerini bulan programı yazınız

            //
            // Compute two absolute values.
            //
            //int value1 = -1000;
            //int value2 = 20;

            //int abs1 = Math.Abs(value1);
            //int abs2 = Math.Abs(value2);

            ////
            //// Write integral results.
            ////
            //Console.WriteLine(value1);
            //Console.WriteLine(abs1);
            //Console.WriteLine(value2);
            //Console.WriteLine(abs2);
            int sayi = -5;

            int sonuc=Math.Abs(sayi);

            Console.WriteLine("Ham veri : " +sayi);
            Console.WriteLine("Abs : " + sonuc);

            #endregion

            #region Min/Max
            // parametre olarak verilen iki sayıdan küçük olanını geriye donduren bir fonksiyondur.Bütün sayı turleri tarafından kullanılabilir

            int sayi1 = 400;
            int sayi2 = 230;

            int sonuc1 = Math.Min(sayi1, sayi2);
            int sonuc2=Math.Max(sayi1, sayi2);

            Console.WriteLine("Küçük sayı " + sonuc1+ "\n\n");
            Console.WriteLine("Büyük sayı " + sonuc2 + "\n\n");

            #endregion

            #region Pow 

            int sayi3 = 2;

            int sayi4 = 10;

            Console.WriteLine("Sonuc = " + Math.Pow(sayi3,sayi4) + "\n\n");


            #endregion

            #region Round
            // parametre olarak verilen ondalıklı bir sayıyı en yakın tamsayıya yuvarlama işlemi yapıyor.Yani 3.01-->3,3.51-->4 e gibi

            Console.WriteLine(Math.Round(2.49));
            Console.WriteLine(Math.Round(2.2));
            Console.WriteLine(Math.Round(2.59));
            Console.WriteLine(Math.Round(3.87));

            #endregion

            #region Sqrt Karekök alma


            #endregion

            #region Ceiling
            // Parametre olarak verilen ondalıklı sayıyı yukarıya veya tamsayının aynısına yuvarlama işlemi yapar.Bu metodda virgulden sonra 0 dan baska herhangi bir sayı olduğunda yukarı yuvarlama işlemi yapar...

            double sayi5 = 3.001;
            double sonuc5 = Math.Ceiling(sayi5);

            Console.WriteLine("Ceiling " + sonuc5 );

            #endregion

        }
    }
}
