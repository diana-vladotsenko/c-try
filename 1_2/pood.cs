/* Küsi inimeselt poes eraldi kas ta soovib osta piima, saia, leiba. Löö hinnad kokku ning teata, mis kõik ostetud kraam maksma läheb.*/

using System;
public class Pood {
    public static void Main(string[] args){
        int summa = 0;
        string sai="",leib="",piim="";
        Console.WriteLine("Kas sa soovid osta piima?(y/n): ");
        piim = Console.ReadLine();
        if(piim== "y"){
            summa = summa + 2;
        } else {
            Console.WriteLine("Kas sa soovid osta saia?(y/n): ");
            sai = Console.ReadLine();
        }
        if(sai== "y"){
            summa = summa + 2;
        } else {
             Console.WriteLine("Kas sa soovid osta leiba?(y/n): ");
             leib = Console.ReadLine();
        }if(leib== "y" ){
            summa = summa + 2;
        }
        Console.WriteLine("Summa on: " + summa);
    }
}