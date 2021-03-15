using System;

namespace MatrixRain
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is my first iteration and probably a very bad way to make the console rain Matrix code.
            //I'm simply using an X and Y position of the console window
            //My current Draw method only allows drawing on a descending line, without changing or updating characters above the current line
            //I need to find a way for characters to know who their neighbouring characters are, and whether their neighbouring spot is occupied by a character
            //perhaps create a canvas or.... matrix to solve this issue? :)

            Droplet[] dropletArr = new Droplet[15];


            while (true)
            {
                for (int i = 0; i < dropletArr.Length; i++)
                {
                    dropletArr[i] = new Droplet();

                    dropletArr[i].SetStartPos();
                }
                for (int j = 0; j < Console.WindowHeight; j++)
                {
                    for (int i = 0; i < dropletArr.Length; i++)
                    { 
                        dropletArr[i].Update();
                        if (i % 2 == 0)
                            dropletArr[i].DrawOnScreen();
                        else
                            dropletArr[i].ClearFromScreen();
                        System.Threading.Thread.Sleep(20);
                    }
                }
            }
        }
    }
}
