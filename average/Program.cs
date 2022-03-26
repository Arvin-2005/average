using System;

namespace average
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int s = 0;
            int r;
            for (int i = 1; i <= 5; i++)
            {
                a = int.Parse(Console.ReadLine());
                s = s + a;
            }
            r = s / 5;

            Console.Write(r);
        }
    }
}
