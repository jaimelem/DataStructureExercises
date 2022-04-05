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
            int[] arr = new int[] { -1, -3, 2, 5, 1, -5, 3, -5, 3, 5 };

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

            return Distinct(result.ToArray());
        }

        private static int[] Distinct(int[] arr)
        {
            List<int> result = new List<int>();

            result.Add(arr[0]);

            for (int j = 1; j < arr.Length-1; j++)
            {
                if (arr[j-1] != arr[j])
                {
                    result.Add(arr[j]);
                }
            }

            return result.ToArray();
        }
    }
}
