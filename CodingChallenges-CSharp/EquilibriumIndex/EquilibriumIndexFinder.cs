using System.Collections.Generic;
using System.Linq;

namespace CodingChallenges_CSharp.EquilibriumIndex
{
    public class EquilibriumIndexFinder
    {
        public static IEnumerable<int> Find(int[] inputSequence)
        {
            var defaultResult = new List<int> { -1 };
            var result = new List<int>();

            if (inputSequence != null && inputSequence.Length > 0)
            {
                var sumLeft = 0;
                var sum = inputSequence.Sum();

                for (int i = 0; i < inputSequence.Length; i++)
                {
                    var item = inputSequence[i];
                    var sumRight = sum - (item + sumLeft);

                    if (sumLeft == sumRight)
                    {
                        result.Add(i);
                    }

                    sumLeft += item;
                }
            }

            return result.Any() ? result : defaultResult;
        }
    }
}
