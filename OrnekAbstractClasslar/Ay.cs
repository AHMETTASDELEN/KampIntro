using System;
using System.Collections.Generic;
using System.Text;

namespace OrnekAbstractClasslar
{
    public abstract class Ay
    {
        public int GunlerKacSaatir()
        {
            return 24;
        }

        public virtual int KacGundenOlusur()
        {
            return 31;
        }

        public abstract int YilinKacinciAyidir();
    }
}
