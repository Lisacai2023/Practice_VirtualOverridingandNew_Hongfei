using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_VirtualOverridingandNew_Hongfei
{
    internal class BankAccount
    {
        string _Name;
        string _AccountNumber;
        double _Balance;

        public string Name { get => _Name; set => _Name=value; }
        public string AccountNumber { get => _AccountNumber;}
        public double Balance { get => _Balance; protected set => _Balance=value; }

        Random random = new Random();

        public BankAccount(string name,double balance)
        {
            _Name=name;
            _AccountNumber= random.Next(1000,2000).ToString();
            _Balance=balance;
        }

        public virtual bool Deposit(double amount)
        {
            if (IsAmountnePositive(amount))
            {
                Balance += amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool Withdraw(double amount)
        {

            if (IsAmountnePositive(amount) && amount <= Balance)
            {
                Balance -= amount;
                return true;
            }
            else 
            {
                return false;
            }

        }

        public static bool IsAmountnePositive(double amount)
        {
            return amount>0;
        }

        public override string ToString()
        {
            return $" Account name :{Name} - Account Number :{AccountNumber} - Balance:{Balance}";
        }




    }
}
