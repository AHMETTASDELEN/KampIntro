using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProject
{
    interface IGamerService
    {
        void Ekle(Gamer gamer);
        void Sil(Gamer gamer);
        void Guncelle(Gamer gamer);
    }
}
