using System;

namespace matrix_multiplication_dp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(minimumCost(3,new int[][] { new int[] { 10, 100 }, new int[] { 100, 5 }, new int[] { 5, 50 } }));
        }

        static int minimumCost(int n, int[][] a)
        {
            var m = new int[n,n];
            for(var i = 0; i < n; i++)
            {
                
                    
                    m[i, i] = 0;


                if (i < n - 1)
                {
                    m[i, i + 1] = a[i][0] * a[i][1] * a[i + 1][1];
                }
                    
                
            }
            

            for (var i = 1; i< n; i++)
            {
                var min = int.MaxValue;
                for( var start = 0; start<i; start++)
                {
                    for (var end = start;  end < i; end++)
                    {
                        min = Math.Min(m[start, end] + m[end+1,i] + a[start][0]*a[end][1] * a[i][1], min);
                    }
                    
                }
                m[0,i] = min;
            }
            
            return m[0, n - 1];
            
        }
    }
}
