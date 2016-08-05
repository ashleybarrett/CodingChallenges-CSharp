using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenges_CSharp.PositiveIntegerToRomanNumerals
{
    public class PositiveIntegerToRomanNumerals : IPositiveIntegerToRomanNumerals
    {
        private readonly UnitRange _unitsUnitRange = new UnitRange("I", "V", "X");
        private readonly UnitRange _tensUnitRange = new UnitRange("X", "L", "C");
        private readonly UnitRange _hundredsUnitRange = new UnitRange("C", "D", "M");
        private const string ThousandsSymbol = "M";

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
                var total = integer;

                var numberOfThousands = total / 1000;
                total -= 1000*numberOfThousands;

                var numberOfHundreds = total / 100;
                total -= 100 * numberOfHundreds;

                var numberOfTens = total / 10;
  
                var numberOfUnits = integer % 10;

                parts.Add(GetThousandsPart(numberOfThousands));
                parts.Add(GetPart(numberOfHundreds, _hundredsUnitRange));
                parts.Add(GetPart(numberOfTens, _tensUnitRange));
                parts.Add(GetPart(numberOfUnits, _unitsUnitRange));
            }

            return Join(parts.Where(x => !string.IsNullOrWhiteSpace(x)));
        }

        private string Join(IEnumerable<string> toJoin)
        {
            return string.Join("", toJoin);
        }

        private string GetThousandsPart(int integer)
        {
            return Join(Enumerable.Repeat(ThousandsSymbol, integer));
        }

        private string GetPart(int integer, UnitRange unitRange)
        {
            string part;

            switch (integer)
            {
                case 4:
                    part = string.Concat(unitRange.Lower, unitRange.Middle);
                    break;
                case 5:
                    part = unitRange.Middle;
                    break;
                case 6:
                case 7:
                case 8:
                    var timesToRepeat = integer - 5;
                    var repeated = Join(Enumerable.Repeat(unitRange.Lower, timesToRepeat));
                    part = string.Concat(unitRange.Middle, repeated);
                    break;
                case 9:
                    part = string.Concat(unitRange.Lower, unitRange.Upper);
                    break;
                default:
                    part = Join(Enumerable.Repeat(unitRange.Lower, integer));
                    break;
            }

            return part;
        }
    }
}
