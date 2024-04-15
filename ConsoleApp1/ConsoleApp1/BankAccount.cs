using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BankAccount
    {
        public string Name { get; set; }
        public int AccountNumber { get; set; }
        public double Balance { get; set; }

        public BankAccount(string name, int accountNumber, double balance) {
            
            Name = name;
            AccountNumber = accountNumber;
            Balance = balance;

        }
       


    }
}
