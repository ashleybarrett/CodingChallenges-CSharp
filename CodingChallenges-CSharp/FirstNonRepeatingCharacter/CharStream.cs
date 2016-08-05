using System.Collections.Generic;

namespace CodingChallenges_CSharp.FirstNonRepeatingCharacter
{
    public class CharStream : ICharStream
    {
        private readonly List<char> _chars;
        private int _position;
        private readonly int _length;

        public CharStream(List<char> chars)
        {
            _chars = chars;
            _position = 0;
            _length = (_chars ?? new List<char>()).Count;
        }

        public bool HasNext => _position + 1 <= _length;

        public char GetNext()
        {
            var nextChar = _chars[_position];
            _position++;
            return nextChar;
        }
    }
}
