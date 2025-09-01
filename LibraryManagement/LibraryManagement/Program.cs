using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{

   /* class Program
    {
        public string name;
        public static void print(Dummy d)
        {
            Console.WriteLine(d.name);
        }
      public static void Main(string[] args)
        {
            Dummy a = new Dummy("sukant");
            a.Noti += print;
            a.Trigger();
            Console.ReadLine();
        }  
    }

    class Dummy
    {
        public string name;
        public Dummy(string name)
        {
            this.name = name;
        }
        public delegate void Func(Dummy d);

        public event Func Noti;
        public void Trigger()
        {
            Noti?.Invoke(this);
        }
    }*/
    

    //type 2
    /*class Program
    {
        public static void Main(string[] args)
        {
            Pub p = new Pub("sukant");
            p.notify += print;
            p.trig();
            Console.ReadLine();
        }
        public static void print(object sender,EventArgs e)
        {
            Pub p = sender as Pub;
            Console.WriteLine(p.name);
        }
    }

    class Pub
    {
       public string name;
        public Pub(string name)
        {
            this.name = name;
        }
        public event EventHandler notify;
        public void trig()
        {
            notify?.Invoke(this, EventArgs.Empty);
        }
    }*/

    /*class Program
    {
        static void Main(string[] args)
        {
            MessageEventArgs ms = new MessageEventArgs();
            Console.ReadLine();
        }
    }

    class MessageEventArgs : EventArgs
    {
       private string msg { get; set; }
        public event EventHandler<MessageEventArgs> OnPublish;
        public void RaiseEvent(string Msg)
        {
            OnPublish?.Invoke(this,new MessageEventArgs {msg=Msg});
        }
    }*/

    struct Value
    {
        public int X;
        public int Y { get; set; }
        public Value(int x,int y)
        {
            X = x;
            Y = y;
        }
        public void Display()
        {
            Console.WriteLine($"{X} and {Y}");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Value v1 = new Value(10, 20);
            Value v2;
            v1.Display();
            v2 = v1;
            v2.Y = 99;
            v2.Display();
            v1.Display();
            Console.ReadLine();
        }
    }
}
