//* * * Tekstifaili igal real on müüdud kauba hind. Arvuta programmi abil nende hindade summa.
using System;
using System.IO;


class Programm
{
    public static void Main(string[] arg)
    {
        double summa = 0;
        String[] andmed = File.ReadAllLines("hinnad.txt");

        foreach (string rida in andmed)
        {
            if (double.TryParse(rida, out double hind))
            {
                summa += hind;
            }
            else
            {
                Console.WriteLine($"Viga: {rida} ei ole korrektne arv.");
            }
        }
    }
}