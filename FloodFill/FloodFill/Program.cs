using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloodFill
{
    class Program
    {
        public static void FloodFill(int[][] arr,int row,int col,int num)
        {
            Console.WriteLine(arr[row][col]);

            BFS(arr,arr[row][col], row, col, num);
        }

        public static void BFS(int[][]arr,int targetValue,int row,int col,int num)
        {
                    if ((row >= 0 && col >= 0 && row < arr.Length && col < arr[row].Length) && (arr[row][col] == targetValue))
                    {

                        arr[row][col] = num;
                    }
                    else
                    {
                        return;
                    }
                    BFS(arr, targetValue, row, col - 1, num);
                    BFS(arr, targetValue, row, col + 1, num);
                    BFS(arr,targetValue,row-1,col,num);
                    BFS(arr, targetValue, row + 1, col, num);
                    BFS(arr, targetValue, row + 1, col+1, num);
                    BFS(arr, targetValue, row -1, col-1, num);
                    BFS(arr, targetValue, row + 1, col-1, num);
                    BFS(arr, targetValue, row -1, col+1, num);
        }
        
        static void Main(string[] args)
        {
            int[][] arr1 =
            {
                new int[]{0,0,0,2},
                new int[]{0,1,2,1},
                new int[]{1,2,1,0},
                new int[]{2,1,0,1},
                new int[]{1,2,1,2}
            };
            int row = 0;
            int col = 3;
            int num = 7;

            FloodFill(arr1, row, col, num);
            for(int i = 0; i < arr1.Length; i++)
            {
                for(int j = 0; j < arr1[i].Length; j++)
                {
                    Console.Write(arr1[i][j]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}


/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloodFill
{
    class Program
    {
        public static void FloodFill(int[][] arr, int row, int col, int num)
        {
            Console.WriteLine(arr[row][col]);

            BFS(arr, arr[row][col], row, col, num);
        }

        public static void BFS(int[][] arr, int targetValue, int row, int col, int num)
        {
            for (int i = row; i < arr.Length; i++)
            {
                for (int j = col; j < arr.Length; j++)
                {

                    if ((i >= 0 && j >= 0 && i < arr.Length && j < arr[i].Length) && (arr[i][j] == targetValue))
                    {

                        arr[i][j] = num;
                    }
                    else
                    {
                        return;
                    }


                    BFS(arr, targetValue, row, col - 1, num);
                    BFS(arr, targetValue, row, col + 1, num);

                    BFS(arr, targetValue, row - 1, col, num);
                    BFS(arr, targetValue, row + 1, col, num);

                    BFS(arr, targetValue, row + 1, col + 1, num);
                    BFS(arr, targetValue, row - 1, col - 1, num);
                    BFS(arr, targetValue, row + 1, col - 1, num);
                    BFS(arr, targetValue, row - 1, col + 1, num);

                }
            }
        }

        static void Main(string[] args)
        {
            int[][] arr1 =
            {
                new int[]{0,0,1,2},
                new int[]{0,1,0,1},
                new int[]{1,0,1,0},
                new int[]{0,1,0,1},
                new int[]{1,0,1,2}
            };
            int row = 0;
            int col = 2;
            int num = 3;

            FloodFill(arr1, row, col, num);
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr1[i].Length; j++)
                {
                    Console.Write(arr1[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}*/