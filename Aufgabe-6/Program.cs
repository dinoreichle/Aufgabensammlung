namespace Aufgabe_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------");
            Console.WriteLine("Kleines 1x1");
            Console.WriteLine("-----------");
            Console.WriteLine();

            for (int zeile = 1; zeile <= 10; zeile++)
            {
                for (int spalte = 1; spalte <= 10; spalte++)
                {
                    Console.Write(zeile * spalte + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
