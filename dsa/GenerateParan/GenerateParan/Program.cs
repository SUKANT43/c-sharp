using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateParan
{
    class Program
    {
        public static void Generate(int n, List<string>list,string ans,int open,int close)
        {

            if (ans.Length == n * 2)
            {
                list.Add(ans);
                return;
            }

            if (open < n)
            {
                Generate(n, list, ans+'(', open + 1, close);
            }

            if (close < open)
            {
                Generate(n, list, ans + ')', open, close + 1);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of parentheses");
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            int open = 0;
            int close = 0;
            Generate( n,list,"",open,close);
            foreach(string ls in list)
            {
                Console.WriteLine(ls);
            }
            Console.ReadLine();
        }
    }
}
