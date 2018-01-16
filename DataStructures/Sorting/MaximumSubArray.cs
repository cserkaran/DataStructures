using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public static class MaximumSubArray
    {
        public struct Result
        {
            public int Low { get; set; }

            public int High { get; set; }

            public int Sum { get; set; }
        }

        public static Result Find(List<int> a)
        {
            return Find(a, 0, a.Count - 1);
        }

        // 13,-3,-25,20,-3,-16,-23,18,20,-7,12,-5,-22,15,-4,7
        internal static Result Find(List<int> a, int low, int high)
        {
            if (low == high)
            {
                return new Result { High = high, Low = low, Sum = a[low] };
            }
            else
            {

                var mid = (low + high) / 2;

                Result max_array_left = Find(a, low, mid);

                Result max_array_right = Find(a, mid + 1, high);

                Result max_array_cross = FindMaxSubArrayCrossingMid(a, low, mid, high);


                if (max_array_left.Sum >= max_array_right.Sum && max_array_left.Sum >= max_array_cross.Sum)
                {
                    return max_array_left;
                }
                else if (max_array_right.Sum >= max_array_left.Sum && max_array_right.Sum >= max_array_cross.Sum)
                {
                    return max_array_right;
                }
                else
                {
                    return max_array_cross;
                }
            }
            
        }


        public static Result FindMaxSubArrayCrossingMid(List<int> a,int low,int mid,int high)
        {
            int left_sum = int.MinValue;
            int max_left = 0;
            int max_right = 0;
            var sum = 0;
           
            for(int i = mid; i >= low; i--)
            {
                sum = sum + a[i];
                if(sum > left_sum)
                {
                    left_sum = sum;
                    max_left = i;
                }
            }

            sum = 0;

            var right_sum = int.MinValue;
            for (int j = mid + 1; j <= high; j++)
            {
                sum = sum + a[j];
                if (sum > right_sum)
                {
                    right_sum = sum;
                    max_right = j;
                }
            }



            return new Result { Low = max_left, High = max_right, Sum = left_sum + right_sum } ;
        }
    }
}
