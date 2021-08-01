using System;

namespace quick_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            int n = arr.Length;

            quickSort(arr, 0, n - 1);
            foreach (var a in arr)
            {
                Console.WriteLine(a);
            }
        }
        static void quickSort(int[] arr, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            var p = pivot(arr, start, end);
            quickSort(arr, start, p - 1);
            quickSort(arr, p + 1, end);

        }

        static int pivot(int[] arr, int start, int end)
        {
            var x = arr[end];
            var cp = end;
            var i = start - 1;
            for(var j =start; j< end;j++)
            {
                if(arr[j] < x)
                {
                    i++;
                    swap(arr,i, j);
                }
            }
            swap(arr, i + 1, end);
            return i+1;
        }
        static void swap(int[] arr,int i, int j)
        {
            
            var temp = arr[j];
            arr[j] = arr[i];
            arr[i] = temp;
        }
    }
}
