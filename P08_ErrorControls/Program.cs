internal class Program
{
    private static void Main(string[] args)
    {
        #region Hata oluşturabilecek bir durum.
        //int a = 100;
        //int b = 0;

        //Console.WriteLine($" a / b işleminin sonuc {a/b} dir...");

        #endregion

        #region Hata Avcısı
        int c = 0;
        int d = 0;

        try
        {
            Console.WriteLine($" c / d işleminin sonuc {c / d} dir...");
        }
        catch (Exception)
        {
            if (c!=0 && d==0)
            {
                d = c / 10;

                Console.WriteLine($"d nin değeri hata oluşturduğu için güncellenmiş ve {d} yapılmıştır...Şimdi sonuc {c/d} dir..."  );
            }
            else if (c==0 && d != 0)
            {
                c = d * 10;

                Console.WriteLine($"c nin değeri sonucu 0 vereceği için  için güncellenmiş ve {c} yapılmıştır...Şimdi sonuc {c / d} dir...");
            }
            else if (c == 0 && d == 0)
            {
                c = 50;
                d = 10;

                Console.WriteLine($"Şimdi sonuc {c / d} dir...");
            }
        }




        #endregion


        Console.ReadKey();
    }
}