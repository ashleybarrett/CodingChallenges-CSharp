//My attempt to solve this problem: https://codility.com/programmers/task/ball_switch_board/
namespace codingChallenges_CSharp.BallSwitchBoard
{
    public class BallSwitchBoard
    {
        public int solution(int[][] A, int K)
        {
            var result = 0;
            
            if (A.Length > 0 && K > 0)
            {
                int rows = A.Length, columns = A[0].Length;

                for (int i = 0; i < K; i++)
                {
                    //Balls always start at 0,0
                    if (DoesLeaveByBottomRight(ref A, 0, 0, true))
                    {
                        result++;
                    }
                }
            }

            return result;
        }

        private bool DoesLeaveByBottomRight(ref int[][] array, int row, int column, bool enteredFromTop)
        {
            var doesLeaveByBottomRight = false;

            const int directionTop = -1, directionRight = 1;

            var current = array[row][column];

            //Leave via the bottom edge    
            if ((current == 0 && enteredFromTop) || current == directionTop)
            {
                if (row == (array.Length - 1))
                {
                    if (column == (array[0].Length - 1))
                    {
                        doesLeaveByBottomRight = true;
                    }
                }
                else
                {
                    if(current != 0)
                    {
                        array[row][column] = directionRight;
                    }

                    doesLeaveByBottomRight = DoesLeaveByBottomRight(ref array, row + 1, column, true);
                }
            }
            //Leave via the right edge
            else
            {
                if (column != (array[0].Length - 1))
                {
                    if(current != 0)
                    {
                        array[row][column] = directionTop;
                    }

                    doesLeaveByBottomRight = DoesLeaveByBottomRight(ref array, row, column + 1, false);
                }
            }

            return doesLeaveByBottomRight;
        }
    }
}