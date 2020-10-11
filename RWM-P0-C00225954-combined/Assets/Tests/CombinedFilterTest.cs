
using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CombinedFilterTest
    {
        [Test]
        public void CombinedFilterSimple()
        {
            int[] input = { 4, 3, 6, 30, 10, 12 };
            int[] output = CombinedFilter.combinedFilter(input);
            int[] expected = { 4, 7, 10, 10, 15, 18 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
