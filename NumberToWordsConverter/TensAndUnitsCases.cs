using System.Collections.Generic;

namespace CodingChallenges_CSharp.NumberToWordsConverter
{
    public static class TensAndUnitsCases
    {
        public static IEnumerable<TensAndUnitCase> GetTensAndUnitCases()
        {
            return new List<TensAndUnitCase>
            {
                new TensAndUnitCase(0, 1, "one"),
                new TensAndUnitCase(0, 2, "two"),
                new TensAndUnitCase(0, 3, "three"),
                new TensAndUnitCase(0, 4, "four"),
                new TensAndUnitCase(0, 5, "five"),
                new TensAndUnitCase(0, 6, "six"),
                new TensAndUnitCase(0, 7, "seven"),
                new TensAndUnitCase(0, 8, "eight"),
                new TensAndUnitCase(0, 9, "nine"),
                new TensAndUnitCase(1, 0, "ten"),
                new TensAndUnitCase(1, 1, "eleven"),
                new TensAndUnitCase(1, 2, "tweleve"),
                new TensAndUnitCase(1, 3, "thirteen"),
                new TensAndUnitCase(1, 4, "fourteen"),
                new TensAndUnitCase(1, 5, "fifteen"),
                new TensAndUnitCase(1, 6, "sixteen"),
                new TensAndUnitCase(1, 7, "seventeen"),
                new TensAndUnitCase(1, 8, "eighteen"),
                new TensAndUnitCase(1, 9, "nineteen"),
                new TensAndUnitCase(2, 0, "twenty"),
                new TensAndUnitCase(3, 0, "thirty"),
                new TensAndUnitCase(4, 0, "forty"),
                new TensAndUnitCase(5, 0, "fifty"),
                new TensAndUnitCase(6, 0, "sixty"),
                new TensAndUnitCase(7, 0, "seventy"),
                new TensAndUnitCase(8, 0, "eighty"),
                new TensAndUnitCase(9, 0, "ninety")
            };
        }
    }
}