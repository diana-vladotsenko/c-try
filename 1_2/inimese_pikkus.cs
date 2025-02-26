/* Küsi inimese pikkus ning teata, kas ta on lühike, keskmine või pikk (piirid pane ise paika)*/
/** Küsi inimeselt pikkus ja sugu ning teata, kas ta on lühike, keskmine või pikk (mitu tingimusplokki võib olla üksteise sees).
*/

using System;
public class Pikkus {
    public static void Main(string [args]){
        Console.WriteLine("Sisesta pikkust: ");
        int pikkus = Console.Readline();
        Console.WriteLine("Sisesta sugu (N/M): ");
        string sugu = Console.Readline();
    if(pikkus != null && sugu != string.Empty){
        Console.WriteLine("Sisesta pikkust voi sugu!");
    } else {
        if(pikkus >= 168 && sugu == "N" || sugu == "M"){
         Console.Writeline("Oled pikk.");
        } else if (pikkus <= 167 && sugu == "N" || sugu == "M") {
            Console.WriteLine("Oled lühike.");
        }
    }
    } 
}