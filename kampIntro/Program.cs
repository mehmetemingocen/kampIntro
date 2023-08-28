using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        // type safety - tip güvenliği
        string kategoriEtiketi = "kategori";
        int ogrenciSayisi = 32000;
        double faizOrani = 1.45;
        bool sistemeGirisYapmisMi = false;
        double DolarDun = 7.65;
        double DolarBugun = 7.45;

        if (DolarDun>DolarBugun)
        {
            Console.WriteLine("Azalış butonu");
        }
        else if (DolarDun < DolarBugun)
        {
            Console.WriteLine("Artış butonu");
        }
        else
        {
            Console.WriteLine("eşittir butonu");
        }


        if (sistemeGirisYapmisMi == true)
        {
            Console.WriteLine("Kullanıcı Ayarları butonu");
        }
        else
        {
            Console.WriteLine("Giriş yap butonu");
        }
        
        

        Console.WriteLine(kategoriEtiketi);

    }
}