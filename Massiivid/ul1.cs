//* Küsi kasutaja käest viis arvu ning väljasta need tagurpidises järjekorras.
using System;

class Programm
{
    public static void Main(string[] arg)
    {
        int[] arvud;
        while (arv <= 5)
        {
            Console.WriteLine("Sisesta arv:");
            string arv_str = Console.ReadLine();
            int.TryParse(arv_str, out int arv);
            arvud = arvud.Append(arv).ToArray();
        } else
        {
            Console.WriteLine(arvud);
        }
    }
    /*string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string i in cars) 
{
  Console.WriteLine(i);
}*/
}