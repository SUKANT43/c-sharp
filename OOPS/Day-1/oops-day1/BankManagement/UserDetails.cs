using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    class UserDetails
    {
        private string accNo;
        private string name;
        private long balance;

        public UserDetails(string accNo, string name, long balance)
        {
            this.accNo = accNo;
            this.name = name;
            this.balance = balance;
        }

        public string AccNo
        {
            get { return accNo; }
            set { accNo = value; }
        }

        public string Pass
        {
            get { return name; }
            set { name = value; }
        }

        public long Credit
        {
            set {if(value>0) balance+= value;}
        }

        public long Debit
        {
            set {if(balance>=value) balance -= value; }
        }

        public long checkBalance
        {
            get { return balance; }
        }
    }

    class setUserDetails
    {
        public static List<UserDetails> userDetailList = new List<UserDetails>
        {
            new UserDetails("ACC1001", "Sukant",100023),
            new UserDetails("ACC1002", "Vijay",150023),
            new UserDetails("ACC1003", "Ranjith",23000)
        };

    }
}
