//* * Sorteeri massiiv ning väljasta selle keskmine element.
using System;
using System.Collections.Generic;


class Programm
{
    public static void Main(string[] arg)
    {
        List<int> arvud = new List<int> { 1, 3, 9, 4, 12 };
        List<int> sortedArvud = new List<int> ();
        for (int i = 0; i < arvud.Count -1; i++)
        {
            if(arvud[i] < arvud[i+1]){
                int arv = arvud[i];
                sortedArvud.Add(arv);
                Console.WriteLine("List sort: " + arv);
            } else {
                int arv = arvud[i +1];
				Console.WriteLine("List sort: " + arv);

            }
        }
    }
}
