using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Sorting
{
    public class MergeSort
    {
        public static void Sort(List<int> items)
        {
            MergeSortAlgo(items, 0, items.Count - 1);
        }

        // 0 5
        // mid = (0 + 5)/ 2 = 2
        // 0 2
        // mid = (0 + 2) / 2 = 1
        // 0 1
        // mid = ( 0 + 1)/ 2 = 0
        // 0 0 ------
        // 3,5

        private static void MergeSortAlgo(List<int> items, int start, int end)
        {
            if(start < end)
            {
                int mid = (start + end) / 2;
                MergeSortAlgo(items,start, mid);
                MergeSortAlgo(items, mid + 1, end);
                Merge(items, start, mid, end);
            }
        }

        // 0 1 2 3 4 5
        // 5 2 4 6 1 3

        private static void Merge(List<int> items, int start, int mid, int end)
        {
            // end index of left array from start.
            var l = mid - start;
            // start index of right array from start.
            var r = l + 1;

            List<int> left = new List<int>();
            for (int k = start; k <= start + l; k++)
            {
                left.Add(items[k]);
            }

            List<int> right = new List<int>();
            for (int k = start + r; k <= end; k++)
            {
                right.Add(items[k]);
            }


            int i = 0;
            int j = 0;

            int m = start;
            for (m = start; m <= end; m++)
            {
                if (i >= left.Count || j >= right.Count)
                {
                    break;
                }

                if (left[i] <= right[j])
                {
                    items[m] = left[i];
                    i++;
                }
                else
                {
                    items[m] = right[j];
                    j++;
                }
            }
           

            for (int count = j; count < right.Count; count++)
            {
                items[m] = right[count];
                m++;
            }


            for (int count = i; count < left.Count; count++)
            {
                items[m] = left[count];
                m++;
            }
        


        }
    }
}
