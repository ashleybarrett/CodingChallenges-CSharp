namespace CodingChallenges_CSharp.NumberToWordsConverter
{
    public class TensAndUnitCase
    {
        public int NumbersOfTens { get; set; }
        public int NumberOfUnits { get; set; }
        public string Word { get; set; }

        public TensAndUnitCase(int numberOfTens, int numberOfUnits, string word)
        {
            NumbersOfTens = numberOfTens;
            NumberOfUnits = numberOfUnits;
            Word = word;
        }
    }
}