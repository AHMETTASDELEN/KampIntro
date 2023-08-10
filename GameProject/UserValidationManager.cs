using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirtYear == 2001 && gamer.FirstName == "AHMET" && gamer.LastName=="TAŞDELEN" 
                && gamer.IdentityNumber==320151)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
