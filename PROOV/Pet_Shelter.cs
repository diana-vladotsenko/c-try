using System;

namespace PetShelter
{
    //doing pet type
    class Pet
    {
        protected string name;
        protected int age;
        protected string type;

        public Pet(string uname, int uage, string utype)
        {
            name = uname;
            age = uage;
            type = utype;
        }
        //allows ro create multiple pets, easy to change(in one place)
        public virtual void askData()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Age:" + age);
            Console.WriteLine("Type:" + type);
        }
    }



    class Dog : Pet
    {
        public Dog(string uname, int uage, string utype) : base(uname, uage, utype) { }

        public override void askData()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Age:" + age);
            Console.WriteLine("Type:" + type);
            Console.WriteLine("Bark!");
        }
    }

    class Cat : Pet
    {
        public Cat(string uname, int uage, string utype) : base(uname, uage, utype) { }

        public override void askData()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Age:" + age);
            Console.WriteLine("Type:" + type);
            Console.WriteLine("Meow..");
        }
    }


    class PetShelter
    {
        public static void Main(string[] args)
        {
            //List<string> cats = new List<string>();
            // // Add elements to the list
            // cats.Add("Mr.Harold");
            // cats.Add("Mr.Usikov");
            PetShelter shelter = new PetShelter();
            Cat[] cat = new Cat[4]{
            new Cat("Mr.Harold",2,"cat"),
            new Cat("Mr.Usikov",5,"cat"),
            new Cat("Pupi",3,"cat"),
            new Cat("Cookie",6,"cat")
          };

            Dog[] dog = new Dog[4]{
            new Dog("Pimple",5,"dog"),
            new Dog("Snukie",5,"dog"),
            new Dog("Fetch",3,"dog"),
            new Dog("Pukie",1,"dog")
          };

            Console.WriteLine("Available pets:");
            for (int i = 0; i < shelter.cat.Length; i++)
            {
                shelter.cat[i].askData();
                shelter.dog[i].askData();
            }
            shelter.AdoptPets("Pimple");
        }

        public void AdoptPets(string petName)
        {
            for (int i = 0; i < cat.Length; i++)
            {
                if (dog[i].getName() == petName)
                {
                    dog[i] = null;
                    return;
                }

            }
            Console.WriteLine("ERROR_DOG_IS_NOT_FOUND");
        }
    }

}