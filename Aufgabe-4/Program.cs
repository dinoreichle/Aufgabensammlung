using System;

class Program
{
    static void Main()
    {
        char nochmal;

        do
        {
            Console.Write("Bitte gib eine Zahl zwischen 1 und 12 ein: ");
            int zahl = int.Parse(Console.ReadLine());

            string monat;

            switch (zahl)
            {
                case 1: monat = "Januar"; break;
                case 2: monat = "Februar"; break;
                case 3: monat = "März"; break;
                case 4: monat = "April"; break;
                case 5: monat = "Mai"; break;
                case 6: monat = "Juni"; break;
                case 7: monat = "Juli"; break;
                case 8: monat = "August"; break;
                case 9: monat = "September"; break;
                case 10: monat = "Oktober"; break;
                case 11: monat = "November"; break;
                case 12: monat = "Dezember"; break;
                default: monat = "Ungültige Eingabe! Bitte eine Zahl von 1 bis 12 eingeben."; break;
            }

            Console.WriteLine(monat);

            Console.Write("Noch einen Monat eingeben? (j/n): ");
            nochmal = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine();

        }
        while (nochmal == 'j'|| nochmal == 'J');
    }
}