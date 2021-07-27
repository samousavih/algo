using System;
using System.Collections.Generic;

namespace all_paranthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            var all = AllParenthesis(4);
            Console.WriteLine(all.Count);
            foreach (var p in all)
            {
                Console.WriteLine(p);
            }
        }

        public static List<string> AllParenthesis(int n)
        {
            var result = new List<string>();
            if (n == 1)
            {
                return new List<string> { "()" };
            }
            var before = AllParenthesis(n - 1);
            foreach (var s in before)
            {
                result.Add("(" + s + ")");
                result.Add("()" + s);
                if ("()" + s != s + "()")
                {
                    result.Add(s + "()");
                }
            }
            return result;
        }
    }
}
