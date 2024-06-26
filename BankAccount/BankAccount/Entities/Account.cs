﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance) 
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void withdraw(double amount) 
        {
            Balance -= amount;
        }

        public void deposit(double amount)
        {
            Balance += amount;
        }
    }
}
