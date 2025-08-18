using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstApp1
{
    internal static class ValidParentheses
    {
        public  static bool IsValid(string s)
        {
            if (s.Length % 2 != 0)
            {
                return false;
            }
            
            s = s.Trim();

            var charCount = s.Length;

            int i = 0;
            while(s.Length > 0 && i < charCount)
            {
                s = s.Replace("()", "");
                s = s.Replace("[]", "");
                s = s.Replace("{}", "");

                i++;
            }

            return s.Length == 0;
        }
    }
}
