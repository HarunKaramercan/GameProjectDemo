using GameDemo.Abstract;
using GameDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class GameSaleManager : IGameSalesSerivce
    {
        public void Sale(Campaign campaign, Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName + " oyunu " + gamer.FirstName + " " + gamer.LastName + " Oyuncusuna Satıldı");
            double newprice =(game.Price * campaign.CampaignDiscount);
            Console.WriteLine("Oyunun Fiyatı :"+game.Price);
            Console.WriteLine("Oyunun indirimli Fiyatı : " + newprice + " TL");
        }   
    }
}
