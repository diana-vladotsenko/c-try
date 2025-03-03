//Teata, kas lauses leidub sõna "ja"
using System;

class taheLeidmine
{
    public static void Main(string[] arg)
    {
        string sona = "owuiuwhjdhbdncjosokoqwdieuhewfewbhjcnndbbjjhfbejsjkkjclwjdqwkljaokdwqkqw";
        bool found = false;
        for (int i = 0; i < sona.Length; i++)
        {
            if (sona[i] == 'j')
            {
                if (sona[i + 1] == 'a')
                {
                    found = true;
                }
            }
        }

        if (found)
        {
            Console.WriteLine("jah, sõna 'ja' on sõnas olemas");
        }
        else
        {
            Console.WriteLine("ei, pole");
        }

    }
}