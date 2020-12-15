
class Program
    {
        enum Case
        {
            CovidBeslissing,
            CovidQuiz,
            Quarantaine,
            Geen
        }
        static void Main(string[] args)
        {
            Case keuze = Case.Geen;
            char input = ' ';
            
            Console.WriteLine($"Wat wil je doen? \nCovidbeslissingshelper (c) \nCovidquiz (q)");
            char menuInput = char.Parse(Console.ReadLine());

            switch (menuInput)
            {
                case 'c':
                    keuze = Case.CovidBeslissing;
                    break;
                case 'q':
                    keuze = Case.CovidQuiz;
                    break;
                default:
                    Console.WriteLine("Verkeerde invoer.");
                    Environment.Exit(0);
                    break;
            }

            if (keuze == Case.CovidBeslissing)
            {
                Console.WriteLine("Vertoon je COVID symptonen? (j/n)");
                input = char.Parse(Console.ReadLine());
                if (input == 'j')
                {
                    keuze = Case.Quarantaine;
                }
                else
                {
                    Console.WriteLine("Ben je in nauw contact gekomen met iemand die ziek is? (j/n)");
                    input = char.Parse(Console.ReadLine());
                    if (input == 'j')
                    {
                        keuze = Case.Quarantaine;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Je mag naar school blijven gaan.");
                        Console.ResetColor();
                        Environment.Exit(0);
                    }
                }

            }
            if (keuze == Case.Quarantaine)
            {
                Console.WriteLine("Ga in quarantaine en laat je testen.");
                Console.WriteLine("Ben je positief getest? (j/n)");
                input = char.Parse(Console.ReadLine());
                if (input == 'j')
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("7 dagen quarantaine.");
                    Console.ResetColor();
                    keuze = Case.CovidQuiz;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Naar school wanneer genezen.");
                    Console.ResetColor();
                    keuze = Case.CovidQuiz;
                }
            }
            if (keuze == Case.CovidQuiz)
            {
                Random dobbel = new Random();
                int dagenInQ = dobbel.Next(1, 6);

                Console.WriteLine($"Je bent al {dagenInQ} dag(en) in quarantaine.");
                Console.WriteLine("Hoeveel dagen moet je nog wachten voor je je mag laten testen?");
                int inputQ = int.Parse(Console.ReadLine());
                int berekening = 5 - dagenInQ;

                if (inputQ == berekening )
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Fout! Het juiste antwoord is {berekening}.");
                }
                Console.ResetColor();
            }
        }
