//Küsi inimeselt kolm arvu. Iga arvu puhul joonista vastav kogus tärne ekraanile

using System;
class Alamprogramm{
    public static int Tarnid(int kasutaja_arv){
        Console.WriteLine("Sisestatud arv: " + kasutaja_arv);  
        for(int arv=0;arv < kasutaja_arv;arv++){
            Console.WriteLine("*");
        }
        return kasutaja_arv;
    }
}

class Programm{
    public static void Main(string[] arg){
        Console.WriteLine("Sisesta esimene arv: ");
        string esimene_arv_str = Console.ReadLine();
        int.TryParse(esimene_arv_str, out int esimene_arv);
        //minu jaoks deklaleeritav arv:
        esimene_arv = 5;
        Console.WriteLine(Alamprogramm.Tarnid(esimene_arv));

        Console.WriteLine("Sisesta teine arv: ");
        string teine_arv_str = Console.ReadLine();
        int.TryParse(teine_arv_str, out int teine_arv);
        //minu jaoks deklaleeritav arv:
        teine_arv = 7;
        Console.WriteLine(Alamprogramm.Tarnid(teine_arv));
        
        
        Console.WriteLine("Sisesta kolmas arv: ");
        string kolmas_arv_str = Console.ReadLine();
        int.TryParse(kolmas_arv_str, out int kolmas_arv);
        //minu jaoks deklaleeritav arv:
        kolmas_arv = 2;
        Console.WriteLine(Alamprogramm.Tarnid(kolmas_arv));

    }
}