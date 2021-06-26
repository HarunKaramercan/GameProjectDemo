using GameDemo.Abstract;
using GameDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName=="Jim" &&  gamer.LastName=="Beglin" && gamer.IdentityNumber==123)
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
