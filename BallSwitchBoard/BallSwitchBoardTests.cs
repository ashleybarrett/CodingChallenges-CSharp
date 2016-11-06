using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace codingChallenges_CSharp.BallSwitchBoard
{
    public class BallSwitchBoardTests
    {
        public static IEnumerable<object[]> GetTests()
        {    
            yield return new object[] 
            {
                1,  
                SetUpArray(
                    0, 0,
                    (x) => 
                    {
                        return x;
                    }
                ),
                4, 
                0
            };

            yield return new object[] 
            {
                2,  
                SetUpArray(
                    2, 3,
                    (x) => 
                    {
                        x[0][0] = -1;    
                        x[0][1] =  0;   
                        x[0][2] = -1;
                        x[1][0] =  1;
                        x[1][1] =  0;   
                        x[1][2] =  0;
                        return x;
                    }
                ),
                0, 
                0
            }; 

            yield return new object[] 
            {
                3,  
                SetUpArray(
                    2, 3,
                    (x) => 
                    {
                        x[0][0] = -1;    
                        x[0][1] =  0;   
                        x[0][2] = -1;
                        x[1][0] =  1;
                        x[1][1] =  0;   
                        x[1][2] =  0;
                        return x;
                    }
                ),
                4, 
                1
            };   

            yield return new object[] 
            {
                4,  
                SetUpArray(
                    1, 1,
                    (x) => 
                    {
                        x[0][0] = -1;    
                        return x;
                    }
                ),
                42, 
                21
            }; 

            yield return new object[] 
            {
                5,  
                SetUpArray(
                    1, 1,
                    (x) => 
                    {
                        x[0][0] = -1;    
                        return x;
                    }
                ),
                41, 
                21
            };  

            yield return new object[] 
            {
                6,  
                SetUpArray(
                    1, 1,
                    (x) => 
                    {
                        x[0][0] = 1;    
                        return x;
                    }
                ),
                41, 
                20
            };   
        }

        private static int[][] SetUpArray(int rows, int columns, Func<int[][], int[][]> func)
        {
            int[][] array = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
               array[i] = new int[columns];
            }

            return func(array);
        }

        [Test, TestCaseSource(nameof(GetTests))]
        public void RunTests(int testId, int[][] array, int numberOfBalls, int expected)
        {
            var sut = new BallSwitchBoard();
            var actual = sut.solution(array, numberOfBalls);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}