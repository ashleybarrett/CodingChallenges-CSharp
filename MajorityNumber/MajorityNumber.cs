using System.Collections.Generic;
using System.Linq;

//My attempt to solve this problem: http://www.blackrabbitcoder.net/archive/2015/07/07/little-puzzlersndashthe-majority-element.aspx
namespace CodingChallenges_CSharp.MajorityNumber
{
    public class MajorityNumber
    {
        public int? GetMajorityNumber(IEnumerable<int> numbers)
        {
            int? majorityNumber = null;

            if (numbers != null && numbers.Any())
            {
                var numberOfNumbers = numbers.Count();
                var groupedNumbers = numbers.GroupBy(x => x);
                var largestGroup = groupedNumbers.OrderByDescending(x => x.Count()).First();

                if (IsMajority(largestGroup.Count(), numberOfNumbers))
                {
                    majorityNumber = largestGroup.Key;
                }
            }

            return majorityNumber;
        }

        private bool IsMajority(int largestGroupCount, int numberOfNumbers)
        {
            return largestGroupCount > (numberOfNumbers/2);
        }
    }
}
