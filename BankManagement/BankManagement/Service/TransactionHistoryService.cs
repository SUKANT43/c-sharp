using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Service
{
    class TransactionHistoryService
    {
        private static List<Model.TransactionHistory> TransactionList = new List<Model.TransactionHistory>
        {
            new Model.TransactionHistory { Account_Number = "ACC1001", ToAccount = "1005", TransactionAmount = 2500 },
            new Model.TransactionHistory { Account_Number = "ACC1002", ToAccount = "1010", TransactionAmount = 1800 },
            new Model.TransactionHistory { Account_Number = "ACC1003", ToAccount = "1008", TransactionAmount = 3200 },
            new Model.TransactionHistory { Account_Number = "ACC1004", ToAccount = "1015", TransactionAmount = 1500 },
            new Model.TransactionHistory { Account_Number = "ACC1005", ToAccount = "1012", TransactionAmount = 2200 },
            new Model.TransactionHistory { Account_Number = "ACC1006", ToAccount = "1001", TransactionAmount = 900 },
            new Model.TransactionHistory { Account_Number = "ACC1007", ToAccount = "1019", TransactionAmount = 4300 },
            new Model.TransactionHistory { Account_Number = "ACC1008", ToAccount = "1002", TransactionAmount = 1100 },
            new Model.TransactionHistory { Account_Number = "ACC1009", ToAccount = "1017", TransactionAmount = 2750 },
            new Model.TransactionHistory { Account_Number = "ACC1010", ToAccount = "1014", TransactionAmount = 3000 },
            new Model.TransactionHistory { Account_Number = "ACC1011", ToAccount = "1006", TransactionAmount = 500 },
            new Model.TransactionHistory { Account_Number = "ACC1012", ToAccount = "1009", TransactionAmount = 3600 },
            new Model.TransactionHistory { Account_Number = "ACC1013", ToAccount = "1020", TransactionAmount = 4200 },
            new Model.TransactionHistory { Account_Number = "ACC1014", ToAccount = "1003", TransactionAmount = 2500 },
            new Model.TransactionHistory { Account_Number = "ACC1015", ToAccount = "1018", TransactionAmount = 3100 },
            new Model.TransactionHistory { Account_Number = "ACC1016", ToAccount = "1004", TransactionAmount = 700 },
            new Model.TransactionHistory { Account_Number = "ACC1017", ToAccount = "1011", TransactionAmount = 1500 },
            new Model.TransactionHistory { Account_Number = "ACC1018", ToAccount = "1007", TransactionAmount = 2200 },
            new Model.TransactionHistory { Account_Number = "ACC1019", ToAccount = "1016", TransactionAmount = 4800 },
            new Model.TransactionHistory { Account_Number = "ACC1020", ToAccount = "1013", TransactionAmount = 3900 },
            new Model.TransactionHistory { Account_Number = "ACC1001", ToAccount = "1010", TransactionAmount = 1200 },
            new Model.TransactionHistory { Account_Number = "ACC1002", ToAccount = "1007", TransactionAmount = 2100 },
            new Model.TransactionHistory { Account_Number = "ACC1003", ToAccount = "1012", TransactionAmount = 900 },
            new Model.TransactionHistory { Account_Number = "ACC1004", ToAccount = "1009", TransactionAmount = 3200 },
            new Model.TransactionHistory { Account_Number = "ACC1005", ToAccount = "1016", TransactionAmount = 500 },
            new Model.TransactionHistory { Account_Number = "ACC1006", ToAccount = "1003", TransactionAmount = 4300 },
            new Model.TransactionHistory { Account_Number = "ACC1007", ToAccount = "1014", TransactionAmount = 2500 },
            new Model.TransactionHistory { Account_Number = "ACC1008", ToAccount = "1018", TransactionAmount = 3700 },
            new Model.TransactionHistory { Account_Number = "ACC1009", ToAccount = "1002", TransactionAmount = 1800 },
            new Model.TransactionHistory { Account_Number = "ACC1010", ToAccount = "1006", TransactionAmount = 600 },
            new Model.TransactionHistory { Account_Number = "ACC1011", ToAccount = "1019", TransactionAmount = 4400 },
            new Model.TransactionHistory { Account_Number = "ACC1012", ToAccount = "1005", TransactionAmount = 2200 },
            new Model.TransactionHistory { Account_Number = "ACC1013", ToAccount = "1017", TransactionAmount = 3500 },
            new Model.TransactionHistory { Account_Number = "ACC1014", ToAccount = "1011", TransactionAmount = 700 },
            new Model.TransactionHistory { Account_Number = "ACC1015", ToAccount = "1008", TransactionAmount = 1950 },
            new Model.TransactionHistory { Account_Number = "ACC1016", ToAccount = "1001", TransactionAmount = 3100 },
            new Model.TransactionHistory { Account_Number = "ACC1017", ToAccount = "1013", TransactionAmount = 2600 },
            new Model.TransactionHistory { Account_Number = "ACC1018", ToAccount = "1012", TransactionAmount = 900 },
            new Model.TransactionHistory { Account_Number = "ACC1019", ToAccount = "1004", TransactionAmount = 2800 },
            new Model.TransactionHistory { Account_Number = "ACC1020", ToAccount = "1007", TransactionAmount = 1200 },

            new Model.TransactionHistory { Account_Number = "ACC1001", ToAccount = "1018", TransactionAmount = 1450 },
            new Model.TransactionHistory { Account_Number = "ACC1002", ToAccount = "1009", TransactionAmount = 2300 },
            new Model.TransactionHistory { Account_Number = "ACC1003", ToAccount = "1015", TransactionAmount = 3100 },
            new Model.TransactionHistory { Account_Number = "ACC1004", ToAccount = "1002", TransactionAmount = 4100 },
            new Model.TransactionHistory { Account_Number = "ACC1005", ToAccount = "1011", TransactionAmount = 1500 },
            new Model.TransactionHistory { Account_Number = "ACC1006", ToAccount = "1008", TransactionAmount = 2700 },
            new Model.TransactionHistory { Account_Number = "ACC1007", ToAccount = "1016", TransactionAmount = 3900 },
            new Model.TransactionHistory { Account_Number = "ACC1008", ToAccount = "1005", TransactionAmount = 2000 },
            new Model.TransactionHistory { Account_Number = "ACC1009", ToAccount = "1014", TransactionAmount = 1400 },
            new Model.TransactionHistory { Account_Number = "ACC1010", ToAccount = "1001", TransactionAmount = 2500 },
            new Model.TransactionHistory { Account_Number = "ACC1011", ToAccount = "1013", TransactionAmount = 3600 },
            new Model.TransactionHistory { Account_Number = "ACC1012", ToAccount = "1010", TransactionAmount = 4700 },
            new Model.TransactionHistory { Account_Number = "ACC1013", ToAccount = "1007", TransactionAmount = 900 },
            new Model.TransactionHistory { Account_Number = "ACC1014", ToAccount = "1019", TransactionAmount = 1900 },
            new Model.TransactionHistory { Account_Number = "ACC1015", ToAccount = "1006", TransactionAmount = 3300 },
            new Model.TransactionHistory { Account_Number = "ACC1016", ToAccount = "1012", TransactionAmount = 2800 },
            new Model.TransactionHistory { Account_Number = "ACC1017", ToAccount = "1003", TransactionAmount = 1100 },
            new Model.TransactionHistory { Account_Number = "ACC1018", ToAccount = "1017", TransactionAmount = 4200 },
            new Model.TransactionHistory { Account_Number = "ACC1019", ToAccount = "1009", TransactionAmount = 500 },
            new Model.TransactionHistory { Account_Number = "ACC1020", ToAccount = "1015", TransactionAmount = 3700 },

            new Model.TransactionHistory { Account_Number = "ACC1001", ToAccount = "1012", TransactionAmount = 2500 },
            new Model.TransactionHistory { Account_Number = "ACC1002", ToAccount = "1003", TransactionAmount = 2900 },
            new Model.TransactionHistory { Account_Number = "ACC1003", ToAccount = "1018", TransactionAmount = 1300 },
            new Model.TransactionHistory { Account_Number = "ACC1004", ToAccount = "1011", TransactionAmount = 4600 },
            new Model.TransactionHistory { Account_Number = "ACC1005", ToAccount = "1019", TransactionAmount = 2100 },
            new Model.TransactionHistory { Account_Number = "ACC1006", ToAccount = "1002", TransactionAmount = 1400 },
            new Model.TransactionHistory { Account_Number = "ACC1007", ToAccount = "1017", TransactionAmount = 3700 },
            new Model.TransactionHistory { Account_Number = "ACC1008", ToAccount = "1004", TransactionAmount = 2400 },
            new Model.TransactionHistory { Account_Number = "ACC1009", ToAccount = "1010", TransactionAmount = 1000 },
            new Model.TransactionHistory { Account_Number = "ACC1010", ToAccount = "1008", TransactionAmount = 3100 },
            new Model.TransactionHistory { Account_Number = "ACC1011", ToAccount = "1014", TransactionAmount = 2900 },
            new Model.TransactionHistory { Account_Number = "ACC1012", ToAccount = "1001", TransactionAmount = 3300 },
            new Model.TransactionHistory { Account_Number = "ACC1013", ToAccount = "1016", TransactionAmount = 4100 },
            new Model.TransactionHistory { Account_Number = "ACC1014", ToAccount = "1005", TransactionAmount = 700 },
            new Model.TransactionHistory { Account_Number = "ACC1015", ToAccount = "1013", TransactionAmount = 1800 },
            new Model.TransactionHistory { Account_Number = "ACC1016", ToAccount = "1007", TransactionAmount = 3500 },
            new Model.TransactionHistory { Account_Number = "ACC1017", ToAccount = "1019", TransactionAmount = 2700 },
            new Model.TransactionHistory { Account_Number = "ACC1018", ToAccount = "1006", TransactionAmount = 4900 },
            new Model.TransactionHistory { Account_Number = "ACC1019", ToAccount = "1009", TransactionAmount = 2600 },
            new Model.TransactionHistory { Account_Number = "ACC1020", ToAccount = "1018", TransactionAmount = 2200 },

        };


        public static void TransactionHistory(bool credentials,string AccNumber)
        {
            if (!credentials)
            {
                return;
            }
             Service.BankSchemaService.CheckBalance(credentials,AccNumber);
            var userTransactions = TransactionList.Where(us => us.Account_Number == AccNumber)
                .Select(v=>new {
                    ToAccount=v.ToAccount,
                    Amount=v.TransactionAmount
                });

            if (userTransactions == null)
            {
                Console.WriteLine("This account not yet started transaction");
            }

            foreach(var det in userTransactions)
            {
                Console.WriteLine($"Transaction to:{det.ToAccount}, Amount: {det.Amount}");
            }
        }


        public static void AddTransaction(bool credentials,string AccNum, string toAccount,int Amount)
        {
            if (!credentials)
            {
                Console.WriteLine("invalid credentials");
                return ;
            }
            TransactionList.Add(new Model.TransactionHistory { Account_Number = AccNum, ToAccount = toAccount, TransactionAmount = Amount });
        }

    }
}
