/* Küsi temperatuur ning teata, kas see on üle kaheksateistkümne kraadi (soovitav toasoojus talvel).*/

using System;
public class Temperatuur {
    public static void Main(string [args]){
        Console.WriteLine("Sisesta temperatuur: ");
        int temperatuur = Console.Readline();

    if(temperatuur == null){
        Console.WriteLine("Sisesta temperatuur")
    } else {
        if(temperatuur > 18){
         Console.Writeline("Koik on ok.");
    } else {
        Console.WriteLine("Ei ole ok.");
    }
    }
    } 
}