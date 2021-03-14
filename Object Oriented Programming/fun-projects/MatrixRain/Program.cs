using System;

namespace MatrixRain
{
    class Program
    {
        static void Main(string[] args)
        {
            Droplet[] dropletArr = new Droplet[15];

            for (int i = 0; i < dropletArr.Length; i++)
            {
                dropletArr[i] = new Droplet();

                dropletArr[i].SetStartPos();
            }

            for (int j = 0; j < 100; j++)
            {
                for (int i = 0; i < dropletArr.Length; i++)
                {
                    dropletArr[i].CharPosUpdate();
                    dropletArr[i].DrawOnScreen();
                    System.Threading.Thread.Sleep(20);
                }
                
            }
        }
    }
}
