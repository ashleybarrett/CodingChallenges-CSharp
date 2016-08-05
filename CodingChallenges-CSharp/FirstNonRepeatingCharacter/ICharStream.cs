namespace CodingChallenges_CSharp.FirstNonRepeatingCharacter
{
    public interface ICharStream
    {
        bool HasNext { get; }
        char GetNext();
    }
}
