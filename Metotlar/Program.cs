using Metotlar;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] meyveler = new string[] { };

        Urun urun1 = new Urun();
        urun1.Adi = "Elma";
        urun1.Fiyati = 15;
        urun1.Aciklama = "Amasya elması";

        Urun urun2 = new Urun();
        urun2.Adi = "Karpuz";
        urun2.Fiyati = 85;
        urun2.Aciklama = "Diyarbakır karpuzu";

        Urun[] urunler = new Urun[] { urun1, urun2 };

        foreach (Urun urun in urunler)
        {
            Console.WriteLine(urun.Adi);
            Console.WriteLine(urun.Fiyati);
            Console.WriteLine(urun.Aciklama);
            Console.WriteLine("-----------");
        }

        Console.WriteLine("-------Metotlar--------");

        // instance - örnek
        // encapsulation

        SepetManager sepetManager = new SepetManager();
        sepetManager.Ekle(urun1);
        sepetManager.Ekle(urun2);

        sepetManager.Ekle2("Armut", "yeşil armut", 12,10);
        sepetManager.Ekle2("elma", "yeşil elma", 16,5);
        sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 65,7);

    }
}

// Dont repeat yourself - DRY - Clean Code - Best Practice