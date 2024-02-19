using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_VirtualOverridingandNew_Hongfei
{
    internal class CheckingAccount : BankAccount
    {
        double _Overdraftfee;
        public CheckingAccount(string name,double balance, double overdraftfee = 50) : base(name,balance)
        {
            _Overdraftfee= overdraftfee;
        }

        public override bool Withdraw(double amount)
        {
            bool withdrawamout = base.Withdraw(amount);
            if (!withdrawamout)
            {
                Balance -= _Overdraftfee;
            }
            return withdrawamout;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - Overdraft fee:{_Overdraftfee:c}";
                //$" Checking Account :{Name} - Account Number :{AccountNumber} - {Balance} - {_Overdraftfee}";
        }
    }
}
