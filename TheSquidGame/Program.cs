using System;

namespace TheSquidGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCases; i++)
            {
                int player = int.Parse(Console.ReadLine());
                int[] prizePool = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int total = 0;

                for (int k = 0; k < prizePool.Length-1; k++)
                {
                    if (prizePool[k] < prizePool[k+1])
                    {
                        int actualElement = prizePool[k];
                        prizePool[k] = prizePool[k+1];
                        prizePool[k+1] = actualElement;
                    }
                }

                for (int l = 0; l < prizePool.Length-1; l++)
                {
                    total += prizePool[l];
                }

                Console.WriteLine(total);
            }
        }
    }
}
