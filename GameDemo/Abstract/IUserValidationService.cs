using GameDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
