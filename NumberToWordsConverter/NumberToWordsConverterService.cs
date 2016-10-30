using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenges_CSharp.NumberToWordsConverter
{
    public class NumberToWordsConverterService : INumberToWordsConverterService
    {
        private readonly INumberSpliterService _numberSpliterService;

        private readonly IEnumerable<TensAndUnitCase> _tensSpecialCases = TensAndUnitsCases.GetTensAndUnitCases();

        public NumberToWordsConverterService(INumberSpliterService numberSpliterService)
        {
            _numberSpliterService = numberSpliterService;
        }

        public string ConvertNumberToWords(long number)
        {
            var wordsList = new List<string>();

            try
            {
                if (number == 0)
                {
                    return "zero";
                }

                if (number < 0)
                {
                    wordsList.Add("negative ");
                }

                var numberParts = SplitNumberIntoScaleParts(Math.Abs(number));
                var totalNumberOfNumberParts = numberParts.Count();
                var wordsForParts = numberParts.OrderByDescending(x => x.Sequence).Select(x => GenerateWordsFromPart(x, totalNumberOfNumberParts));
                wordsList.AddRange(wordsForParts);
            }
            catch (Exception)
            {
                //I'd log orginal exception here, if it was 'real' app...
                throw new Exception(string.Format("Unable to discover word form for number <{0}>. Check to see if the scale is catered for.", number));
            }

            return Join(wordsList, string.Empty);
        }

        private string Join(IEnumerable<string> words, string seporator)
        {
            return string.Join(seporator, words.Where(x => !string.IsNullOrWhiteSpace(x)));
        }

        private IEnumerable<SplitNumberPart> SplitNumberIntoScaleParts(long number)
        {
            return _numberSpliterService.SplitNumberIntoScaleParts(number);
        }

        private string GenerateWordsFromPart(SplitNumberPart splitNumberPart, int totalNumberOfParts)
        {
            if (splitNumberPart.Number == 0)
            {
                return string.Empty;
            }

            var number = splitNumberPart.Number;
            var numberOfHundreds = (int)number / 100;
            var numberOfTens = (int)(number - (numberOfHundreds * 100)) / 10;
            var numberOfUnits = (int)number % 10;
            var tensAndUnits = (numberOfTens * 10) + numberOfUnits;

            var wordList = new List<string>
            {
                GetPartPrefixWord(splitNumberPart.Sequence, totalNumberOfParts, numberOfHundreds, tensAndUnits),
                GetHundredsWord(numberOfHundreds),
                GetHundredsWordSuffix(numberOfHundreds, tensAndUnits)
            };
            wordList.AddRange(GetTensAndUnitsWords(numberOfTens, numberOfUnits, tensAndUnits));
            wordList.Add(GetPartSuffixWord(splitNumberPart.Sequence, splitNumberPart.Scale));

            return Join(wordList, " ");
        }

        private string GetPartPrefixWord(int partNumber, int totalParts, int numberOfHundreds, int tensAndUnits)
        {
            var word = string.Empty;

            //The first part doesn't require a prefix.
            if (partNumber != totalParts)
            {
                word = ",";
            
                //The last part (hundreds) has ',' unless there isn't any hundreds but are tens and unitsn (one million and one). In this case use 'and'.
                if (partNumber == 1 && !IsGreaterThanZero(numberOfHundreds) && IsGreaterThanZero(tensAndUnits))
                {
                    word = " and";
                }
            }

            return word;
        }

        private string GetPartSuffixWord(int partNumber, string suffix)
        {
            //Part number of 1 will be the last part (hundreds). No suffix required.
            return partNumber != 1 ? suffix : string.Empty;
        }

        private string GetHundredsWord(int numberOfHundreds)
        {
            return IsGreaterThanZero(numberOfHundreds) ? CreateUnitWordWithSuffix(numberOfHundreds, " hundred") : string.Empty;
        }

        private string GetHundredsWordSuffix(int numberOfHundreds, int tensAndUnits)
        {
            return IsGreaterThanZero(numberOfHundreds) && IsGreaterThanZero(tensAndUnits) ? "and" : string.Empty;
        }

        public IEnumerable<string> GetTensAndUnitsWords(int numberOfTens, int numberOfUnits, int tensAndUnits)
        {
            var calulateUnits = true;
            var wordList = new List<string>();

            if (IsGreaterThanZero(numberOfTens))
            {
                string tensWord;

                //If there is an exact match for both tens and units (for example 11 or 19) then calculating the units isn't required.
                var matchOnTensAndUnits = GetExactMatchFromTensAndUnits(numberOfTens, numberOfUnits);

                if (matchOnTensAndUnits != null)
                {
                    tensWord = matchOnTensAndUnits.Word;
                    calulateUnits = false;
                }
                else
                {
                    //There will always be a match on tens only. If the units are > 0 then work those out too.
                    tensWord = GetMatchFromTensOnly(numberOfTens).Word;
                }

                wordList.Add(tensWord);
            }

            if (calulateUnits && IsGreaterThanZero(numberOfUnits))
            {
                wordList.Add(CreateUnitWordWithSuffix(numberOfUnits, string.Empty));
            }

            return wordList;
        }

        private bool IsGreaterThanZero(int number)
        {
            return number > 0;
        }

        private TensAndUnitCase GetExactMatchFromTensAndUnits(int numberOfTens, int numberOfUnits)
        {
            return _tensSpecialCases.FirstOrDefault(x => x.NumbersOfTens == numberOfTens && x.NumberOfUnits == numberOfUnits);
        }

        private TensAndUnitCase GetMatchFromTensOnly(int numberOfTens)
        {
            return _tensSpecialCases.First(x => x.NumbersOfTens == numberOfTens);
        }

        private TensAndUnitCase GetMatchFromUnitsOnly(int numberOfUnits)
        {
            return _tensSpecialCases.First(x => x.NumberOfUnits == numberOfUnits);
        }

        private string CreateUnitWordWithSuffix(int numberOfUnits, string suffix)
        {
            var match = GetMatchFromUnitsOnly(numberOfUnits);
            return string.Concat(match.Word, suffix);
        }
    }
}