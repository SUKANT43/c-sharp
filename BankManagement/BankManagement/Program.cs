using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    class Program
    {
        public static void UserManual(){
            Console.WriteLine("\n\n");
            Console.WriteLine("Click 1 for Check Balance");
            Console.WriteLine("Click 2 for View Transaction History");
            Console.WriteLine("Click 3 for Amount Transaction");
            Console.WriteLine("Click any key for exit");
        }
        static void Main(string[] args)
        {
            int navigate = 1;
            Console.WriteLine("Enter 1 for User and 2 for Admin");
            navigate = int.Parse(Console.ReadLine());
            bool user = false;
            bool admin = false;
            bool credential = false;
            string  name, pass="";
            string accNum = null;
            if (navigate == 1)
            {
                user = true;
            }
            else if (navigate == 2)
            {
                admin = true;
            }

            if (navigate == 1||navigate==2)
            {
                while (user)
                {
                    if (!credential)
                    {
                        Console.WriteLine("Enter your User Account Number:");
                         accNum = Console.ReadLine();
                        Console.WriteLine("Enter your User Name:");
                         name = Console.ReadLine();
                        Console.WriteLine("Enter Your Password");
                         pass = Console.ReadLine();
                        credential = Service.CustomerCredentialService.GiveCredentials(accNum, name, pass);

                    }
                    if (!credential)
                    {
                        int retry = -1;
                        Console.WriteLine("Enter 1 for retry else press any key for exit: ");
                        try
                        {
                             retry = int.Parse(Console.ReadLine());
                        }
                        catch(Exception e)
                        {
                            user = false;
                        }
                        if (retry==1)
                        {
                            user = true;
                        }
                        else
                        {
                            user = false;
                        }
                    }

                    if (credential)
                    {
                        UserManual();
                        Console.WriteLine("Pick any Choice");
                        int choice = -1;
                        try
                        {
                            choice = int.Parse(Console.ReadLine());
                        } 
                        catch (Exception e)
                        {
                            credential = false;
                            user = false;
                        }
                        if (credential && choice == 1 && user)
                        {
                            Service.BankSchemaService.CheckBalance(credential,accNum);
                        }
                        else if(credential && choice == 2 && user)
                        {
                            Service.TransactionHistoryService.TransactionHistory(credential, accNum);
                        }
                        else if (choice > 3 || choice < 1)
                        {
                            credential = false;
                            user = false;
                        }
                    }
                }
                while (admin)
                {

                }
            }
            else{
                Console.WriteLine("Choose Valid Choice");
            }
            Console.WriteLine("Exiting....");
            Console.ReadLine();
        }
    }
}
