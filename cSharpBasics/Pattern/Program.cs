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
            int n = 3;
            int tm = 3;
            List<List<string>> list = new List<List<string>>();
            //upper Triangle
            for(int i = 1; i <= n; i++)
            {
                List<string> dummyList = new List<string>();

                for (int time = 1; time <= tm; time++)
                {
                    for (int j = 1; j <= n - i; j++)
                    {
                        dummyList.Add(" ");
                    }
                    for (int k = 1; k <= 2 * i - 1; k++)
                    {
                        dummyList.Add("*");
                    }
                    for (int j = 1; j <= n - i; j++)
                    {
                        dummyList.Add(" ");
                    }

                }

               
                list.Add(dummyList);
            }

            //lower Triangle
            for (int i = n; i >=1; i--)
            {
                List<string> dummyList = new List<string>();
                for (int time = 1; time <= tm; time++)
                {
                    for (int j = 1; j <= n - i; j++)
                    {
                        dummyList.Add(" ");
                    }
                    for (int k = 1; k <= 2 * i - 1; k++)
                    {
                        dummyList.Add("*");
                    }
                    for (int j = 1; j <= n - i; j++)
                    {
                        dummyList.Add(" ");
                    }
                }
               
                list.Add(dummyList);
            }



            for (int i = 0; i < list.Count; i++)
            {
                for(int j = 0; j < list[i].Count; j++)
                {
                    Console.Write(list[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
