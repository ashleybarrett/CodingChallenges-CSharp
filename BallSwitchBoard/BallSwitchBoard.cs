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
                    if (DoesLeaveByBottomRight(ref A, 0, 0, BallSwitchBoardEntryType.Top))
                    {
                        result++;
                    }
                }
            }

            return result;
        }

        private bool DoesLeaveByBottomRight(ref int[][] array, int row, int column, BallSwitchBoardEntryType enteredFrom)
        {
            var doesLeaveByBottomRight = false;

            var current = array[row][column]; 

            //Leave via the bottom edge    
            if ((current == 0 && enteredFrom == BallSwitchBoardEntryType.Top) || current == (int)BallSwitchBoardEntryType.Top)
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
                    current = (int)BallSwitchBoardEntryType.Right;
                    doesLeaveByBottomRight = DoesLeaveByBottomRight(ref array, row++, column, BallSwitchBoardEntryType.Top);
                }
            }
            //Leave via the right edge
            else
            {
                if (column != (array[0].Length - 1))
                {
                    current = (int)BallSwitchBoardEntryType.Top;
                    doesLeaveByBottomRight = DoesLeaveByBottomRight(ref array, row, column++, BallSwitchBoardEntryType.Right);
                }
            }

            return doesLeaveByBottomRight;
        }
    }
}