using System;
using System.Collections.Generic;

namespace CodingChallenges_CSharp.NumberToWordsConverter
{
    public class NumberSpliterService : INumberSpliterService
    {
        public IEnumerable<SplitNumberPart> SplitNumberIntoScaleParts(long number)
        {
            var splitNumberParts = new List<SplitNumberPart>();
            var scaleNumber = 1;

            while (number > 0)
            {
                var value = number%1000;

                splitNumberParts.Add(new SplitNumberPart(value, GetScaleName(scaleNumber), scaleNumber));

                number = number/1000;
                scaleNumber++;
            }

            return splitNumberParts;
        }

        private string GetScaleName(int scaleNumber)
        {
            string scaleName;

            switch (scaleNumber)
            {
                case 1:
                    scaleName = "hundred";
                break;
                case 2:
                    scaleName = "thousand";
                    break;
                case 3:
                    scaleName = "million";
                    break;
                case 4:
                    scaleName = "billion";
                    break;
                case 5:
                    scaleName = "trillion";
                    break;
                default:
                    throw new Exception("Unable to get scale name.");
            }

            return scaleName;
        }
    }
}