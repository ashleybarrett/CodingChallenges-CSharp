using System.Collections.Generic;
using NUnit.Framework;

namespace CodingChallenges_CSharp.NumberToWordsConverter
{
    public class NumberToWordsConverterTests
    {
        public static IEnumerable<object[]> GetNumberToWordsConverterTests()
        {
            return NumberToWordsConverterTestsSource.GetNumberToWordsConverterTests();
        }

        [Test]
        [TestCaseSource(nameof(GetNumberToWordsConverterTests))]
        public void RunNumberToWordsConverterTests(int testId, long number, string expected)
        {
            //arr
            var service = GetConverterService();

            //act
            var actual = service.ConvertNumberToWords(number);

            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        private INumberToWordsConverterService GetConverterService()
        {
            return new NumberToWordsConverterService(new NumberSpliterService());    
        }
    }
}
