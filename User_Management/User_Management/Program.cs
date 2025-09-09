using System;

namespace User_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            //Service.AddUser("sukant","sukant.ec22@bitsathy.ac.in",18);
            //Service.DeleteUser(1);
            Service.UpdateUser(2,"sukant","sukant98657@gmail.com",22);
            Service.GetUserData();
            Console.ReadLine();
        }
    }
}
