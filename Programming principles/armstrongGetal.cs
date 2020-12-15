class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double lengte = input.Length;
            double exponent = Math.Pow(10, lengte - 1);
            double inputGetal = Convert.ToDouble(input);
            double multiplier = 1;
            int division = 1;
            double som = 0;

            while (multiplier <= exponent)
            {
                division = (int)inputGetal / (int)(exponent / multiplier);
                inputGetal -= (division * (exponent / multiplier));
                som += Math.Pow(division, lengte);
                multiplier *= 10;
            }
            if (som == Convert.ToDouble(input))
                Console.WriteLine("Dit is een Armstronggetal!");
            else
                Console.WriteLine("Dit is geen Armstronggetal. :(");


        }
    }