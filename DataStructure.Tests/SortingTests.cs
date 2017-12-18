using DataStructures.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DataStructure.Tests
{
    public class SortingTests : IDisposable
    {
        List<int> list;
        List<int> listAfterSorting;


        public SortingTests()
        {
            list = new List<int> { 5,2,4,6,1,3 };
            listAfterSorting = list.ToList();

        }

        public void Dispose()
        {
            list.Clear();
            list = null;
            GC.SuppressFinalize(this);
        }

        [Fact]
        public void Test_InsertionSortAscending()
        {
            InsertionSort.SortAscending(listAfterSorting);
            CheckIfListSortedAscending();
        }

        private void CheckIfListSortedAscending()
        {
            var isOrderedAscending = listAfterSorting.SequenceEqual(list.OrderBy(x => x));
            Assert.True(isOrderedAscending);
        }

        [Fact]
        public void Test_InsertionSortDescending()
        {
            InsertionSort.SortDescending(listAfterSorting);
            CheckIfListSortedDescending();
        }

        private void CheckIfListSortedDescending()
        {
            var isOrderedDescending = listAfterSorting.SequenceEqual(list.OrderByDescending(x => x));
            Assert.True(isOrderedDescending);
        }

        [Fact]
        public void Test_MergeSortAscending()
        {
            MergeSort.Sort(listAfterSorting);
            CheckIfListSortedAscending();
        }
    }
}
