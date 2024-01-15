using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_FlowMechanims
{
    internal class SwitchCase
    {
        public static void Main(string[] args)
        {
            Console.Clear(); // ekranı temizler

            Console.WriteLine("******************************************");
            Console.WriteLine("*                                        *");
            Console.WriteLine("* SWITCH-CASE ÖRNEKLERİ                  *");
            Console.WriteLine("*                                        *");
            Console.WriteLine("******************************************\n\n\n");

            #region switch-case 1
            // Ekrana bir değişgenin değerine göre bir mesaj yazdırma

            int g = 4;

            switch (g)
            {
                case 4:
                    Console.WriteLine("Değeriniz : {0} dir.",g);
                    break;

                case 5:
                    Console.WriteLine("Değeriniz : {0} dir.", g);
                    break;

                case 6:
                    Console.WriteLine("Değeriniz : {0} dir.", g);
                    break;

                default:

                    Console.WriteLine("Switch case deneme...");
                    break;
            }


            #endregion


        }

    }
}
