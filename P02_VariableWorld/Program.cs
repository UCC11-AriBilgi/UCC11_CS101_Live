internal class Program
{
    private static void Main(string[] args)
    {
        #region Değişgen örnekleri 1

        //string name;
        //string Name = "Doğa Bengi";
        //string nameDesc;

        //name = "Ümit Karaçivi";
        
        //nameDesc = "Benim adım";
        
        //string NameDesc = "Kızımın adı "; 

        //// Code snippet
        //// Console.WriteLine => cw tab tab

        //Console.WriteLine("Merhaba ..."+nameDesc+" "+name); // String concatanetion
        //Console.WriteLine(""); // boş bir satır
        //Console.WriteLine(""); // boş bir satır
        //Console.WriteLine(NameDesc+Name+"\n\n"); // \n yeni satıra atla (Escape Characters \t


        //Console.WriteLine("Lütfen çıkış için bir tuşa basınız...");

        #endregion

        #region Değişgen Örnekleri 2

        //byte a = 10; // max 0..255 arasında bir değer girebilirim
        //byte a1 = 255;

        //int toplam = a + a1;

        //Console.WriteLine("Toplam = " + toplam.ToString());

        //// cw console.readline string bazlı çalışır.

        //string str1 = "Viki", str2 = "pedia";

        //Console.WriteLine("\n\n"+str1+str2);


        //// Ekrandan veri alınması durumları
        //string Name, SurName;
        //int Age;

        //Console.WriteLine("\nLütfen adınızı giriniz : ");
        //Name= Console.ReadLine(); // Okudu ve anında Name değişgenine atama yaptı
        
        //Console.WriteLine("\nLütfen soyadınızı giriniz : ");
        //SurName= Console.ReadLine(); // Okudu ve anında SurName değişgenine atama yaptı
        
        //Console.WriteLine("\nLütfen yasınızı giriniz : ");
        //Age= Convert.ToByte(Console.ReadLine()); // Okudu ve anında SurName değişgenine atama yaptı
        //int NewAge;
        //NewAge = Age + 10;

        //Console.WriteLine("Girmiş olduğunuz bilgi : " + Name + " " + SurName);
        //Console.WriteLine("10 yıl sonra " + NewAge.ToString()  + " yaşında olacaksınız..");





        #endregion

        #region Dikkat edilesiler

        //int a,byte b; // aynı satırda birbirinden farklı veri tipleri olan değişgenler tanımlanamaz.

        //int n;
        //n = "Ümit"; // değişgene uygunsuz değer atama durumları

        //int b1 = 5;
        //Console.WriteLine(b3); // tanımlama yapmadan değişgeni kullanmaya çalışma.

        // değişgenlin tüm tanımlarının Main bloğu içinde yapılmasına dikkat

        float flt = 12.5f; // 12.5 yazarsam hata

        // metinsel değişgenlerle matematiksel işlemler yapmaya çalışmak

        string a5 = "134567", b5 = "3";

        Console.WriteLine(Convert.ToInt32(a5) + Convert.ToInt32(b5));





        #endregion


        Console.ReadKey(); // bizden bir tuşa basmamızı bekliyor.

        //Console.WriteLine("Hello, World!");
    }
}