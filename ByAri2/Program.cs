using System;

namespace ByAri2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var arrayAux = Array.ConvertAll(input, int.Parse);

            int [] array = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                var num = input[i];
                var result = 0;

                for (int j = 0; j < num.Length; j++)
                {
                    result += int.Parse(num[j].ToString());
                }

                array[i] = result;
            }

            for (int i = 0; i <= array.Length-1; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int actualElement1 = arrayAux[i];
                        arrayAux[i] = arrayAux[j];
                        arrayAux[j] = actualElement1;

                        int actualElement2 = array[i];
                        array[i] = array[j];
                        array[j] = actualElement2;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", Array.ConvertAll(arrayAux, Convert.ToString)));
        }
    }
}
