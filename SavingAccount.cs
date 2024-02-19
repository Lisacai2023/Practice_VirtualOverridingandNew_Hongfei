using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_VirtualOverridingandNew_Hongfei
{
    internal class SavingAccount : BankAccount
    {
        double _Interest;
        public SavingAccount(string name,double balance, double interest = 0.1) : base(name, balance)
        {
            _Interest = interest;
        }

        public double Interest { get => _Interest; set => _Interest=value; }

        public override bool Deposit(double amount)
        {
            bool depositamout = base.Deposit(amount);
            if (depositamout)
            {
                _Interest = amount * _Interest;
                Balance += _Interest;
            }
            return depositamout;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - Interest:{_Interest}";

        }
    }
}
