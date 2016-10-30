namespace CodingChallenges_CSharp.NumberToWordsConverter
{
    public class SplitNumberPart
    {
        public long Number { get; }
        public string Scale { get; }
        public int Sequence { get; }

        public SplitNumberPart(long number, string scale, int sequence)
        {
            Number = number;
            Scale = scale;
            Sequence = sequence;
        }
    }
}