using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace TypeConversion
{
    class Collections
    {
        public static void display()
        {
            Console.WriteLine("Non-Generic:");
            Console.WriteLine("List: ");
            ArrayList list1 = new ArrayList();
            list1.Add("hi");
            list1.Add(2);
            list1.Add(4);
            list1.Remove(4);
            
            for(int i = 0; i < list1.Count; i++)
            {
                dynamic ans = list1[i];
                Console.WriteLine(ans);
            }

            Console.WriteLine("Stack: ");
            Stack st1 = new Stack();
            st1.Push(10);
            st1.Push("Hello");
            st1.Push("Hey");
            dynamic b = st1.Pop();
            Console.WriteLine(b);
            st1.Peek();
            Console.WriteLine(st1.Count);

            Console.WriteLine("Queue: ");
            Queue q1 = new Queue();
            q1.Enqueue(10);
            q1.Enqueue(20);
            object c = (int)q1.Dequeue();
            Console.WriteLine(c);
            q1.Enqueue(10);
            Console.WriteLine(q1.Peek());
            Console.WriteLine(q1.Count);

            Console.WriteLine("Generic: ");
            Console.WriteLine("List");
            List<int> list2 = new List<int>();
            list2.Add(10);
            list2.Add(30);
            list2.Add(40);
            list2.Remove(40);
            for(int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine(list2[i]);
            }

            Console.WriteLine("Set");
            HashSet<int> set = new HashSet<int>();
            set.Add(10);
            set.Add(10);
            set.Add(100);
            set.Add(200);
            Console.WriteLine(set.Count);
            foreach(int e in set)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Dictionary");
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "hi");
            dict.Add(2, "hello");
            dict.Add(3, "hey");
            Console.WriteLine(dict.Remove(3));
            Console.WriteLine(dict.Count);

            foreach(KeyValuePair<int,string>pair in dict)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }

            Console.Write("Count the frequency of the number using Dictionary");
            int[] arr = { 10, 20, 30, 40, 50, 20, 60, 70, 10, 80, 90, 100, 30, 110, 120, 130, 40, 140, 150, 160, 170, 180, 190, 100, 200, 210, 220, 230, 240, 250 };

            Dictionary<int, int> dict2 = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)

            {
                if (dict2.ContainsKey(arr[i]))
                {
                    dict2[arr[i]] += 1;
                }
                else
                {
                    dict2[arr[i]] = 1;
                }
            }

            foreach(var pair in dict2)
            {
                Console.WriteLine($"Number: {pair.Key}, Count: {pair.Value}");
            }

            Console.WriteLine("ArrayList methods");
            List<int> list = new List<int>();
            list.Add(10);
            list.AddRange(new int[] {1,2,3,4,5,6,7,7, });
            list.Insert(0, 100);
            list.Remove(4);
            list.RemoveAt(5);
            Console.WriteLine(list.Contains(7));
            Console.WriteLine(list.IndexOf(5));
            Console.WriteLine(list.Count);
            list.Sort();
            list.Reverse();
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
