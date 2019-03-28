using System;

namespace FunStuffYeet
{
    class Program
    {
        static void Main()
        {
            for (int q = 1; q < 10; q++)
            {
                for (int i = 1; i < 40; i++)
                {
                    Console.SetWindowSize(i, i);
                    System.Threading.Thread.Sleep(50);
                }
            }
        }
    }
}
