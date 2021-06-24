using GameDemo.Abstract;
using GameDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class GameManager: IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun eklendi.\n" +
                "Fiyatı: " + game.Price);
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun Güncellendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun kaldırıldı.");
        }


    }
}
