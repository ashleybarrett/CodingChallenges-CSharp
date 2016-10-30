using System.Collections.Generic;
using System.Linq;

//My attempt to solve this problem: http://www.blackrabbitcoder.net/BlackRabbitCoder/archive/2015/03/09/little-puzzlers-first-non-repeating-character.aspxMy attempt to solve this problem: http://www.blackrabbitcoder.net/BlackRabbitCoder/archive/2015/03/09/little-puzzlers-first-non-repeating-character.aspx
namespace CodingChallenges_CSharp.FirstNonRepeatingCharacter
{
    public class FirstNonRepeatingCharacterFinder
    {
        private readonly ICharStream _charStream;

        public FirstNonRepeatingCharacterFinder(List<char> chars)
        {
            _charStream = new CharStream(chars);
        }

        public FirstNonRepeating GetFirstNonRepeatingCharacter()
        {
            var firstNonRepeating = new FirstNonRepeating();

            var nonRepeating = new Dictionary<char, int>();
            var repeating = new List<char>();
            var position = 0;
            
            while (_charStream.HasNext)
            {
                var next = _charStream.GetNext();

                if (nonRepeating.ContainsKey(next) || repeating.Contains(next))
                {
                    nonRepeating.Remove(next);
                    repeating.Add(next);
                }
                else
                {
                    nonRepeating.Add(next, position);
                }

                position++;
            }

            if (nonRepeating.Any())
            {
                var first = nonRepeating.OrderBy(x => x.Value).First();
                firstNonRepeating.Character = first.Key;
                firstNonRepeating.Position = first.Value;
            }

            return firstNonRepeating;
        }
    }
}
