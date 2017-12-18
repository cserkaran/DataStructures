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


        private static void MergeSortAlgo(List<int> a,int start,int end)
        {
            if (start < end)
            {
                var mid = (start + end) / 2;

                MergeSortAlgo(a, start, mid);
                MergeSortAlgo(a, mid + 1, end);
                Merge(a, start, end, mid);
            }
        }

        private static void Merge(List<int> a, int start, int end, int mid)
        {
            int[] left = new int[mid - start + 1];
            int[] right = new int[end - mid];

            var i = 0;
            for (int count = start; count <= mid; count++)
            {
                left[i] = a[count];
                i++;
            }

            var j = 0;
            for (int count = mid + 1; count <= end; count++)
            {
                right[j] = a[count];
                j++;
            }


            // merge left and right.
            i = 0; j = 0;
            for (int k = start; k <= end; k++)
            {

                if (left[i] < right[j])
                {
                    a[k] = left[i];
                    i = i + 1;
                }
                else
                {
                    a[k] = right[j];
                    j = j + 1;
                }
            }
            
        }
    }
}
