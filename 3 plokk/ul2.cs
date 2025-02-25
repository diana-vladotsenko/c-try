/* Küsi kasutajalt viis arvu ning väljasta nende summa*/

using System;
class Arvud {
    public static int Main(string[] args){
        int summa=0;
        for (int arv = 0; arv < 6; arv++){
            Console.WriteLine("Sisesta arv :");
            string kasutaja_arv_string = Console.ReadLine();
            int.TryParse(kasutaja_arv_string, out int kasutaja_arv);
            summa = summa + kasutaja_arv;
            return summa;
        }
        Console.WriteLine("Summa on:" + summa);
    }
}