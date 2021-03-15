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
        
        //X and Y positions of the object
        public int X { get; private set; }
        public int Y { get; private set; } = Y_START_POS;

        //original start position on the X axis
        private int xStartPos;

        public void SetStartPos()
        {
            X = r.Next(1, Console.WindowWidth);
            xStartPos = X;
        }
        public void Update()
        {
            int chance = r.Next(1, 5);
            if (chance < 3)
                Y++;
        }
        public void Reset()
        {
            X = 0;
            Y = 0;
        }

        public void DrawOnScreen()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(X, Y);
            GiveColor();
            Console.WriteLine(CharRandomnizer());
            Console.ResetColor();
        }

        public void ClearFromScreen()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(xStartPos, Y);
            Console.WriteLine(" ");
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
