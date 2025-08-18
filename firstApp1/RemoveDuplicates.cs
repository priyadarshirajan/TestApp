using System.Collections.Generic;

namespace firstApp1
{
    internal static class RemoveDuplicates
    {
        public static int Write(int[] nums)
        {
            var lis = new List<int>();

            foreach (int num in nums)
            {
                foreach (int num2 in nums)
                {
                    if(num == num2 && !lis.Contains(num2))
                    {
                        lis.Add(num2);
                    }
                }
            }

            return lis.Count;
        }
    }
}
