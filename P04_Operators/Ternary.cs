using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Operators
{
    internal class Ternary
    {
        public static void Main(string[] args)
        {
            Console.Clear(); // ekranı temizler

            Console.WriteLine("******************************************");
            Console.WriteLine("*                                        *");
            Console.WriteLine("* TERNARY OPERATÖR ÖRNEKLERİ             *");
            Console.WriteLine("*                                        *");
            Console.WriteLine("******************************************");

            #region 8.1 
            // Bu operatör yine çok kullanılır. C# da 3 adet operand alan tek operatör.Verilen bir koşul durumuna göre verilen değerlerden birini tutar - object type'ı olarak...

            // Syntax : koşul ? eğer koşul duğruysa..değer : eğer koşul yanlışsa...değer

            Console.WriteLine("C# amcayı sevdiniz mi?");
            // ekrandan bir secenek okunacak
            string cevap=Console.ReadLine(); // ekrandan okuyorum...

            Console.WriteLine(cevap == "e" ? "D'accord .. Right answer..": "E napalım...Baska sefere...");

            #endregion
        }
    }
}
