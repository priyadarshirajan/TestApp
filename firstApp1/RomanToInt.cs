using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstApp1
{
    internal static class RomanToInt
    {
        public static int Write(string s)
        {
            Dictionary<char, int> romanMap = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            int total = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int value = romanMap[s[i]];

                if (i + 1 < s.Length && value < romanMap[s[i + 1]])
                {
                    total -= value;
                }
                else
                {
                    total += value;
                }
            }

            return total; 
        }
    }
}
