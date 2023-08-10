using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirtYear = 2001,
                FirstName = "AHMET",
                LastName = "TAŞDELEN",
                IdentityNumber = 320151
            });
        }
    }
}
