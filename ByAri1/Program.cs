using System;

namespace ByAri1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[6,6] {{1, 1, 1, 0, 0, 0},
                                       {0, 1, 0, 0, 0, 0},
                                       {1, 1, 1, 0, 0, 0},
                                       {0, 0, 2, 4, 4, 0},
                                       {0, 0, 0, 2, 0, 0},
                                       {0, 0, 1, 2, 4, 0}};

            Console.WriteLine(GetMax(mat));
        }

        private static int GetMax(int[,] hourglass)
        {
            int max_value = int.MinValue;

            for (int i = 0; i < hourglass.GetLength(0) -2; i++)
            {
                for (int j = 0; j < hourglass.GetLength(1) - 2; j++)
                {
                    int sum = (hourglass[i, j] + hourglass[i, j + 1] +
                               hourglass[i, j + 2]) + (hourglass[i + 1, j + 1]) +
                              (hourglass[i + 2, j] + hourglass[i + 2, j + 1] +
                               hourglass[i + 2, j + 2]);

                    max_value = Math.Max(max_value, sum);
                }
            }

            return max_value;
        }
    }
}
