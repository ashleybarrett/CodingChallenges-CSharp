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
                int maxRows = A.Length - 1, maxColumns = A[0].Length - 1;

                for (int i = 0; i < K; i++)
                {
                    //Balls always start at 0,0
                    if (DoesLeaveByBottomRight(ref A, 0, 0, maxRows, maxColumns, true))
                    {
                        result++;
                    }
                }
            }

            return result;
        }

        private bool DoesLeaveByBottomRight(ref int[][] array, int row, int column, int maxRows, int maxColumns, bool enteredFromTop)
        {
            var doesLeaveByBottomRight = false;

            var current = array[row][column];
            var nextEntryFromTop = (current == 0 && enteredFromTop) || current == -1;
            var nextRow = nextEntryFromTop ? row + 1 : row;
            var nextColumn = nextEntryFromTop ? column : column + 1;

            array[row][column] = array[row][column] * -1;

            if ((row) == maxRows && (column) == maxColumns && nextEntryFromTop)
            {
                doesLeaveByBottomRight = true;
            }
            else if (nextRow <= maxRows && nextColumn <= maxColumns)
            {
                doesLeaveByBottomRight = DoesLeaveByBottomRight(ref array, nextRow, nextColumn, maxRows, maxColumns, nextEntryFromTop);
            }

            return doesLeaveByBottomRight;
        }
    }
}