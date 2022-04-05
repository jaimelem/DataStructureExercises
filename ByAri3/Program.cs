using System;
using System.Collections.Generic;
using System.Linq;

namespace ByAri3
{
    class Program
    {
        static void Main(string[] args)
        {
            //var arrayLength = int.Parse(Console.ReadLine());
            int[] arr = new int[] { -1, 2, 5, 1, -5, 3, -5, 5, -3, 3 };

            var r = Result(arr);

            for (int i = 0; i < r.Length; i++)
            {
                Console.WriteLine(r[i]);
            }
        }

        private static int[] Result(int[] arr)
        {
            List<int> result = new List<int>();

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int sum = arr[i] + arr[j];

                    if (sum == 0)
                    {
                        result.Add(Math.Abs(arr[i]));
                    }
                }
            }

            return result.Distinct().ToArray();
        }
    }
}
