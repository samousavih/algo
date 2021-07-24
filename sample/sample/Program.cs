using System;
using System.Collections.Generic;
using System.Linq;

namespace sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Result.biggerIsGreater("dkhc"));
        }
    }

    class Result
    {

        /*
         * Complete the 'biggerIsGreater' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING w as parameter.
         */

        public static string biggerIsGreater(string input)
        {
            var w = input.ToCharArray();
            var c = w.Count() - 1;
            while (c > 0)
            {
                if (w[c] > w[c - 1])
                {
                    for (var d = w.Count() - 1; d >= c; d--)
                    {
                        if (w[d] > w[c - 1])
                        {
                            var newW = swap(w, d, c - 1);
                            var list = newW.ToList();
                            var result = list.Take(c).ToList().Concat(sort(list.Skip(c).ToList())).ToArray();
                            return new string(result);
                        }
                    }
                }
                c--;
            }

            return input;
        }
        static List<char> sort(List<char> input)
        {

            input.Sort();
            return input;
        }

        static char[] swap(char[] array, int first, int second)
        {
            var swap = array[first];
            array[first] = array[second];
            array[second] = swap;
            return array;
        }

    }
}
