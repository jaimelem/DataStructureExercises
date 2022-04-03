using System;
using System.Collections;

namespace PlayingWithMatches
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());
            var matches = new Hashtable { {0, 6}, { 1, 2 }, { 2, 5 }, { 3, 5 }, { 4, 4 }, { 5, 5 }, { 6, 6 },  { 7, 3 }, { 8, 7 }, { 9, 6 } };
            string resultSum = "";

            for (int i = 0; i < testCases; i++)
            {
                var data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                var sum = data[0] + data[1];
                int total = 0;

                resultSum = sum.ToString();

                for (int j = 0; j < resultSum.Length; j++)
                {
                    var sub = resultSum[j];
                    total = int.Parse(matches[int.Parse(sub.ToString())].ToString()) + total;
                }

                Console.WriteLine(total);
            }
        }
    }
}
