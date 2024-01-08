using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Operators
{

    internal class ArtirmaEksiltme
    {
        public static void Main(string[] args)
        {
            Console.Clear(); // ekranı temizler

            Console.WriteLine("******************************************");
            Console.WriteLine("*                                        *");
            Console.WriteLine("* ARTIRMA VE EKSİLTME OPERATÖR ÖRNEKLERİ *");
            Console.WriteLine("*                                        *");
            Console.WriteLine("******************************************");

            // Bir arttırma/eksiltme operatör ornekleri
            // Çok kullanılır..Sabitlere(const) uygulanmazlar
            // ön ek ve son ek (prefix-suffix) olmak üzere 2 sekilde kullanılırlar.

            int fonceki = 5;

            Console.WriteLine("İşlem öncesi fonceki değeri " + fonceki );

            int fsonraki = --fonceki; // prefix kullanım
            // ++ operatoru hem fonceki değerinini 1 artırıyor ...sonra bu değeri tutuyor kafada ve en son olarak da fsonraki değişgenine atıyor..

            Console.WriteLine("İşlemden sonraki fonceki değeri " + fonceki + ", fsonraki değeri " + fsonraki + "\n\n");

            int gonceki = 10;

            Console.WriteLine("İşlem öncesi gonceki değeri " + gonceki);

            int gsonraki = gonceki--; // suffix kullanım
            // ++ operatoru önce gsonraki <- gonceki içeriği atanıyor. sonra değerini 1 artırıyor

            Console.WriteLine("İşlemden sonraki gonceki değeri " + gonceki + ", gsonraki değeri " + gsonraki + "\n\n");


            // Karışık gibi olabili mi

            int h = 5;

            int i = h++; // i=6;

            int j = i--; // j=5

            int k = 10;

            int l = --k; // l=9

            // değişgen değerlerini yazdırırken parametrik yapı kullanılabilir. CW nin biraz değişik şekli...

            Console.WriteLine("Sonuç : h={0}\ti={1}\tj={2}\tk={3}\tl{4}\n\n",h,i,j,k,l);









        }
    }
}
