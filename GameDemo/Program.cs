using GameDemo.Concrete;
using GameDemo.Entites;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Game---------");
            Game game1 = new Game { GameName = "Pro Evulation Soccer 2021",Price=149.90 };
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Update(game1);
            gameManager.Delete(game1);


            Console.WriteLine("---------Gamer---------");
            Gamer gamer1 = new Gamer { Id = 1, FirstName = "Jim", LastName = "Beglin",IdentityNumber=123};
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer1);
            gamerManager.Update(gamer1);
            gamerManager.Delete(gamer1);

            Console.WriteLine("---------Campaign---------");

            Campaign campaign = new Campaign { CampaignName="Haziran Ayı Fırsatı",CampaignDiscount=0.6};
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            campaignManager.Update(campaign);
            campaignManager.Delete(campaign);


            Console.WriteLine("---------Game Sales---------");
            GameSaleManager gameSalesManager = new GameSaleManager();
            gameSalesManager.Sale(campaign,game1,gamer1);

            Console.ReadLine();
        }
    }
}
