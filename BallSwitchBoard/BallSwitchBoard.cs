//My attempt to solve this problem: Zeta 2011 -https://codility.com/programmers/task/ball_switch_board/
namespace codingChallenges_CSharp.BallSwitchBoard
{
    public class BallSwitchBoard
    {
        public int solution(int[][] A, int K)
        {
            var result = 0;
    
            if (A.Length > 0 && K > 0)
            {
                int totalRows = A.Length, totalColumns = A[0].Length;
                int[,] ballsLeavingBottom = new int[totalRows, totalColumns], ballsLeavingRight = new int[totalRows, totalColumns];
                
                for (int row = 0; row < totalRows; row++)
                {
                    for (int column = 0; column < totalColumns; column++)
                    {
                        int enteringFromTop = 0, enteringFromLeft = 0;

                        if (row == 0 && column == 0)
                        {
                            enteringFromTop = K;
                        }

                        if (row > 0)
                        {
                            enteringFromTop = ballsLeavingBottom[row - 1, column];
                        }

                        if (column > 0)
                        {
                            enteringFromLeft = ballsLeavingRight[row, column - 1];
                        }

                        var value = A[row][column];

                        if (value == 0)
                        {
                            ballsLeavingBottom[row, column] = enteringFromTop;
                            ballsLeavingRight[row, column] = enteringFromLeft;
                        }
                        else
                        {
                            var total = (enteringFromLeft + enteringFromTop);
                            var remainder = total % 2;
                            ballsLeavingBottom[row, column] = (total / 2) + (value == -1 ? remainder : 0);
                            ballsLeavingRight[row, column] = (total / 2)  + (value == 1 ? remainder : 0);
                        }
                    }
                }

                result = ballsLeavingBottom[totalRows - 1, totalColumns - 1];
            }

            return result;
        }
    }
}