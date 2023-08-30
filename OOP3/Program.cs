using OOP3;

internal class Program
{
    private static void Main(string[] args)
    {
        IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
        IKrediManager tasitKrediManager = new TasitKrediManager();
        IKrediManager konutKrediManager = new KonutKrediManager();

        ILoggerService databaseLoggerService = new DatabaseLoggerService();
        ILoggerService fileloggerService = new FileLoggerService();

        BasvuruManager basvuruManager = new BasvuruManager();
        basvuruManager.BasvuruYap(konutKrediManager,databaseLoggerService);

        List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };

        // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
    }
}