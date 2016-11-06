using System;
using codingChallenges_CSharp.BallSwitchBoard;

namespace CodingChallenges_CSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var tests = BallSwitchBoardTests.GetTests();
            var sut = new BallSwitchBoardTests();
            foreach (var test in tests)
            {
                if ((int)test[0] == 6)
                {
                    sut.RunTests((int)test[0], (int[][])test[1], (int)test[2], (int)test[3]);       
                } 
            }
        }
    }
}
