using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixRain
{
    class Droplet
    {
        Random r = new Random();
        const int Y_START_POS = 0;
        public char Char { get; set; }
        public int X { get; private set; }
        public int Y { get; private set; } = Y_START_POS;

        public void SetStartPos()
        {
            X = r.Next(1, Console.WindowWidth);
        }
        public void CharPosUpdate()
        {
            int chance = r.Next(1, 5);
            if (Y == 0)
                Y++;
            if (chance < 3)
                Y++;
        }

        public void DrawOnScreen()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(X, Y);
            GiveColor();
            Console.WriteLine(CharRandomnizer());
            Console.ResetColor();
        }

        public void GiveColor()
        {
            int chance = r.Next(1, 5);
            if (chance == 1)
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            else
                Console.ForegroundColor = ConsoleColor.Green;
        }

        public char CharRandomnizer()
        {
            Char = (char)r.Next('A', 'Z');
            return Char;
        }
    }
}
