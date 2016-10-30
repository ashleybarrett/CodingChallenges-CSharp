using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace CodingChallenges_CSharp.PositiveIntegerToRomanNumerals
{
    public class PositiveIntegerToRomanNumeralsTests
    {
        private readonly IPositiveIntegerToRomanNumerals _sut = new PositiveIntegerToRomanNumeralsSecondAttempt();

        public static IEnumerable<object[]> GetTests()
        {
            return TestCaseSource.GetTests();
        }

        [Test, TestCaseSource("GetTests")]
        public void RunTests(int testId, int integer, string expectedRomanNumerial)
        {
            var actualRomanNumerial = _sut.Convert(integer);
            Assert.That(actualRomanNumerial, Is.EqualTo(expectedRomanNumerial));
        }

        [Test]
        public void NumberMustBeGreaterThanZero()
        {
            Assert.Throws<Exception>(() => _sut.Convert(-1));
        }

        [Test]
        public void NumberMustBeLessThan5000()
        {
            Assert.Throws<Exception>(() => _sut.Convert(5000));
        }
    }
}