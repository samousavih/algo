using System;

namespace rod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(maxPriceRod(10,new int[] {1,2,3,4,5,6,7,8,9,10 }, new int[] {1,5,8,9,10,17,17,20,24,30 } ));
        }

        static int maxPriceRod(int n,int[] len,int[] prices )
        {
            if(n <= 1)
            {
                return prices[0];
            }
            var max = 0;
            for (var i = 1; i < n; i++)
            {
                var localmax = Math.Max(maxPriceRod(n - i, len, prices) + prices[i - 1], prices[n - 1]);
                max = Math.Max(localmax, max);
            }
            return max;
             
        }
    }
}
