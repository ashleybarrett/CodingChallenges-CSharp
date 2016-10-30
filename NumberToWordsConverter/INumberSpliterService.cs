using System.Collections.Generic;

namespace CodingChallenges_CSharp.NumberToWordsConverter
{
    public interface INumberSpliterService
    {
        IEnumerable<SplitNumberPart> SplitNumberIntoScaleParts(long number);
    }
}