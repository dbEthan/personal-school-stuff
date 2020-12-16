class Program
    {
        enum Menu
        {
            KoopViewers = 1,
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
        static double ViewerGen()
        {
            Random ranGen = new Random();
            const int MIN_VIEW = 1;
            const int MAX_VIEW = 5;
            const int MULTIPLIER = 1000;
            double viewers = (ranGen.Next(MIN_VIEW, MAX_VIEW + 1)) * MULTIPLIER;
            return viewers;
        }
        static double CreditGen()
        {
            Random ranGen = new Random();
            const int MIN_CRED = 100;
            const int MAX_CRED = 600;
            double credits = ranGen.Next(MIN_CRED, MAX_CRED + 1);
            return credits;
        }
        static void Main(string[] args)
        {
            //DEEL1
            double viewers = ViewerGen();
            double credits = CreditGen();
            string userName = Environment.UserName;
            Console.WriteLine($"Welkom {userName} op APstream!\nEr kijken momenteel {viewers} viewers.\nJe budget is {credits} credits.");

            //DEEL2
            const int PRIJS_VIEWERS = 200;
            const int PRIJS_ADSPACE = 300;
            const int VIEWERS_GEKOCHT = 1000;
            Console.WriteLine($"\nWat wil je doen?\n\t1.Koop {VIEWERS_GEKOCHT} viewers ({PRIJS_VIEWERS} credits)\n\t2.Koop adspace viewers ({PRIJS_ADSPACE} credits)\n\t3.Niets");
            int input = int.Parse(Console.ReadLine());
            Menu menuKeuze = (Menu)input;

            switch (menuKeuze)
            {
                case Menu.KoopViewers:
                    if (credits >= PRIJS_VIEWERS)
                    {
                        credits -= PRIJS_VIEWERS;
                        viewers += VIEWERS_GEKOCHT;
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
                            viewers += VIEWERS_GEKOCHT;
                        }
                        else
                            viewers += VIEWERS_GEKOCHT / 2;
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
                categorie = Streamer.Beginner;
            else if (viewers >= 5000 && (menuKeuze == Menu.KoopViewers || menuKeuze == Menu.KoopAdSpace))
                categorie = Streamer.Gevorderde;
            else if (viewers <= 4000 && menuKeuze == Menu.KoopAdSpace)
                categorie = Streamer.Faker;
            else
                categorie = Streamer.Onbekend;
            Console.WriteLine($"Jouw streamertype is {categorie}.");
            if (categorie == Streamer.Faker)
            {
                Console.WriteLine("Wil je dit profiel omzetten naar Gevorderde voor 100 credits? (j/n)");
                string inputFaker = Console.ReadLine();
                if (inputFaker == "j")
                    Console.WriteLine("Word beter!");
                Environment.Exit(0);
            }
        }
    }