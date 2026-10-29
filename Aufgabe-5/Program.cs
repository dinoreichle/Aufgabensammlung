using System.Globalization;

namespace Aufgabe_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele Kilometer möchtest du rennen?");
            double anzahlKm = Convert.ToDouble(Console.ReadLine());


            double runden = Math.Ceiling(anzahlKm / 0.4);

            if (anzahlKm > 42)
            {
                Console.WriteLine("Das schaffst du nicht!");
            }
            else if (anzahlKm <=0)
            {
                Console.WriteLine("Du willst echt " + anzahlKm + "Km rennen?");
            }

            else
            {
                Console.WriteLine("Das sind " + runden + " runden. Bereit für den Lauf?(ja/nein)");
                string bereit = Console.ReadLine();

                if (bereit == "ja" || bereit == "Ja")
                {
                    int rundenGemacht = 1;
                    while (rundenGemacht <= runden)
                    {
                        Console.WriteLine("Du läufst Runde " + rundenGemacht + ".");
                        rundenGemacht++;
                    }
                    Console.WriteLine("Du hast es geschafft!");
                }

                else
                {
                    Console.WriteLine("Morgen vielleicht.");
                }

            }


        }
    }
}
