using System;

namespace LoopCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int count = 1; count <= 5; count++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }

                for (int i = 10; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine(count);
           }

        }
    }
}
