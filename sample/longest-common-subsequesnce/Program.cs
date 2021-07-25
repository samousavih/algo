using System;

namespace lcs_efficent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(lcsEfficent("ABCGDEFGHIG", "ABDCGHSIGk"));
        }

        static int lcsEfficent(string x, string y)
        {
            var c = new int[x.Length, y.Length];
            for(var i = 0; i< x.Length; i++)
            {
                c[i, 0] = 0;
            }
            for (var i = 0; i < y.Length; i++)
            {
                c[0, i] = 0;
            }
            for(var i = 1; i< x.Length; i++)
            {
                for(var j = 1; j < y.Length; j++)
                {
                    if(x[i] == y[j])
                    {
                        c[i, j] = c[i - 1, j - 1] + 1;
                    }
                    else 
                    {
                        c[i, j] = Math.Max(c[i - 1, j], c[i, j - 1]);
                    }
                }
            }
            return c[x.Length-1,y.Length-1];
        }
    }
}
