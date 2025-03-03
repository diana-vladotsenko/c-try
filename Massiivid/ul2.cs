//* * Loo alamprogramm massiivi väärtuste aritmeetilise keskmise leidmiseks. Katseta.
using System;
using System.Collections.Generic;


class Programm
{
    public static void Main(string[] arg)
    {
        int summa = 0;
        List<int> arvud = new List<int> { 1, 2, 3, 4, 5 };
        for (int i = 0; i < arvud.Count; i++)
        {
            summa += arvud[i];
        }
        double keskmine = (double)summa / arvud.Count;
        Console.WriteLine("Aritmeetiline keskmine: " + keskmine);
    }
}
