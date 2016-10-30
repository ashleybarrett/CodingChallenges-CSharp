using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace CodingChallenges_CSharp.EquilibriumIndex
{
    [TestFixture]
    public class EquilibriumIndexFinderTests
    {
        public static IEnumerable<object[]> GetTests()
        {
            yield return new object[] { 1, null, CreateList(-1) };
            yield return new object[] { 2, CreateList(), CreateList(-1) };
            yield return new object[] { 3, CreateList(5), CreateList(0) };
            yield return new object[] { 4, CreateList(5, 6), CreateList(-1) };
            yield return new object[] { 5, CreateList(5, 1, 6, 0), CreateList(-1) };
            yield return new object[] { 6, CreateList(-7, 1, 5, 2, -4, 3, 0), CreateList(3, 6) };
            yield return new object[] { 7, CreateList(10, 2, 5, -2, 1, 1, 4, 1), CreateList(1) };
            yield return new object[] { 8, CreateList(10, 2, 5, -2, 1, 1, 4, 1, 0), CreateList(1) };
            yield return new object[] { 9, CreateList(1, 2, 3, 4, 3, 2, 1), CreateList(3) };
            yield return new object[] { 10, CreateList(10, 2, 5, -2, 1, 1, 4, 1, 1), CreateList(-1) };
            yield return new object[] { 11, CreateList(-1, 3, -4, 5, 1, -6, 2, 1), CreateList(1, 3, 7) };
            yield return new object[] { 12, CreateList(5, 10), CreateList(-1) };
        }

        private static IEnumerable<int> CreateList(params int[] ints)
        {
            return ints;
        }

        private bool SequencesMatch(IEnumerable<int> actual, IEnumerable<int> expected)
        {
            var match = actual.Count() == expected.Count();

            if (match)
            {
                match = actual.All(x => expected.Any(y => y == x));
            }

            return match;
        }

        [Test]
        [TestCaseSource("GetTests")]
        public void RunTests(int testId, int[] inputSequence, IEnumerable<int> expectedSequence)
        {
            var actualSequence = EquilibriumIndexFinder.Find(inputSequence);
            var sequencesMatch = SequencesMatch(actualSequence, expectedSequence); 
            Assert.That(sequencesMatch, Is.True); 
        }
    }
}
