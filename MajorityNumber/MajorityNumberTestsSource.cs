using System.Collections.Generic;

namespace CodingChallenges_CSharp.MajorityNumber
{
    public static class MajorityNumberTestsSource
    {
        public static IEnumerable<object[]> GetMajorityNumberTests()
        {
            yield return new object[] { 1, null, null };
            yield return new object[] { 2, new List<int>(), null };
            yield return new object[] { 3, new List<int> { 1 }, 1 };
            yield return new object[] { 4, new List<int> { 1, 2 }, null };
            yield return new object[] { 5, new List<int> { 1,2,1 }, 1 };
            yield return new object[] { 6, new List<int> { 1,2,1,2 }, null };
            yield return new object[] { 7, new List<int> { 1,2,1,1,1,5,8,10,1,1 }, 1 };
            yield return new object[] { 8, new List<int> { 1, 2, 1, 1, 1, 5, 8, 10, 1, 5 }, null };
            yield return new object[] { 9, new List<int> { 1, 1, 1, 1, 1, 2, 2, 2, 2, 2 }, null };
            yield return new object[] { 10, new List<int> { 1,2,3,4,5,6,7,8, 9, 1 }, null };
        }
    }
}