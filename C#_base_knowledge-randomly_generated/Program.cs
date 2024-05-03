using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class C__base_knowledge_randomly_generated
{
    static Random random = new Random();

    static void Main(string[] args)
    {

        Console.WriteLine("Testen drücken || ESC zum Beenden");

        string text = "hallo";
        for (int choice = 1; choice <= 4; choice++)
        {
            switch (choice)
            {

                case 1:
                    Console.WriteLine("Text: {0} (original)", text);
                    break;
                case 2:
                    text.ToUpper();
                    Console.WriteLine("Text: {0} (unverändert)", text);
                    break;
                case 3:
                    text = text.ToUpper();
                    string inGrossbuchstaben = text.ToUpper();
                    Console.WriteLine("Text: {0} (in Grossbuchstaben)", text);
                    Console.WriteLine("Text: {0} (in Grossbuchstaben)", inGrossbuchstaben);
                    break;
                case 4:
                    string inGrossbuchstaben2 = text.ToUpper();
                    Console.WriteLine("Text: {0} (in kleinbuchstaben)\n", inGrossbuchstaben2.ToLower());
                    break;
            }
        }

    }

}
