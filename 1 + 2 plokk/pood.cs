/* Küsi inimeselt poes eraldi kas ta soovib osta piima, saia, leiba. Löö hinnad kokku ning teata, mis kõik ostetud kraam maksma läheb.*/

using System;
public class Pood {
    public static void Main(string [args]){
        int summa = 0;
        Console.Writeline("Kas sa soovid osta piima?(y/n): ");
        string piim = Console.Readline();
        if(piim== "y"){
            summa = summa + piim
        } else {
            Console.Writeline("Kas sa soovid osta saia?(y/n): ");
            string sai = Console.Readline();
        }if(sai== "y"){
            summa = summa + sai
        } else {
             Console.Writeline("Kas sa soovid osta leiba?(y/n): ");
            string leib = Console.Readline();
        }if(sai== "y" ){
            summa = summa + leib
        }
        Console.WriteLine("Summa on: " + summa)
    }
}
