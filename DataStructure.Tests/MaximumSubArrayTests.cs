using DataStructures;
using System.Collections.Generic;
using Xunit;

namespace DataStructure.Tests
{
    public class MaximumSubArrayTests
    {
        [Fact]
        public void Test_MaximumSubArray1()
        {
            var list = new List<int> {13,-3,-25,20,-3,-16,-23,18,20,-7,12,-5,-22,15,-4,7 };

            

            var result = MaximumSubArray.Find(list);

            Assert.Equal(7, result.Low);
            Assert.Equal(10, result.High);
            Assert.Equal(43, result.Sum);
        }

        [Fact]
        public void Test_MaximumSubArray2()
        {
            var list = new List<int> { 13, -3, -25, 20, -3};



            var result = MaximumSubArray.Find(list);

            Assert.Equal(3, result.Low);
            Assert.Equal(4, result.High);
            Assert.Equal(17, result.Sum);
        }

    }
}
