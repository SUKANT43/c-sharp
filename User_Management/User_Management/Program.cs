using System;

namespace User_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            //Service.AddUser("sukant","sukant.ec22@bitsathy.ac.in",18);
            //Service.DeleteUser(1);
            //Service.UpdateUser(2,"sukant","sukant98657@gmail.com",22);
            Service.GetUserData();

            Create.ev += Print;
            Create.create("sukant");
            Create.create("vijay");


            Console.ReadLine();
        }

        public static void Print(object e,Demo d)
        {
            Console.WriteLine(d.name);
        }
    }

    class Demo : EventArgs
    {
        public string name;
        public Demo(string na)
        {
            name = na;
        }
    }

    class Create
    {
        public static event EventHandler<Demo> ev;

        public static void create(string n)
        {
            Demo d = new Demo(n);
            ev?.Invoke(null, d);
        }
    }

    

}
