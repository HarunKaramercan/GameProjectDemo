using GameDemo.Abstract;
using GameDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class GamerManager : IGamerService
    {

        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine(gamer.FirstName+ " adlı oyuncu Kayıt Oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız,Kayıt Olunamadı");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " adlı oyuncu Kaldırıldı.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " adlı oyuncu Güncellendi.");
        }
    }
}
