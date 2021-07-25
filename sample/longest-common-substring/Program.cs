using System;

namespace lcs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(lcs("ABCGDEFGHIG", "ABDCGHSIGk"));
        }

        static int lcs(string x, string y)
        {
            var biggerLen = x.Length;
            var smallerLen = y.Length;
            var common = new int[smallerLen, smallerLen,biggerLen];

            for (var i = 0; i < smallerLen; i++)
            {
                
                for (var j = 0; j < smallerLen; j++)
                {
                    for (var k = 0; k < biggerLen; k++)
                    {

                        common[i, j, k] = -1;
                    }

                }
            }

            for (var i = 0; i < smallerLen; i++)
            {
                var k = 0;
                for (var j = 0; j < biggerLen; j++)
                {
                    if (x[j] == y[i])
                    {
                        common[0, i,k] = j;
                        k++;
                    }
                }
            }
            var maxComSub = 0;

            for (var lcsLen = 1; lcsLen < smallerLen; lcsLen++)
            {
                for (var c = 0; c < smallerLen - 1; c++)
                {
                    for (var k = 0; k< biggerLen; k++) {
                        if (common[lcsLen - 1, c,k] > -1)
                        {
                            if (common[lcsLen - 1, c,k] + 1 < biggerLen)
                            {
                                if (y[c + 1] == x[common[lcsLen - 1, c,k] + 1])
                                {
                                    common[lcsLen, c + 1,k] = common[lcsLen - 1, c,k] + 1;
                                    maxComSub = lcsLen + 1;
                                }
                            }
                        }
                    }

                }

            }
            return maxComSub;
        }
    }
}
