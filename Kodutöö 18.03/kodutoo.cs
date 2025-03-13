using System;

// Tunni broneeringu süsteem
namespace Broneering
{
    // Üldine klass, millest kõik pärivad
    class BroneeringuAndmed
    {
        protected string nimi;

        public BroneeringuAndmed(string unimi)
        {
            nimi = unimi;
        }


        public virtual void AndmeteKuvamine()
        {
            Console.WriteLine("Andmed: " + nimi);
        }
    }

    class Hind
    {
        protected int hind;

        public Hind(int uhind)
        {
            hind = uhind;
        }


        public virtual void AndmeteKuvamine()
        {
            Console.WriteLine("Andmed: " + nimi);
        }
    }

    // Opilane pärib BroneeringuAndmed
    class Opilane : BroneeringuAndmed
    {
        public Opilane(string unimi) : base(unimi) { }

        public override void AndmeteKuvamine()
        {
            Console.WriteLine("Õpilane: " + nimi);
        }
        public string KysiNimi()
        {
            return nimi;
        }
    }

    // Õpetaja pärib BroneeringuAndmed
    class Opetaja : BroneeringuAndmed
    {
        public Opetaja(string unimi) : base(unimi) { }

        public override void AndmeteKuvamine()
        {
            Console.WriteLine("Õpetaja: " + nimi);
        }
        public string KysiNimi()
        {
            return nimi;
        }
    }

    // Pill pärib BroneeringuAndmed
    class Pill : BroneeringuAndmed
    {
        public Pill(string unimi) : base(unimi) { }

        public override void AndmeteKuvamine()
        {
            Console.WriteLine("Pill: " + nimi);
        }
        public string KysiNimi()
        {
            return nimi;
        }
    }

    // Peamine klass, mis testib broneeringut
    class TunniBroneering
    {
        public static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            DateTime tomorrowDate = DateTime.Now + new TimeSpan(2, 0, 0, 0);
            DateTime dt = new DateTime(2025, 3, 14);
            Pill pill = new Pill("Klaver");

            Opilane[] opilased = new Opilane[4]
            {
                new Opilane("Kaisa"),
                new Opilane("Liisu"),
                new Opilane("Markus"),
                new Opilane("Mari-Liis")
            };

            Opetaja[] opetajad = new Opetaja[4]
            {
                new Opetaja("Mati"),
                new Opetaja("Kristiina"),
                new Opetaja("Ljudmila"),
                new Opetaja("Markus")
            };



            for (int i = 0; i < opilased.Length; i++)
            {

                Console.WriteLine("");
                Console.WriteLine("-----------");
                Console.WriteLine("Broneering:|");
                Console.WriteLine("-----------");


                opetajad[i].AndmeteKuvamine();
                opilased[i].AndmeteKuvamine();
                pill.AndmeteKuvamine();

                Console.WriteLine("Broneeritud: " + currentDateTime);
                Console.WriteLine("Toimimis kuupäev(D/M/Y): " + tomorrowDate.Day + " / " + tomorrowDate.Month + " / " + tomorrowDate.Year);
                Console.WriteLine("Algus: " + currentDateTime.Hour + "." + currentDateTime.Minute);
                Console.WriteLine("Aeg (h): 1 ");
                Console.WriteLine("Staatus: Kinnitatud");
            }

        }
    }
}