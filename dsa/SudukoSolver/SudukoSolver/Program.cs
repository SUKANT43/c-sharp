using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudukoSolver
{
    class Program
    {
        public static void Solve(int[][] sud)
        {
            FillTheValues(sud);
        }

        public static bool FillTheValues(int[][] sud)
        {
            for(int row = 0; row < 9; row++)
            {
                for(int col = 0; col < 9; col++)
                {
                    if (sud[row][col] == 0)
                    {
                        for(int num = 1; num <= 9; num++)
                        {
                            if (IsCorrect(sud,row,col,num))
                            {
                                sud[row][col] = num;
                                if (FillTheValues(sud))
                                {
                                    return true;
                                }
                                sud[row][col] = 0;
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool IsCorrect(int[][]sud,int row,int col,int num)
        {
            for(int i = 0; i < 9; i++)
            {
                if (sud[row][i] == num) return false;
                if (sud[i][col] == num) return false;


                int subRow = 3 * (row / 3) + i / 3;      
                int subCol = 3 * (col / 3) + i % 3;      
                if (sud[subRow][subCol] == num) return false; 
            }
            return true;
        }

        public static void Print(int [][]sud)
        {
            for (int i = 0; i < sud.Length; i++)
            {
                for (int j = 0; j < sud[i].Length; j++)
                {
                    Console.Write(sud[i][j] + ", ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
        }

        static void Main(string[] args)
        {
            int[][] sud1 = new int[9][]
            {
                new int[]{5,3,0,0,7,0,0,0,0},
                new int[]{6,0,0,1,9,5,0,0,0},
                new int[]{0,9,8,0,0,0,0,6,0},
                new int[]{8,0,0,0,6,0,0,0,3},
                new int[]{4,0,0,8,0,3,0,0,1},
                new int[]{7,0,0,0,2,0,0,0,6},
                new int[]{0,6,0,0,0,0,2,8,0},
                new int[]{0,0,0,4,1,9,0,0,5},
                new int[]{0,0,0,0,8,0,0,7,9}
            };
            int[][] sud2 = new int[9][]
            {
                new int[]{0,0,0,2,6,0,7,0,1},
                new int[]{6,8,0,0,7,0,0,9,0},
                new int[]{1,9,0,0,0,4,5,0,0},
                new int[]{8,2,0,1,0,0,0,4,0},
                new int[]{0,0,4,6,0,2,9,0,0},
                new int[]{0,5,0,0,0,3,0,2,8},
                new int[]{0,0,9,3,0,0,0,7,4},
                new int[]{0,4,0,0,5,0,0,3,6},
                new int[]{7,0,3,0,1,8,0,0,0}
            };
            Solve(sud1);
            Solve(sud2);
            Print(sud1);
            Print(sud2);
            Console.ReadLine();
        }
    }
}
