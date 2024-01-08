using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_TypeConversion
{
    internal class Bilincli_Explicit
    {
        public static void Main(string[] args)
        {
            // Bilinli tür dönüşümleri

            int r = 1500;

            byte s = (byte)r;

            Console.WriteLine("5.durum : " + (s+r));

            Console.WriteLine("6.durum : " + r.ToString());








        }
    }
}
