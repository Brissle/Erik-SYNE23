using System;

class Program
{
    static void Main(string[] args)
    {
        bool spelaIgen = true;

        while (spelaIgen)
        {
            Console.Write("Vad är din energinivå? Ange ett heltal: ");
            if (int.TryParse(Console.ReadLine(), out int energiNivå))
            {
                int distans = 0;
                while (distans < 10)
                {
                    Console.WriteLine($"Du har {energiNivå} energi och har täckt {distans} km.");
                    Console.Write("Välj din hastighet (snabbast/snabb/måttlig/långsam/promenad): ");
                    string hastighet = Console.ReadLine().ToLower();

                    int energiKostnad = 0;
                    int avståndTäckt = 0;

                    switch (hastighet)
                    {
                        case "snabbast":
                            energiKostnad = 15;
                            avståndTäckt = 2;
                            break;
                        case "snabb":
                            energiKostnad = 10;
                            avståndTäckt = 1;
                            break;
                        case "måttlig":
                            energiKostnad = 8;
                            avståndTäckt = 1;
                            break;
                        case "långsam":
                            energiKostnad = 5;
                            avståndTäckt = 1;
                            break;
                        case "promenad":
                            energiKostnad = 2;
                            avståndTäckt = 1;
                            break;
                        default:
                            Console.WriteLine("Ogiltig hastighet. Försök igen.");
                            break;
                    }

                    if (energiNivå >= energiKostnad)
                    {
                        energiNivå -= energiKostnad;
                        distans += avståndTäckt;
                    }
                    else
                    {
                        Console.WriteLine("Du har inte tillräckligt med energi för den hastigheten.");
                        break; // Börja om spelet om energin tar slut
                    }
                }

                if (distans >= 10)
                {
                    Console.WriteLine("Grattis! Du har nått 10 km och vunnit spelet!");
                }
                else
                {
                    Console.WriteLine($"Du har tagit slut på energi efter att ha täckt {distans} km.");
                }

                Console.Write("Vill du spela igen (ja/nej)? ");
                string svar = Console.ReadLine();

                if (svar.ToLower() != "ja")
                {
                    spelaIgen = false;
                }
            }
            else
            {
                Console.WriteLine("Ogiltig inmatning av energinivå.");
            }
        }
    }
}
