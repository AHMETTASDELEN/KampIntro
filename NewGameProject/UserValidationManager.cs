using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProject
{
    class UserValidationManager : IUserValidation
    {
        public bool Validated(Gamer gamer)
        {
            return true;
        }
    }
}
