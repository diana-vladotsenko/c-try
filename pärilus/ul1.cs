using System;

namespace Parilus2
{
    class Inimene
    {
        protected int vanus;
        protected int pikkus;
        public Inimene(int uvanus, int upikkus)
        {
            vanus = uvanus;
            pikkus = upikkus;
        }

        public void YtleVanus()
        {
            Console.WriteLine("Minu vanus on " + vanus + " aastat");
        }

        public void YtlePikkus()
        {
            Console.WriteLine("Minu pikkus on " + pikkus + " cm");
        }
    }

    class Modell : Inimene
    {
        protected int ymberm66t;
        protected int[] inimesed;
        public Modell(int vanus, int uymberm66t, int pikkus) : base(vanus, pikkus)
        {
            ymberm66t = uymberm66t;
            inimesed = new int[] { vanus, ymberm66t, pikkus };
        }

        public void EsitleInimesi()
        {
            Console.WriteLine("Inimese andmed: ");
            foreach (int andmed in inimesed)
            {
                Console.Write(andmed + " ");
            }
            Console.WriteLine();
        }

        public void Esitle()
        {
            YtleVanus();
            Console.WriteLine("Mu ümbermõõt on " + ymberm66t + " sentimeetrit");
            YtlePikkus();
            EsitleInimesi();
        }

        public int kysiPikkus()
        {
            return pikkus;
        }
    }

    class InimTest
    {
        public static void Main(string[] arg)
        {
            Inimene inim1 = new Modell(20, 90, 175);
            inim1.Esitle();
            Inimene[] isikud = new Inimene[3];
            isikud[0] = inim1;
            isikud[0] = inim1;
            isikud[1] = new Inimene(28, 165);
            isikud[2] = new Model(28, 90, 165);
            foreach (Inimene isik in isikud)
            {
                isik.YtleVanus();
                Console.WriteLine(isik.kysiPikkus());
            }
        }
    }
}
