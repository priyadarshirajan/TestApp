using System;
using System.Linq;

namespace firstApp1
{
    internal static  class LeetCodeProblems
    {
        public static int Divide(int dividend, int divisor)
        {
            long result = (long)dividend / (long)divisor;

            return result > int.MaxValue ? int.MaxValue : (int)result;
        }

        public static int StrStr(string haystack, string needle)
        {
            return haystack.IndexOf(needle);

        }

        public static int LengthOfLastWord(string s)
        {
            var last = s.Trim().Split(' ').LastOrDefault();
            return last.Length;
        }

        public static int ScoreOfString(string s)
        {
            int total = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                total += Math.Abs((int)s[i] - (int)s[i + 1]);
            }

            return total;
        }
    }
}
