using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharppractice.Classes
{
    public class BankAccount
    {
        private double _balance { get; set; }
        public double Balance
        {
            get
            {
                if (_balance < 1000000)
                {
                    return _balance;
                }
                else
                {
                    return 100000;
                }
                
            }
            protected set
            {
                if (value > 0)
                {
                    _balance = value;
                }
                else
                {
                    _balance = 0;
                }
                
            }

        }

        //propfull

        //private int myVar;
        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}

        public BankAccount()
        {
            Balance = 100;
        }

        public double AddBalance(double BalanceToBeAdded)
        {
            Balance += BalanceToBeAdded;
            return Balance;
        }

        public class ChildBankAccount : BankAccount
        {
            public ChildBankAccount()
            {
                Balance = 10;
            }
        }
    }
}
