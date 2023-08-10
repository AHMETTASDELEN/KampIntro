using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProject
{
    class GamerManager : IGamerService
    {
        UserValidationManager _userValidationManager;

        public GamerManager(UserValidationManager userValidationManager)
        {
            _userValidationManager = userValidationManager;
        }

        public void Ekle(Gamer gamer)
        {
            if (_userValidationManager.Validated(gamer)==true)
            {
                Console.WriteLine("Gamer Eklendi");
            }
            else
            {
                Console.WriteLine("Gamer Eklenemedi");
            }
            
        }

        public void Guncelle(Gamer gamer)
        {
            Console.WriteLine("Gamer Güncellendi");
        }

        public void Sil(Gamer gamer)
        {
            Console.WriteLine("Gamer Silindi");
        }
    }
}
