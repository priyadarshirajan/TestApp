using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstApp1
{
    internal class Palindrome
    {
        public int MyProperty { get; set; }
        public bool IsPalindrome(int x)
        {
            var xAsString = x.ToString();

            var secondString = string.Empty;
            for (var i = xAsString.Length-1; i >= 0; i--)
            {
                secondString+= xAsString[i];
            }

            return xAsString.Equals(secondString);
        }
    }
}
