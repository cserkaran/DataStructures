using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Sorting
{
    public static class InsertionSort
    {
        public static void SortAscending(List<int> items)
        {
            for(int i = 1; i < items.Count; i++)
            {
                var key = items[i];
                var j = i - 1;
                while (j >= 0 && items[j] > key)
                {
                    items[j + 1] = items[j];  
                    j--;
                }
                items[j + 1] = key;
            }

        }

        public static void SortDescending(List<int> items)
        {
            for(int i = 1; i < items.Count; i++)
            {
                int j = i - 1;
                var key = items[i];
                while (j >= 0 && items[j] < key)
                {
                    items[j + 1] = items[j];
                    j--;
                }
                items[j + 1] = key;

            }
        }

    }
}
