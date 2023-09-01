using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName=="Emin" && gamer.LastName=="Göçen"
                && gamer.IdentityNumber==123456789 && gamer.BirthYear==2002 && gamer.Id==1)
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
