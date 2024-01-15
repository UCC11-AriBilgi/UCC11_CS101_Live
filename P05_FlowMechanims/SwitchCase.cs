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

            //#region switch-case 1
            //// Ekrana bir değişgenin değerine göre bir mesaj yazdırma

            //Console.WriteLine("Lütfen 4 ile 6 arasında bir rakam giriniz...");
            //int g = Convert.ToInt32(Console.ReadLine());

            //// herhangi bir case opsiyonuna ait blok mutlaka break; ile bitirilmelidir. Yoksa hata verir.
            //switch (g)
            //{
            //    case 4:
            //        Console.WriteLine("Değeriniz : {0} dir.",g);
            //        break;

            //    case 5:
            //        Console.WriteLine("Değeriniz : {0} dir.", g);
            //        break;

            //    case 6:
            //        Console.WriteLine("Değeriniz : {0} dir.", g);
            //        break;

            //    default:

            //        Console.WriteLine("Uygun değer girilmedi...");
            //        break;
            //}


            //#endregion

            #region switch-case 2
            //Programımızın bir case içersindeyken başka bir case içersine dallanması da çeşitli durumlarda gerekebilir..bu durumlarda "goto" anahtar kelimesi kullanılabilir.

            //int j = 5;

            //switch (j)
            //{
            //    case 4:
            //        string k1=Console.ReadLine();
            //        Console.WriteLine(k1);

            //        break;

            //    case 5:
            //        Console.WriteLine("Şimdi case 4'e yönlendirileceksiniz...\n\n");
            //        goto case 4; // burada case 4 bloğuna yönlendiriliyor...
            //        // eğer goto belirteci kullanılmışsa break; kullanılmasına gerek yoktur...

            //    default:
            //        Console.WriteLine("Deneme");
            //        break;
            //}

            #endregion


            #region switch-case 3
            // Bazen farklı case sabitlerinin aynı komut bloğınu çalıştırması gerekebilir.

            Console.WriteLine("Lütfen 4 ile 6 arasında bir değer giriniz...");
            int k = Convert.ToInt32(Console.ReadLine());

            switch (k)
            {
                case 4:
                case 5:
                case 6:
                    string l = Console.ReadLine();
                    Console.WriteLine("Girdiğiniz bilgi : {0}",l);
                    break;


                default:
                    Console.WriteLine("Doğru değer giriniz...");
                    break;
            }



            #endregion


        }

    }
}
