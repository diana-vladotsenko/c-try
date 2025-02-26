using System;
class Arvud {
    public static void Main(string[] args){
    	string vastus = "";
        Console.WriteLine("Kas kirjutad elevant?:");
        vastus = Console.ReadLine();
        while(vastus != "elevant"){
            Console.WriteLine("Osta elevant ära!");
            vastus = Console.ReadLine();
        }
    }
}