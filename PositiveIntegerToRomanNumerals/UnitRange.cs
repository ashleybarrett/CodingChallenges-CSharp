namespace CodingChallenges_CSharp.PositiveIntegerToRomanNumerals
{
    public class UnitRange
    {
        public readonly string Lower;
        public readonly string Middle;
        public readonly string Upper;

        public UnitRange(string lower, string middle, string upper)
        {
            Lower = lower;
            Middle = middle;
            Upper = upper;
        }
    }
}