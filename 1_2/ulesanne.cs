/*
Ülesandeid
•	Küsi kahe inimese nimed ning teata, et täna on nad pinginaabrid
•	Küsi ristkülikukujulise toa seinte pikkused ning arvuta põranda pindala
•	Leia 30% hinnasoodustusega hinna põhjal alghind
*/

using System;
public class Nimi
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Mis su nimi on?: ");
        string nimi1 = Console.Readline();
        
        Console.WriteLine("Mis su nimi on?: ");
        string nimi2 = Console.Readline();
    if(nimi1 != null || nimi2 != null ){
         Console.WriteLine(nimi1 + "ja" nimi2 +"on homme pinginaabrid!");
    } else {
        Console.WriteLine("Sisesta nimi, palun.");
    }
    }
}

/*
•	Küsi ristkülikukujulise toa seinte pikkused ning arvuta põranda pindala

*/

using System;
public class Ristkulik
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Sisesta esimene külg (a) : ");
        int esimene_kulg = Console.Readline();
        Console.WriteLine("Sisesta teine külg (b) : ");
        int teine_kulg = Console.Readline();
    if(teine_kulg != null && esimene_kulg != null ){
         int pindala = 2 *(esimene_kulg + teine_kulg);
         Console.Writeline("Pindala on:" + pindala);
    } else {
        Console.WriteLine("Sisesta küljed, palun.");
    }
}
}


/*
    •	Leia 30% hinnasoodustusega hinna põhjal alghind
*/

using System;
public class Hind
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Sisesta hind: ");
        int hind = Console.Readline();

    if(hind != null){
        int soodustus= 30 ;
         int hind_soodustusega = hind / soodustus ;
         Console.Writeline("Esialgne hind on:" + hind);
         Console.Writeline("Soodustus on:" + soodustus);
         Console.Writeline("Hind soodustusega on:" + hind_soodustusega);
    } else {
        Console.WriteLine("Täida väljud, palun.");
    }
    }
}


/*Teine plokk:*/

/** Küsi temperatuur ning teata, kas see on üle kaheksateistkümne kraadi (soovitav toasoojus talvel).
* Küsi inimese pikkus ning teata, kas ta on lühike, keskmine või pikk (piirid pane ise paika)
* Küsi inimeselt pikkus ja sugu ning teata, kas ta on lühike, keskmine või pikk (mitu tingimusplokki võib olla üksteise sees).
* Küsi inimeselt poes eraldi kas ta soovib osta piima, saia, leiba. Löö hinnad kokku ning teata, mis kõik ostetud kraam maksma läheb.
*/

using System;
public class Temperatuur {
    public static
}

