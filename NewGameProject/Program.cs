using System;

namespace NewGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Ekle(new Gamer { Id = 1, FirstName = "Ahmet", LastName = "Taşdelen", BirtYear = 1986, IdentityNumber = 12345 });
        }
    }
}
