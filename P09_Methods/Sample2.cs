using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09_Methods
{
    internal class Sample2
    {
        public static void Main(string[] args)
        {
            #region Metotlarda aşırı yükleme (method overloading)

            Console.WriteLine("2'li toplama sonucu = {0}",toplamaIslemi(45,45) + "\n\n");

            Console.WriteLine("3'lü toplama sonucu = {0}", toplamaIslemi(45, 45,78) + "\n\n");

            Console.WriteLine("4'lü toplama sonucu = {0}", toplamaIslemi(45, 45,76,54) + "\n\n");

            #endregion

        }

        // Metotlar
        private static int toplamaIslemi(int pA, int pB)
        {// 2 sayıyı toplayan metot

            return pA + pB;
        }

        private static int toplamaIslemi(int pA,int pB,int pC)
        {// 3 sayıyı toplayan metot

            return pA + pB + pC;
        }

        private static int toplamaIslemi(int pA,int pB,int pC,int pD)
        {// 4 sayısı toplayan metot

            return pA+pB + pC + pD;
        }




    }
}
