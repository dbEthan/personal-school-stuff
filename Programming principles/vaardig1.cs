
class Program
    {
        enum Menu
        {
            KoopViewers=1,
            KoopAdSpace,
            Niets
        }
        enum Streamer
        {
            Beginner,
            Gevorderde,
            Faker,
            Onbekend
        }
        static void Main(string[] args)
        {
            //DEEL1
            const int MULTIPLIER = 1000;
            Random ranGen = new Random();

            double viewers = (ranGen.Next(1, 6)) * MULTIPLIER;
            double credits = ranGen.Next(100, 601);
            string userName = Environment.UserName;
            Console.WriteLine($"Welkom {userName} op APstream!\nEr kijken momenteel {viewers} viewers.\nJe budget is {credits} credits.");

            //DEEL2
            const int PRIJS_VIEWERS = 200;
            const int PRIJS_ADSPACE = 300;
            bool viewersGekocht = false;
            bool adspaceGekocht = false;
            Console.WriteLine($"\nWat wil je doen?\n\t1.Koop 1000 viewers (200 credits)\n\t2.Koop adspace viewers (300 credits)\n\t3.Niets");
            int input = int.Parse(Console.ReadLine());
            Menu menuKeuze = (Menu)input;

            switch (menuKeuze)
            {
                case Menu.KoopViewers:
                    if (credits >= PRIJS_VIEWERS)
                    {
                        credits -= PRIJS_VIEWERS;
                        viewers += 1000;
                        viewersGekocht = true;
                        Console.WriteLine($"Viewers gekocht. Je nieuwe statistieken zijn: {viewers} viewers en {credits} credits.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Niet genoeg credits.");
                        Console.ResetColor();
                    }
                    break;
                case Menu.KoopAdSpace:
                    if (credits >= PRIJS_ADSPACE)
                    {
                        credits -= PRIJS_ADSPACE; //In de opdracht staat dat hier met 200 credits verlaagd moet worden. Zou dit echter niet 300 credits moeten zijn?
                        if (viewers % 2000 == 0)
                        {
                            viewers += 1000;
                        }
                        else
                            viewers += 500;
                        adspaceGekocht = true;
                        Console.WriteLine($"Adspace viewers gekocht. Je nieuwe statistieken zijn: {viewers} viewers en {credits} credits.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Niet genoeg credits.");
                        Console.ResetColor();
                    }
                    break;
                case Menu.Niets:
                    break;
                default:
                    credits -= Math.Floor(Math.Round(credits / 10, 2));
                    viewers -= Math.Ceiling(viewers / 4);
                    Console.WriteLine($"Dit is geen geldige keuze. Je verliest 1 op 4 viewers en 10% van je budget.\nJe finale statistieken zijn: {viewers} viewers en {credits} credits.");
                    break;
            }

            //DEEL3
            Streamer categorie = Streamer.Onbekend;

            if (credits <= 200 && viewers <= 4000)
            {
                categorie = Streamer.Beginner;
            }
            else if (viewers >= 5000 && (viewersGekocht == true || adspaceGekocht == true))
            {
                categorie = Streamer.Gevorderde;
            }
            else if (viewers <= 4000 && adspaceGekocht == true)
            {
                categorie = Streamer.Faker;
            }
            else
            {
                categorie = Streamer.Onbekend;
            }
            Console.WriteLine($"Jouw streamertype is {categorie}.");
            if (categorie == Streamer.Faker)
            {
                Console.WriteLine("Wil je dit profiel omzetten naar Gevorderde voor 100 credits? (j/n)");
                string inputFaker = Console.ReadLine();
                if (inputFaker == "j")
                {
                    Console.WriteLine("Word beter!");
                    Environment.Exit(0);
                }
                else if (inputFaker == "n")
                    Environment.Exit(0);
            }
        }
    }
