//Küsi inimeselt kolm arvu. Iga arvu puhul joonista vastav kogus tärne ekraanile

using System;
class Alamprogramm{
    public static int Tarnid(int kasutaja_arv){
        string lause = Console.Writeline("Sisestatud arv: " + kasutaja_arv);
        for(int arv=0;arv < kasutaja_arv;a++){
            Console.WriteLine("*");
        }
        return kasutaja_arv;
    }
}

class Programm{
    public static void Main(string[] arg){
        Console.WriteLine("Sisesta esimene arv: ");
        string esimene_arv_str = Console.ReadLine();
        int.ToParse(esimene_arv_str, out in esimene_arv);
        //minu jaoks deklaleeritav arv:
        int esimene_arv = 5;
        Console.WriteLine(Alamprogramm.Tarnid(esimene_arv));

        Console.WriteLine("Sisesta teine arv: ");
        string teine_arv_str = Console.ReadLine();
        Console.WriteLine("Sisesta kolmas arv: ");
        string kolmas_arv_str = Console.ReadLine();

    }
}