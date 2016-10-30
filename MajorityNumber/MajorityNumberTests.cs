using System.Collections.Generic;
using NUnit.Framework;

namespace CodingChallenges_CSharp.MajorityNumber
{
    [TestFixture]
    public class MajorityNumberTests
    {
        [Test, TestCaseSource("GetMajorityNumberTests")]
        public void RunMajorityNumberTests(int testId, IEnumerable<int> numbers, int? majorityNumberExpected)
        {
            //arr
            var mn = new MajorityNumber();

            //act
            var majorityNumber = mn.GetMajorityNumber(numbers);

            //assert
            Assert.That(majorityNumber, Is.EqualTo(majorityNumberExpected));
        }

        private static IEnumerable<object[]> GetMajorityNumberTests()
        {
            return MajorityNumberTestsSource.GetMajorityNumberTests();
        }
    }
}
