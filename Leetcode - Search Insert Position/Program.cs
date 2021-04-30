using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___Search_Insert_Position
{
    class Program
    {
        //https://leetcode.com/problems/search-insert-position/
        static void Main(string[] args)
        {
            int[] x = { 1, 3, 5, 6 };
            int solution = reverseint(x, 5);
            Console.WriteLine(solution);
            Console.ReadKey();
        }
        static public int reverseint(int[] nums, int target)
        {
            var start = 0;
            var end = nums.Length - 1;
            var mid = 0;

            while (start <= end)
            {
                mid = start + (end - start) / 2;
                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] > target)
                    end = mid - 1;
                else start = mid + 1;
            }

            if (target > nums[mid])
                return mid + 1;

            return mid;
        }
    }
}
