using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstApp1
{
    internal class TwoSum
    {
        public int[] Write(int[] nums, int target)
        {
            var result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if(i != j)
                    {
                        if(nums[i] + nums[j] == target && result.Count == 0)
                        {
                            result.Add(i);
                            result.Add(j);

                            break;
                        }
                    }
                }
            }

            return result.ToArray();
        }
    }
}
