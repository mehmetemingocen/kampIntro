using GameProject;

class Program
{
    private static void Main(string[] args)
    {
        GamerManager gamerManager = new GamerManager(new UserValidationManager());
        gamerManager.Add(new Gamer {
            FirstName="Emin",
            LastName="Göçen",
            BirthYear=2002,
            Id=1,
            IdentityNumber= 123456789 }
        );
    }
}   