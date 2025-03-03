//* Küsi kasutaja käest viis arvu ning väljasta need tagurpidises järjekorras.
using System;
using System.Collections.Generic;


class Programm
{
    public static void Main(string[] arg)
    {
		List<int> arvud = new List<int>();
        for (int i=0;i < 5; i++)
        {
            Console.WriteLine("Sisesta arv:");
            string arv_str = Console.ReadLine();
            int.TryParse(arv_str, out int arv);
            arvud.Add(arv);
        }
        
        for (int i = arvud.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(arvud[i]);
        }

    }
}
