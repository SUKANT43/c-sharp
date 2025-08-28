using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Service
{
    class CustomerCredentialService
    {
        private static List<BankManagement.Model.CustomerCredentials> CustomerCredentialList = new List<BankManagement.Model.CustomerCredentials>
        {
            new BankManagement.Model.CustomerCredentials { Account_number = "ACC1001", UserName = "John D", Password = "pass1001" },
            new BankManagement.Model.CustomerCredentials { Account_number = "ACC1002", UserName = "Jane S", Password = "pass1002" },
            new BankManagement.Model.CustomerCredentials { Account_number = "ACC1003", UserName = "Alice J", Password = "pass1003" },
            new BankManagement.Model.CustomerCredentials { Account_number = "ACC1004", UserName = "Bob W", Password = "pass1004" },
            new BankManagement.Model.CustomerCredentials { Account_number = "ACC1005", UserName = "Charlie B", Password = "pass1005" },
            new BankManagement.Model.CustomerCredentials { Account_number = "ACC1006", UserName = "David M", Password = "pass1006" },
            new BankManagement.Model.CustomerCredentials { Account_number = "ACC1007", UserName = "Emma D", Password = "pass1007" },
            new BankManagement.Model.CustomerCredentials { Account_number = "ACC1008", UserName = "Frank W", Password = "pass1008" },
            new BankManagement.Model.CustomerCredentials { Account_number = "ACC1009", UserName = "Grace T", Password = "pass1009" },
            new BankManagement.Model.CustomerCredentials { Account_number = "ACC1010", UserName = "Henry M", Password = "pass1010" },
            new BankManagement.Model.CustomerCredentials { Account_number = "ACC1011", UserName = "Ivy C", Password = "pass1011" },
            new BankManagement.Model.CustomerCredentials { Account_number = "ACC1012", UserName = "Jack L", Password = "pass1012" },
            new BankManagement.Model.CustomerCredentials { Account_number = "ACC1013", UserName = "Karen H", Password = "pass1013" },
            new BankManagement.Model.CustomerCredentials { Account_number = "ACC1014", UserName = "Liam A", Password = "pass1014" },
            new BankManagement.Model.CustomerCredentials { Account_number = "ACC1015", UserName = "Mia Y", Password = "pass1015" },
            new BankManagement.Model.CustomerCredentials { Account_number = "ACC1016", UserName = "Noah H", Password = "pass1016" },
            new BankManagement.Model.CustomerCredentials { Account_number = "ACC1017", UserName = "Olivia K", Password = "pass1017" },
            new BankManagement.Model.CustomerCredentials { Account_number = "ACC1018", UserName = "Paul W", Password = "pass1018" },
            new BankManagement.Model.CustomerCredentials { Account_number = "ACC1019", UserName = "Quinn S", Password = "pass1019" },
            new BankManagement.Model.CustomerCredentials { Account_number = "ACC1020", UserName = "Rachel G", Password = "pass1020" }
        };
        public static bool GiveCredentials(string acc_num,string userName, string Password)
        {
            var FindUser = CustomerCredentialList.Where(acc => acc.Account_number == acc_num).FirstOrDefault();
            if (FindUser == null)
            {
                Console.WriteLine($"Login Failed or Invalid details Try Again.");
                return false;
            }
            if (FindUser.UserName==userName && FindUser.Password == Password)
            {
                Console.WriteLine($"Successfully Logined {FindUser.UserName}.");
                return true;
            }
            Console.WriteLine($"Login Failed or Invalid details Try Again.");
            return false;
        }
    }
}
