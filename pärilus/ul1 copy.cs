using System;
namespace Parilus1
{
    class Inimene
    {
        protected int vanus;
        protected int pikkus;
        public Inimene(int uvanus, int upikkus)
        {
            vanus = uvanus; pikkus = upikkus;
        }
        public Inimene(int uvanus) :
        this(uvanus, -1)
        { }
        public void YtleVanus()
        {
            Console.WriteLine("Minu vanus on " + vanus + " aastat");
        }
        public int kysiPikkus()
        {
            return pikkus;
        }
    }
    class Modell : Inimene
    {
        protected int ymberm66t;
        public Modell(int vanus, int uymberm66t, int pikkus) : base(vanus, pikkus)
        {
            ymberm66t = uymberm66t;
        }
        public void Esitle()
        {
            YtleVanus();
            Console.WriteLine("Minu ymberm66duks on " + ymberm66t + " sentimeetrit");
            Console.WriteLine("Minu pikkus on " + pikkus + " sentimeetrit");
        }
    }

    class InimTest
    {
        public static bool kasMahubAllveelaeva(Inimene isik)
        {
            if (isik is Modell)
            {
                return isik.kysiPikkus() <= 180;
            }
            return isik.kysiPikkus() <= 160;
        }
        public static void Main(string[] arg)
        {
            Inimene inim1 = new Modell(13, 90, 173);
            inim1.YtleVanus();
            Modell naitleja = inim1 as Modell;
            naitleja.Esitle();
            Inimene[] isikud = new Inimene[3];
            isikud[0] = inim1;
            isikud[1] = new Inimene(28, 165);
            isikud[2] = new Modell(23, 60, 180);
            foreach (Inimene isik in isikud)
            {
                isik.YtleVanus();
                Console.WriteLine("Pikkus: " + isik.kysiPikkus() + " " + "Mahub: " + kasMahubAllveelaeva(isik));
            }
        }
    }
}