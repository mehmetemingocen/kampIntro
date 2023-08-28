internal class Program
{
    private static void Main(string[] args)
    {
        string kurs1 = "Yazılım geliştirici yetiştirme kampı";
        string kurs2 = "programlamaya başlangıç için temel kurs";
        string kurs3 = "Java";

        // array - dizi

        string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı", "programlamaya başlangıç için temel kurs","java","C++"};


        for (int i = 0; i < kurslar.Length; i++)
        {
            Console.WriteLine(kurslar[i]);
        }

        Console.WriteLine("For bitti");

        // foreach dizilere uygulanır.
        foreach (string kurs in kurslar)
        {
            Console.WriteLine(kurs);
        }


        Console.WriteLine("sayfa sonu - footer");
    }
}