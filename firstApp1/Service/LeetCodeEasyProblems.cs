using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstApp1
{
    internal static  class LeetCodeEasyProblems
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

        public static string ConvertDateToBinary(string date)
        {
            var result = "";

            foreach (var part in date.Split('-'))
            {
                var binary = Convert.ToString(int.Parse(part), 2);
                result += binary + "-";
            }

            return result.TrimEnd('-');
        }

        public static int LengthOfLongestSubstring(string s)
        {
            int previousNode = (int)s[0];

            int count = 1;

            for (int i = 0; i < s.Length-1; i++)
            {
                int first = (int)s[i];
                int next = (int)s[i+1];

                if(first + 1 == next)
                {
                    count++;
                }
            }

            return count;
        }

        public static string ConcatenateNumbers(string num1, string num2)
        {
            StringBuilder result = new StringBuilder();
            int carry = 0;
            int i = num1.Length - 1;
            int j = num2.Length - 1;

            while (i >= 0 || j >= 0 || carry > 0)
            {
                int digit1 = i >= 0 ? num1[i] - '0' : 0;
                int digit2 = j >= 0 ? num2[j] - '0' : 0;

                int sum = digit1 + digit2 + carry;
                result.Insert(0, sum % 10);
                carry = sum / 10;

                i--;
                j--;
            }

            return result.ToString();
        }

        public static bool WordPattern(string pattern, string s)
        {
            var words = s.Split(' ');
            if (pattern.Length != words.Length)
            {
                return false;
            }

            var dict = new Dictionary<char, string>();


            for (int i = 0; i < words.Length; i++)
            {
                char patternChar = pattern[i];

                string word = words[i];

                var isWordContains = dict.Any(k => k.Key == patternChar || k.Value == word);
                if (isWordContains == false)
                {
                    dict.Add(patternChar, word);
                }
            }

            bool result = true;
            for (int i = 0; i < words.Length; i++)
            {
                char patternChar = pattern[i];

                string word = words[i];

                result = dict.Any(k => k.Key == patternChar && k.Value == word);
                if (result == false)
                {
                    return false;
                }
            }

            return result;
        }

        public static async Task Test()
        {
            var res = Te();

            await Task.WhenAll(res);

            Parallel.For(0, 10, (i) =>
            {
                Te();
            });
        }

        public static int SingleNumber(int[] nums)
        {
            //if(nums.Length == 1)
            //{
            //    return nums[0];
            //}
            //int result = 0; 
            //foreach (int num in nums)
            //{
            //    var count = nums.Count(i => i == num);
            //    if(count == 1)
            //    {
            //        result = num;
            //        break;
            //    }
            //}

            //return result;

            int result = 0;
            foreach (int num in nums)
            {
                result ^= num;
            }
            return result;
        }









        public static async Task<int> Te()
        {
            await Task.Delay(1000);
            return 1;
        }

        static void TEst(out int k)
        {
            k = 5;
        }
    }
}
