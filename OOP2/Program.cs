using OOP2;

internal class Program
{
    private static void Main(string[] args)
    {
        // Engin Demiroğ
        GercekMusteri musteri1 = new GercekMusteri();
        musteri1.Id = 1;
        musteri1.MusteriNo = "12345";
        musteri1.Adi = "Emin";
        musteri1.Soyadi = "Göçen";
        musteri1.TcNo = "12345678910";

        // Abc Şirketi
        TuzelMusteri musteri2 = new TuzelMusteri();
        musteri2.Id = 2;
        musteri2.MusteriNo = "54321";
        musteri2.SirketAdi = "Abc Şirketi";
        musteri2.VergiNo = "1234567890";

        // Gerçek Müşteri - Tüzel Müşteri
        // SOLID

        Musteri musteri3 = new GercekMusteri();
        Musteri musteri4 = new TuzelMusteri();

        MusteriManager musteriManager = new MusteriManager();
        musteriManager.Ekle(musteri1);
        musteriManager.Ekle(musteri2);

    }
}