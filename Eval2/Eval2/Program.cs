using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval2
{
    /*class Program
    {
       public static bool CheckString(string s1, string s2)
        {

            if (s1 == s2)
            {
                return true;
            }
            int n = s1.Length;
            for(int i = 1; i < n; i++)
            {
                //if (CheckString(s1.Substring(0, i),s2.Substring(0,i)) && CheckString(s1.Substring(i), s2.Substring(i)))
                if (CheckString(s1.Substring(0, i), s2.Substring(0, i)) && CheckString(s1.Substring(i), s2.Substring(i)))
                {
                    return true;
                }
               if(CheckString(s1.Substring(0,i),s2.Substring(n-i)) && CheckString(s1.Substring(i), s2.Substring(0, n - i)))
                {
                    CheckString(s1.Substring(i), s2.Substring(0,n-i));
                    return true;
                }

            }
            return false;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String 1");
           string a = Console.ReadLine();
            string b = Console.ReadLine();
            Console.WriteLine(CheckString(a, b));
            Console.ReadLine();
        }
    }*/

    public class Program{
        public static int NumberOfIsland(char[][] grid)
        {
            int count = 0;
            int row = grid.Length;
            int col = grid[0].Length;
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    if (grid[i][j] =='0')
                    {
                        Dfs(grid, row, col);
                        count++;
                    }
                }
            }
            return count;
        }

        public static void Dfs(char[][] grid, int i, int j)
        {
            if (i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length || grid[i][j] == '0') return;
            grid[i][j] = '0';
            Dfs(grid, i + 1, j);
            Dfs(grid, i - 1, j);
            Dfs(grid, i, j + 1);
            Dfs(grid, i, j - 1);
        }



        public static void Main()
        {

        }
    }

}
