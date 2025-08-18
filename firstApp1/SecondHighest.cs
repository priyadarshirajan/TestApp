using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstApp1
{
    internal class SecondHighest
    {
        public void Write()
        {
            int[] someArray = { 9000, 30000, 5, 455 };

            int maxValue = 0;
            int secondHighest = 0;

            foreach (int num in someArray)
            {
                if (num > maxValue)
                {
                    secondHighest = maxValue;

                    maxValue = num;
                }
                else if (num > secondHighest && num < maxValue)
                {
                    secondHighest = num;
                }
            }

            Console.WriteLine(secondHighest);
        }
    }
}
