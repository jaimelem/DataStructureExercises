using System;

namespace RedLightGreenLight
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCases; i++)
            {

                var data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                var players = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                var total = 0;

                for (int j = 0; j < players.Length; j++)
                {
                    if (players[j] > data[1])
                    {
                        total += 1;
                    }
                }

                Console.WriteLine(total);
            }
        }
    }
}
