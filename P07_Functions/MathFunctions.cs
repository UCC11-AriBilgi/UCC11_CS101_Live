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

            #region Abs/Mutlak değer Metodu
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

            #region Min/Max Metodu
            // Min metodu, parametre olarak verilen iki sayıdan küçük olanı döndüren metod'dur. Bu metot bütün sayı türleri tarafından kullanılabilmektedir.

            /*
             int sonuc=Math.Min(int sayi1,int sayi2);

            float sonuc=Math.Min(float sayi1,float sayi2);

            double sonuc=Math.Min(double sayi1,double sayi2);

            decimal sonuc=Math.Min(decimal sayi1,decimal sayi2);
            
            byte sonuc=Math.Min(byte sayi1,byte sayi2);

            long sonuc=Math.Min(long sayi1,long sayi2);

            short sonuc=Math.Min(short sayi1,short sayi2);

            unit sonuc=Math.Min(unit sayi1,unit sayi2);

            sbyte sonuc=Math.Min(sbyte sayi1,sbyte sayi2);

            ulong sonuc=Math.Min(ulong sayi1,ulong sayi2);

            ushort sonuc=Math.Min(ushort sayi1,ushort sayi2);

             */

            //Max metodu, parametre olarak verilen iki sayıdan büyük olanı döndüren metod'dur. Bu metot bütün sayı türleri tarafından kullanılabilmektedir. 

            //int sonuc = Math.Max(int sayi1, int sayi2);

            //float sonuc = Math.Max(float sayi1, float sayi2);

            //double sonuc = Math.Max(double sayi1, double sayi2);

            //decimal sonuc = Math.Max(decimal sayi1, decimal sayi2);

            //byte sonuc = Math.Max(byte sayi1, byte sayi2);

            //long sonuc = Math.Max(long sayi1, long sayi2);

            //short sonuc = Math.Max(short sayi1, short sayi2);

            //unit sonuc = Math.Max(unit sayi1, unit sayi2);

            //sbyte sonuc = Math.Max(sbyte sayi1, sbyte sayi2);

            //ulong sonuc = Math.Max(ulong sayi1, ulong sayi2);

            //ushort sonuc = Math.Max(ushort sayi1, ushort sayi2);

            //int sayi1 = 37;

            //int sayi2 = 10;

            //int sonuc = Math.Max(sayi1, sayi2);

            //Console.WriteLine("İki sayıdan büyük olan sayı =" + sonuc);

            int sayi1 = 400;
            int sayi2 = 230;

            int sonuc1 = Math.Min(sayi1, sayi2);
            int sonuc2=Math.Max(sayi1, sayi2);

            Console.WriteLine("Küçük sayı " + sonuc1+ "\n\n");
            Console.WriteLine("Büyük sayı " + sonuc2 + "\n\n");



            #endregion

            #region Pow Metodu

            int sayi3 = 2;

            int sayi4 = 10;

            Console.WriteLine("Sonuc = " + Math.Pow(sayi3,sayi4) + "\n\n");


            #endregion

            #region Round Metodu
            // Round metodu, parametre olarak verilen ondalıklı sayıyı en yakın tam sayıya yuvarlama işlemi yapmaktadır. Örneğin : 3.01 ise 3'e yuvarlar, 3.49 ise 3'e yuvarlar, 3.51 ise 4'e yuvarlar.

            //double sonuc = Math.Round(2.49);

            //Console.WriteLine(sonuc);
            ////Ekrana 2 yazar

            //double sonuc1 = Math.Round(2.50);

            //Console.WriteLine(sonuc1);
            ////Ekrana 3 yazar

            //double sonuc2 = Math.Round(2.01);

            //Console.WriteLine(sonuc2);
            ////Ekrana 2 yazar

            //double sonuc3 = Math.Round(2.55);

            //Console.WriteLine(sonuc3);
            ////Ekrana 3 yazar

            Console.WriteLine(Math.Round(2.49));
            Console.WriteLine(Math.Round(2.2));
            Console.WriteLine(Math.Round(2.59));
            Console.WriteLine(Math.Round(3.87));

            #endregion

            #region Sqrt Metodu
            // Sqrt metodu, karakök bulmak için kullanılmaktdır. Double türünde verilen sayının karekökünü double türünde geri döndüren metot'tur.

            //Console.WriteLine("Karekökünü bulmak istediğiniz sayıyı giriniz");

            //double sayi = double.Parse(Console.ReadLine());

            //double sonuc = Math.Sqrt(sayi);

            //Console.WriteLine(sonuc);

            #endregion

            #region BigMul Metodu
            //BigMul metodu parametre olarak verilen 2 adet int tamsayının çarpımını,  long türünde geri döndüren metod'dur.

            //int sayi1 = 37;

            //int sayi2 = 28;

            //long sonuc = Math.BigMul(sayi1, sayi2);

            //Console.WriteLine(sonuc);


            #endregion

            #region Ceiling Metodu
            //Ceiling metodu, parametre olarak verilen ondalıklı sayıyı yukarıya veya tamsayının aynısına yuvarlama işlemi yapmak için kullanılmaktadır. Bu metodda virgülden sonra 0'dan başka herhangi bir sayı olduğunda yukarı yuvarlama işlemi yapmaktadır.

            //double sayi = 3.001;

            //double sonuc = Math.Ceiling(sayi);

            //Console.WriteLine(sonuc);
            ////Ekrana 4 yazacaktır.

            //sayi = 3.00;

            //sonuc = Math.Ceiling(sayi);

            //Console.WriteLine(sonuc);
            ////Ekrana 3 yazacaktır.

            #endregion

            #region Floor Metodu
            // Math.Floor(x) metodu, x olarak verilen ondalıklı sayıyı bir alt tamsayıya yuvarlar.

            //Console.WriteLine(Math.Floor(9.99));

            #endregion

            #region DivRem Metodu
            // Divrem metodu, bölme işleminde bölümü bulmak için kullanılan metod'dur. Bölünen ve bölen girildiğinde geriye bölme işleminin sonucunu veren ve 3. parametre olarak da kalanı veren parametredir. Sayısal veri türlerinin tümünde kullanılabilir.

            //int kalan;

            //Console.WriteLine("Lütfen bölünen sayıyı giriniz.");
            //int bolunen = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen bölen sayıyı giriniz.");
            //int bolen = Int32.Parse(Console.ReadLine());


            //int bolum = Math.DivRem(bolunen, bolen, out kalan);

            //Console.WriteLine("Bölme işleminde Bölüm={0}, Kalan={1}", bolum, kalan);

            #endregion

            #region Sign Metodu
            //Sign metodu, parametre olarak verilen sayının negatif mi, pozitif mi, sıfıra eşit mi olduğunu bulmak için kullanılmaktadır. Geriye döndürdüğü değerler:

            // 0 : Geriye 0(sıfır) döndürdüğünde Sıfıra eşit demektir.
            // 1 : Geriye 1(bir) döndürdüğünde Pozitif demektir.
            //- 1 : Geriye - 1(eksi bir) döndürdüğünde Negatif demektir.

            //Console.WriteLine("Lütfen bir sayı giriniz");
            //int sayi = Int32.Parse(Console.ReadLine());

            //int sonuc = Math.Sign(sayi);

            //switch (sonuc)
            //{
            //    case 0: Console.WriteLine("Sayı Sıfıra Eşit"); break;
            //    case 1: Console.WriteLine("Sayı Pozitif"); break;
            //    case -1: Console.WriteLine("Sayı Negatif"); break;

            //    default: Console.WriteLine("Yanlış Değer Girildi"); break;
            //}

            #endregion


        }
    }
}
