/*Ülesandeid
* Trüki arvude ruudud ühest kahekümneni
* Küsi kasutajalt viis arvu ning väljasta nende summa
* Ütle kasutajale "Osta elevant ära!". Senikaua korda küsimust, kuni kasutaja lõpuks ise kirjutab "elevant". */

using System;
class Arvud {
    static void Main(string[] arg){
        for (int arv = 1; arv < 21; arv++){
            Console.WriteLine(arv);
        }
    }
}
