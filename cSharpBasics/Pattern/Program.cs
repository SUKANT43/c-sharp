using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("tm: ");
            int tm = int.Parse(Console.ReadLine());
            List<List<string>> list = new List<List<string>>();
            //up
            for(int i = 0; i < n; i++)
            {
                List<string> dummyList = new List<string>();
                for(int j = 0; j < n - i-1 ; j++)
                {
                    dummyList.Add(" ");
                }
                for(int k = 0; k <= i; k++)
                {
                    dummyList.Add("*");
                }
                list.Add(dummyList);
            }

            //down
            for (int i = n-2; i>=0 ; i--)
            {
                List<string> dummyList = new List<string>();
                for (int j = 0; j < n - i - 1; j++)
                {
                    dummyList.Add(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    dummyList.Add("*");
                }
                list.Add(dummyList);
            }

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Count; j++)
                {
                    Console.Write(list[i][j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}