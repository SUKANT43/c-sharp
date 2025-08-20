using System;
using System.Collections.Generic;

namespace BankManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var user in setUserDetails.userDetailList)
            {
                Console.WriteLine($"Account: {user.AccNo}, Name: {user.Pass}, Balance: {user.checkBalance}");
            }

            Console.WriteLine("\n--- Performing Transactions ---");

            var sukant = setUserDetails.userDetailList[0];

            sukant.Credit = 5000;
            Console.WriteLine($"After crediting 5000, Balance of {sukant.Pass}: {sukant.checkBalance}");

            sukant.Debit = 3000;
            Console.WriteLine($"After debiting 3000, Balance of {sukant.Pass}: {sukant.checkBalance}");

            sukant.Debit = 200000; 
            Console.WriteLine($"After trying overdraft, Balance of {sukant.Pass}: {sukant.checkBalance}");

            sukant.Pass = "Sukant C";
            Console.WriteLine($"Updated Name: {sukant.Pass}");

            Console.WriteLine("\n--- Final Account Details ---");
            foreach (var user in setUserDetails.userDetailList)
            {
                Console.WriteLine($"Account: {user.AccNo}, Name: {user.Pass}, Balance: {user.checkBalance}");
            }
            Console.ReadLine();
        }
    }
}
