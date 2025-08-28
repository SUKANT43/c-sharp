using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Service
{
    class BankSchemaService
    {
        private static List<Model.BankSchema> BankSchemaList = new List<Model.BankSchema>
        {
            new Model.BankSchema { Name = "John D", Account_Number = "ACC1001", Balance = 1500 },
            new Model.BankSchema { Name = "Jane S", Account_Number = "ACC1002", Balance = 2500 },
            new Model.BankSchema { Name = "Alice J", Account_Number = "ACC1003", Balance = 3050 },
            new Model.BankSchema { Name = "Bob W", Account_Number = "ACC1004", Balance = 4200 },
            new Model.BankSchema { Name = "Charlie B", Account_Number = "ACC1005", Balance = 1820 },
            new Model.BankSchema { Name = "David M", Account_Number = "ACC1006", Balance = 7600 },
            new Model.BankSchema { Name = "Emma D", Account_Number = "ACC1007", Balance = 1200 },
            new Model.BankSchema { Name = "Frank W", Account_Number = "ACC1008", Balance = 8900 },
            new Model.BankSchema { Name = "Grace T", Account_Number = "ACC1009", Balance = 5600 },
            new Model.BankSchema { Name = "Henry M", Account_Number = "ACC1010", Balance = 5000 },
            new Model.BankSchema { Name = "Ivy C", Account_Number = "ACC1011", Balance = 2300 },
            new Model.BankSchema { Name = "Jack L", Account_Number = "ACC1012", Balance = 9500 },
            new Model.BankSchema { Name = "Karen H", Account_Number = "ACC1013", Balance = 7400 },
            new Model.BankSchema { Name = "Liam A", Account_Number = "ACC1014", Balance = 3300 },
            new Model.BankSchema { Name = "Mia Y", Account_Number = "ACC1015", Balance = 6400 },
            new Model.BankSchema { Name = "Noah H", Account_Number = "ACC1016", Balance = 3150 },
            new Model.BankSchema { Name = "Olivia K", Account_Number = "ACC1017", Balance = 2890 },
            new Model.BankSchema { Name = "Paul W", Account_Number = "ACC1018", Balance = 750 },
            new Model.BankSchema { Name = "Quinn S", Account_Number = "ACC1019", Balance = 4150 },
            new Model.BankSchema { Name = "Rachel G", Account_Number = "ACC1020", Balance = 9850 }
        };

        public static bool CheckBalance(bool credential,string Account_Number)
        {
            var FindUser = BankSchemaList.Where(acc=>acc.Account_Number==Account_Number).First();
            Console.WriteLine($"Name: {FindUser.Name}, Account Number: {FindUser.Account_Number}, Balance:{FindUser.Balance}");
            return true;
        }
    }
}
