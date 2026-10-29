namespace Aufgabe_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int zahl = 1; zahl <= 30; zahl++)
            {
                if (zahl % 3 == 0 || zahl % 5 == 0)
                {
                    if (zahl == 30)
                    {
                        Console.Write(zahl);
                    }
                    else
                    {
                        Console.Write(zahl + ", ");
                    }
                }
            }
        }
    }
}
