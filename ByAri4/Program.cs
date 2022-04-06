using System;
using System.Collections.Generic;

namespace ByAri4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            List<int> auxArr = new List<int>();

            int sum1Middle = 0, sum2Middle = 0;

            for (int j = 0; j < arr.Length; j++)
            {
                int firstMiddle = j + 1;

                for (int k = firstMiddle - 1; k < firstMiddle; k++)
                {
                    sum1Middle += arr[k];
                }

                if (firstMiddle >= 2)
                {
                    int secondMiddle = arr.Length - firstMiddle;

                    for (int k = secondMiddle - 1; k < secondMiddle + 1; k++)
                    {
                        if (k <= 0)
                        {
                            break;
                        }
                        else
                        {
                            sum2Middle += arr[k];
                        }
                    }
                }

                int result = sum2Middle - sum1Middle;

                if (result > 0 || result < 0)
                {
                    auxArr.Add(result);
                }            
            }

            Console.WriteLine(getMin(auxArr.ToArray()));
        }

        private static int getMin(int[] arr)
        {

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    int actual = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = actual;
                }
            }

            return arr[arr.Length-1];
        }
    }
}
