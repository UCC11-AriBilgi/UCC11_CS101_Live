using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_FlowMechanims
{
    internal class IfElse
    {

        public static void Main(string[] args)
        {
            Console.Clear(); // ekranı temizler

            Console.WriteLine("******************************************");
            Console.WriteLine("*                                        *");
            Console.WriteLine("* IF-ELSE ÖRNEKLERİ                      *");
            Console.WriteLine("*                                        *");
            Console.WriteLine("******************************************\n\n\n");

            //#region 1. if-else

            //int a = 5;
            //int b = 7;

            //// hangi sayının büyük olduğunu belirten bir mesaj göstermemiz istenmiş olsun
            //// 

            //if (a < b) // kontrol işlemi yapıyorum < > <= >= == !=
            //{
            //    // 30.satırdaki koşul doğru olduğunda çalışacak kısım
            //    Console.WriteLine("a değeri b değerinden küçüktür....");
            //}
            //else
            //{
            //    // 30.satırdaki koşul yanlış olduğunda çalışacak kod bloğu
            //    Console.WriteLine("a değeri b değerinden küçük değildir...");
            //}



            //#endregion

            //#region 2. if-else..
            //// ekrandan Cinsiyet bilgisi girilmesi istensin(cins diye bir değişgen kullanılsın). e,k olarak (küçük harf)
            //// değişgenin durumuna göre kullanıcıya uygun bir mesaj verilsin 
            //// Cinsiyetiniz Erkektir veya Kadındır diye
            //// ve eğer bu karakterlerin dışında bir giriş durumunda da "Lütfen doğru bilgi giriniz" diye bir mesaj görülsün.

            //Console.WriteLine("Lütfen cinsiyet bilgisini giriniz (e/k) : ");

            //char cins=Convert.ToChar(Console.ReadLine()); // ekrandan girilen değeri tek karakterlik algılatmak için

            //if (cins == 'e')
            //{
            //    Console.WriteLine("Erkeksiniz....");
            //}
            //else if (cins=='k') // '' char veri tipi için
            //{
            //    Console.WriteLine("Kadınsınız...");
            //}
            //else
            //{
            //    Console.WriteLine("Lütfen doğru değer giriniz...");
            //}


            //#endregion

            #region 3. if-else..
            // ekrandan hem kullanıcı adı hem de şifre alacak olan mesajlar veriniz
            // buları uygun değişgenlerde tutunuz (kulad,kulsifre..string değişgenler olsun)
            // sabit olarak verilmiş kullanıcı adı ve şifreye uygun olması durumunda uygun mesajlar veriniz

            Console.WriteLine("Lütfen cinsiyet bilgisini giriniz (e/k) : ");

            char cins = Convert.ToChar(Console.ReadLine()); // ekrandan girilen değeri tek karakterlik algılatmak için

            if (cins == 'e')
            {
                Console.WriteLine("Erkeksiniz....");
            }
            else if (cins == 'k') // '' char veri tipi için
            {
                Console.WriteLine("Kadınsınız...");
            }
            else
            {
                Console.WriteLine("Lütfen doğru değer giriniz...");
            }


            #endregion

        }
    }
}
