using System;

namespace rod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(maxPriceRod(10, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, new int[] { 1, 5, 8, 9, 0, 17, 17, 20, 24, 30 },5));
        }

        static int maxPriceRod(int n, int[] len, int[] prices, int cutCost)
        {
            var dp = new int[n + 1];

            dp[0] = 0;
            dp[1] = 1;


            for (var i = 2; i <= n; i++)
            {
                var max = 0;
                for (var j = 1; j < i; j++)
                {
                    max = Math.Max(Math.Max(dp[j] + prices[i - j-1]-5, prices[i-1]),max);
                }

                dp[i] = max;
            }
            foreach(var d in dp)
            {
                Console.WriteLine(d);
            }
            return dp[n];

        }
    }
}
