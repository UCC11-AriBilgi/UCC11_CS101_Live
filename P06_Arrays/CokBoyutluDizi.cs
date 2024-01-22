using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Arrays
{
    internal class CokBoyutluDizi
    {
        public static void Main(string[] args)
        {

            #region Çok Boyutlu diziler

            int[,] dizi1 = new int[3, 2]; // 2 boyutlu dizi tanımı

            int[,] dizi2 = { {1,2 },{ 3, 4 },{ 5, 6 } }; // 3 satır 2 kolonluk bir dizi(matris)

            int[,,] dizi3 = new int[3, 2, 2]; // 3 boyutlu dizi

            int[,,] dizi4 = { { { 1, 2 }, { 3, 4 } },{ { 5, 6 }, { 7, 8 } }, { { 9, 10 }, { 11, 12 } } }; // 3 boyutlu bir dizi(matris)

            // 3 boyutlu bir dizinin elemanlarını değiştirmek

            for (int i = 0; i < 3; i++) // 1.dongü
                for (int j = 0; j < 2; j++)
                    for (int k = 0; k < 2; k++)
                        dizi4[i, j, k] = 20;




            #endregion


        }

    }
}
