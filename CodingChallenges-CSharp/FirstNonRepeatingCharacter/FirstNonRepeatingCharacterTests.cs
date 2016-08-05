using System.Collections.Generic;
using NUnit.Framework;

namespace CodingChallenges_CSharp.FirstNonRepeatingCharacter
{
    [TestFixture]
    public class FirstNonRepeatingCharacterTests
    {
        public static IEnumerable<object[]> GetTests()
        {
            yield return new object[] { 1, null, null, null};
            yield return new object[] { 2, new List<char> { 'A' }, 'A', 0 };
            yield return new object[] { 3, new List<char> { 'A', 'B' }, 'A', 0 };
            yield return new object[] { 4, new List<char> { 'A', 'A', 'A' }, null, null };
            yield return new object[] { 5, new List<char> { 'A', 'B', 'C', 'D', 'C', 'B', 'A', 'F', 'A', 'F' }, 'D', 3 };
            yield return new object[] { 6, new List<char> { 'A', 'B', 'C', 'D', 'C', 'B', 'A', 'F', 'D', 'J', 'F' }, 'J', 9 };
        }

        [TestCaseSource(nameof(GetTests))]
        [Test]
        public void RunTests(int testId, List<char> chars, char? expectedChar, int? expectedPosition)
        {
            var finder = new FirstNonRepeatingCharacterFinder(chars);

            var result = finder.GetFirstNonRepeatingCharacter();

            Assert.That(result.Character, Is.EqualTo(expectedChar));
            Assert.That(result.Position, Is.EqualTo(expectedPosition));
        }
    }
}
