using System;

namespace rod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(maxPriceRod(10, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, new int[] { 1, 5, 8, 9, 10, 17, 17, 20, 24, 30 }));
        }

        static int maxPriceRod(int n, int[] len, int[] prices)
        {
            var dp = new int[n+1];
           
            dp[0] = 0;
           
            
            for (var i = 1; i <= n; i++)
            {
                var max = 0;
                for (var j = 0; j< i; j++)
                {
                    max = Math.Max(dp[j] + prices[i-j-1],max);
                }
                
                dp[i] =  max;
            }
            
            return dp[n];

        }
    }
}
