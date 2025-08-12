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
            int n1 = 0;
            int n2 = 0;
            if (n % 2 != 0)
            {
                n1 = (n / 2) + 1;
                n2=n/2;
            }
            else
            {
                n1 = n / 2;
                n2=n/2;


            }
            //up
            for(int i = 0; i < n1; i++)
            {
                List<string> dummyList = new List<string>();
                for(int times = 0; times < tm; times++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        dummyList.Add(" ");
                    }
                    for (int k = 0; k <= i; k++)
                    {
                        dummyList.Add("* ");
                    }
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        dummyList.Add(" ");
                    }
                }
              
                list.Add(dummyList);
            }

            //down
            for (int i = n2-1; i>=0 ; i--)
            {
                List<string> dummyList = new List<string>();
                for (int times = 0; times < tm; times++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        dummyList.Add(" ");
                    }
                    for (int k = 0; k <= i; k++)
                    {
                        dummyList.Add("* ");
                    }
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        dummyList.Add(" ");
                    }
                }
                list.Add(dummyList);
            }

            //row wise
            Console.WriteLine("Row wise:");
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Count; j++)
                {
                    Console.Write(list[i][j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Col Wise");

            //col wise
            for(int i = 0; i < tm; i++)
            {
                for(int j = 0; j < list.Count; j++)
                {
                    for(int k = 0; k < n; k++)
                    {
                        Console.Write(list[j][k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            

             Console.ReadLine();
        }
    }
}