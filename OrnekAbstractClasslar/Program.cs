using System;

namespace OrnekAbstractClasslar
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class Ocak : Ay
    {
        public override int YilinKacinciAyidir()
        {
            return 1;
        }
    }



    public class Subat : Ay
    {
        public override int YilinKacinciAyidir()
        {
            return 2;
        }
        public override int KacGundenOlusur()
        {
            return 28;
        }
    }



    public class Mart : Ay
    {
        public override int YilinKacinciAyidir()
        {
            return 3;
        }
    }



    public class Nisan : Ay
    {
        public override int YilinKacinciAyidir()
        {
            return 4;
        }

        public override int KacGundenOlusur()
        {
            return 30;
        }
    }



    public class Mayıs : Ay
    {
        public override int YilinKacinciAyidir()
        {
            return 5;
        }
    }



    public class Haziran : Ay
    {
        public override int YilinKacinciAyidir()
        {
            return 6;
        }

        public override int KacGundenOlusur()
        {
            return 30;
        }
    }
}
