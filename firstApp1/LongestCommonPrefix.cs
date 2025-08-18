using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstApp1
{
    internal static class LongestCommonPrefix
    {
        public static string Write(string[] strs)
        {
            string prefix = strs[0];

            foreach (var str in strs)
            {
                while (!str.StartsWith(prefix))
                {
                    if (prefix.Length == 0)
                        return string.Empty;
                    prefix = prefix.Substring(0, prefix.Length - 1);
                }
            }
            return prefix;
        }
    }
}
