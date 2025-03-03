//Lisa käsklus täisarvude astendamiseks tsükli abil. Katseta

using System;

class Programm
{
    public static void Main(string[] arg)
    {
        String arv= "5";
        for (int i = 0; i < 5; i++)
        {
			int num = Int32.Parse(arv);
            Console.WriteLine("Arv: " + num);

        }
    }
}