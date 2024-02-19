using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Practice_VirtualOverridingandNew_Hongfei
{
    internal class RetirementAccount : SavingAccount
    {
        public RetirementAccount(string name, double balance, double interest = 0.1) : base(name, balance, interest)
        {
        }

        public override bool Withdraw(double amount)
        {
            Console.WriteLine(" Cannot withdraw from a retirement account");
            return false;

        }

        //public override string ToString()
        //{
        //    return $"Cannot withdraw from a retirement account";
        //}
    }
}
