using P03_TypeConversion;

internal class Program
{
    // Bu proje Data Type Conversion (çevrimleri) üzerinedir.
    // İncelenecek konular
    // 2 tür çevrim bulunmakta

    // 1.Bilinçsiz - Implicit (küçük veriden büyük veriye kolayca geçiş)
    // 2.Bilinçli - Explicit 

    // Yapıyı bölerek kontrol eden program parçası burası olacak (yani Program.cs isimli class (sınıf)

    private static void Main(string[] args)
    {
        // ilk önce Program.cs-Main çalışacak.
        // Fakat benim istediğim Bilincsiz-Implicit.cs kısmındaki Main bloğu
        // onu ayağa kaldırmak için 
        // <class>.<metod> yapısı syntax

        Bilincsiz_Implicit.Main(args);

        Bilincli_Explicit.Main(args);

        Console.ReadKey(); // ekranda bekler
    }
}