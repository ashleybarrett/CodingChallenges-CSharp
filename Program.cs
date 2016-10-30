using System;
using codingChallenges_CSharp.BallSwitchBoard;

namespace CodingChallenges_CSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[][] x = new int[2][];
            x[0] = new int[3];
            x[1] = new int[3];

            x[0][0] = -1;    
            x[0][1] =  0;   
            x[0][2] = -1;
            x[1][0] =  1;
            x[1][1] =  0;   
            x[1][2] =  0;
            new BallSwitchBoardTests().RunTests(0, x, 4, 1);
        }
    }
}
