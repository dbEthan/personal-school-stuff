//De Bois Ethan 1IT5

using System;

namespace DeBois_Ethan_1IT5
{
    class Program
    {
        //DEEL 1
        static char[] MaakSignaal()
        {
            const char MIN_VALUE = 'A';
            const char MAX_VALUE = 'Z';
            const int ARR_LENGTH = 100;
            Random r = new Random();
            char[] resultArr = new char[ARR_LENGTH];
            for (int i = 0; i < resultArr.Length; i++)
            {
                resultArr[i] = (char)r.Next(MIN_VALUE, MAX_VALUE + 1);
            }
            return resultArr;
        }

        //DEEL 2
        static void VisualiseerCode(char[] arr)
        {
            const string NIET_VERDACHT = ".";
            bool verdachtKleur = false;
            for (int i = 0; i < arr.Length; i++)
            {
                verdachtKleur = NeedsColor(arr[i]);
                if (verdachtKleur)
                    WriteCharInRed(arr[i]);
                else
                    Console.Write(NIET_VERDACHT);
            }
        }
        static bool NeedsColor(char x)
        {
            bool needsColor = false;
            switch (x)
            {
                case 'X':
                case 'Y':
                case 'Z':
                case 'Q':
                    needsColor = true;
                    break;
            }
            return needsColor;
        }
        static void WriteCharInRed(char x)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(x);
            Console.ResetColor();
        }

        //DEEL 3
        static void AnalyseerCode(char[] arr)
        {
            bool verdachtSignaal = false;
            int output = CountSpecials(arr);
            Console.WriteLine($"\nEr werden {output} speciale tekens gevonden.");
            verdachtSignaal = IsVerdacht(output);
            if (verdachtSignaal)
                Console.WriteLine("Dit is een verdacht signaal.");
            else
                Console.WriteLine("Dit is geen verdacht signaal.");
        }
        static int CountSpecials(char[] arr)
        {
            int teller = 0;
            bool verdachtChar = false;
            for (int i = 0; i < arr.Length; i++)
            {
                verdachtChar = NeedsColor(arr[i]);
                if (verdachtChar)
                    teller++;
            }
            return teller;
        }
        static bool IsVerdacht(int x)
        {
            const int VEELVOUD = 3;
            bool verdacht = false;
            if (x % VEELVOUD == 0)
                verdacht = true;
            return verdacht;
        }

        static void Main(string[] args)
        {
            const char REQ_INPUT = 'j';
            char input = REQ_INPUT;
            while (input == REQ_INPUT)
            {
                Console.Clear();
                //DEEL 1
                char[] code = MaakSignaal();
                Console.WriteLine($"Onderschepte code:");
                Console.WriteLine(code);

                //DEEL 2
                Console.WriteLine($"Detectie van verdachte tekens:");
                VisualiseerCode(code);

                //DEEL 3
                AnalyseerCode(code);

                Console.WriteLine($"Wenst u opnieuw te beginnen?");
                input = Convert.ToChar(Console.ReadLine().ToLower());
            }
        }
    }
}
