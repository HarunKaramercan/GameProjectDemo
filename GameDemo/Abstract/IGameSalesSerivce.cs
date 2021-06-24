using GameDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    interface IGameSalesSerivce
    {
        void Sale(Campaign campaign,Game game,Gamer gamer);
    }
}
