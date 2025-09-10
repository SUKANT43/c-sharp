using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueen
{
    class Program
    {
        public static List<List<string>>SolveNQueens(int n)
        {
            var result = new List<List<string>>();
            char[][] board = new char[n][];
            for(int i = 0; i < n; i++)
            {
                board[i] = new char[n];
                for(int j = 0; j < n; j++)
                {
                    board[i][j] = '.';
                }
            }

            Solve(board, 0, result);
            return result;
        }

        public static void Solve(char[][]board,int row, List<List<string>> result)
        {
            int n = board.Length;
            if (row == n)
            {
                var sol = new List<string>();
                for(int i = 0; i < n; i++)
                {
                    sol.Add(new string(board[i]));
                }
                result.Add(sol);
                return;
            }
            for(int col = 0; col < n; col++)
            {
                if (IsSafe(board, row, col))
                {
                    board[row][col] = 'Q';
                    Solve(board, row + 1, result);
                    board[row][col] = '.';
                }
            }

        }

        public static bool IsSafe(char[][]board,int row,int col)
        {
            int n = board.Length;
            for(int i = 0; i < row; i++)
            {
                if (board[i][col]=='Q')
                {
                    return false;
                }
            }

            for(int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i][j] == 'Q')
                {
                    return false;
                }
            }

            for(int i = row - 1, j = col + 1; i >= 0 && j < n; i--, j++)
            {
                if (board[i][j] == 'Q')
                {
                    return false;
                }
            }

            return true;
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter the value of n (size of board): ");
            int n = int.Parse(Console.ReadLine());
            var res = SolveNQueens(n);
            int count = 1;
            foreach(var solutions in res)
            {
                Console.WriteLine($"Solution {count++}:");
                foreach (var row in solutions)
                {
                    Console.WriteLine(row);
                }
                Console.WriteLine("\n\n");
            }

            Console.ReadLine();
        }
    }
}