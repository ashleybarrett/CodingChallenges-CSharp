using System;
using codingChallenges_CSharp.BallSwitchBoard;

namespace CodingChallenges_CSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[][] x = new int[1][];
            x[0] = new int[1];

            x[0][0] = -1;    
            new BallSwitchBoardTests().RunTests(0, x, 42, 21);
        }
    }
}
