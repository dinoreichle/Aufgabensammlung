namespace Aufgabe_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele Tage hat der Monat, Für den du die Sekundenzahl berechnen willst?");
            int tage = Convert.ToInt32(Console.ReadLine());
            int stunden = tage * 24;
            int minuten = stunden * 60;
            int sekunden = minuten * 60;

            if (tage != 28 && tage != 29 && tage != 30 && tage != 31)
            {
                Console.WriteLine("Es gibt kein Monat der " + tage + " Tage hat.");
            }
            else
            {
                Console.WriteLine("Ein Monat mit " + tage + " Tagen hat " + sekunden + " Sekunden!");
            }
            
        }
    }
}
