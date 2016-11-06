using System;
using System.Collections.Generic;
using System.Linq;

//My attempt to solve this problem: http://www.blackrabbitcoder.net/archive/2015/05/05/little-puzzlersndashpositive-integer-to-roman-numerals.aspx
namespace CodingChallenges_CSharp.PositiveIntegerToRomanNumerals
{
    public class PositiveIntegerToRomanNumeralsSecondAttempt : IPositiveIntegerToRomanNumerals
    {
        private readonly Dictionary<int, string> _cases = new Dictionary<int, string>();

        public PositiveIntegerToRomanNumeralsSecondAttempt()
        {
            _cases.Add(1000, "M");
            _cases.Add(900, "CM");
            _cases.Add(500, "D");
            _cases.Add(400, "CD");
            _cases.Add(100, "C");
            _cases.Add(90, "XC");
            _cases.Add(50, "L");
            _cases.Add(40, "XL");
            _cases.Add(10, "X");
            _cases.Add(9, "IX");
            _cases.Add(5, "V");
            _cases.Add(4, "IV");
            _cases.Add(1, "I");
        }

        public string Convert(int integer)
        {
            var parts = new List<string>();

            if (integer < 0 || integer > 4999)
            {
                throw new Exception("Number to convert must be greater than zero and less than five thousand.");
            }

            if (integer == 0)
            {
                parts.Add("nulla");
            }
            else
            {
                while (integer > 0)
                {
                    var part = _cases.Where(x => x.Key <= integer).OrderByDescending(x => x.Key).First();
                    integer -= part.Key;
                    parts.Add(part.Value);
                }
            }

            return string.Join("", parts.Where(x => !string.IsNullOrWhiteSpace(x)));
        }
    }
}
