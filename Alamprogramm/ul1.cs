/* Koosta alamprogramm kahe arvu keskmise leidmiseks*/
using System;

class Alamprogramm{
    public static int Keskmine(int arv1, int arv2){
        return (arv1*arv2)/2;
    }
}

class Programm{
    public static void Main(string[] arg){
    int a=3;
    int b=3; 
    Console.WriteLine("Keskmine on: " + Alamprogramm.Keskmine(a, b));
    }
}