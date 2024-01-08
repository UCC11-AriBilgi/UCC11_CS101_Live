internal class Program
{
    // Açıklama satırı

    // Normal bir program yapısında bulunabilecel şeyler;
    // Namespace : birden çok yapının bir arada tutulduğu bir koleksiyon(kapsayıcı)
    // keyword..C# ın rezerve kelimeleri vardır 
    // private,using,static
    // bunları herhangi bir şekilde kendimiz için değişgen ismi kullanamayız.
    // class dediğimiz yapılardan oluşur.
    // ve hatta bir namespace bir kaç class yapısından oluşabilir.
    // Konsol vb. programın giriş noktası Main bloğudur (metot).burası çalışır.

        

    private static void Main(string[] args)
    {
        Console.WriteLine("Merabayın ahali dünya gezegenler....!");
        Console.WriteLine("--------------------------------");
        Console.WriteLine(""); // boş satır basma 
        Console.WriteLine("");
        Console.WriteLine("\tMerabayın mars....!\n\nTeşekkürler..");
        
        // Escape characters
        // \n:newline
        // \t:tab

        Console.ReadKey(); // Klavyeden bir tuşa basılmasını bekle..
    }

    // Programın giriş noktası 
    // ve yapacağı set ekrana birşeyler yazmak. System.Console.WriteLine kullanılır.

    // Amannn.
    // C# case-sensitive bir dildir. yani c# için deger1 ile Deger1 farklıdır, DEger1 yine farklıdır.
    // Herbir c# satırı mutlaka ve mutlaka ; ile bitmelidir
    
}